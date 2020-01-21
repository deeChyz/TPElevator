using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Model
{
    public class ElevatorService : IElevatorService
    {
        public int NumberOfFloors { get; set; } 
        public bool[] ClickedFloors { get; set; }
        private Floor[] floors;
        public Floor[] Floors
        {
            get { return floors; }
        }
        public List<Passenger> Passengers { get; set; }
        public Elevator Elevator { get; set; }
        public StatisticMaker StatisticMaker { get; set; }
        public bool Overweight { get; set; }

        private readonly Timer Timer = new Timer();
        private double Time;
        private double UpdatePassengerMoveTime;
        private double UpdateElevatorMoveTime;
        
        public event Action WeightAlert;
        public event Action DisableWeightAlert;
        public event Action FreeRideDone;
        public event Action RideDone;
        public event Action<int> PassengerGotOut;
        public event Action<int> PassengerGotIn;
        public event Action<double> TimeWasUpdated;
        public event Action<int> ButtonPressed; 
        public event Action<int> PassengerDeleted;
        public event Action<List<Passenger>> UpdatePassengerStats;
        public event Action<int> FloorButtonPressed;
        public event Action<double> TotalDeliveredMassIncreased;
        public event Action<int> ElevatorMove;

        public ElevatorService()
        {
            Overweight = false;
            StatisticMaker = new StatisticMaker();
        }

        public void InitializeFloors(int n)
        {
            this.Elevator = new Elevator(n);
            this.ClickedFloors = new bool[n];
            this.Passengers = new List<Passenger>();
            this.floors = new Floor[n];
            for (int i = 0; i < n; i++)
            {
                this.floors[i] = new Floor();
            }  
        }

        public bool AddNewPassenger(string name, int destination, int startFloor)
        {
            Passenger passenger = new Passenger(startFloor, destination, States.Waiting, new Random().Next(0, 100), name);
            this.Passengers.Add(passenger);
            floors[startFloor-1].Passengers.Add(passenger);
            return true;
        }

        public Directions CheckDirection()
        {
            return Elevator.CurrentDirection;
        }

        public void ChangeWeightState()
        {
            if (Elevator.TotalWeight < Elevator.MaxWeight) {
                Overweight = false;
            } else {
                Overweight = true;
            }
        }

        public void UpdatePassengerData()
        {
            UpdatePassengerStats?.Invoke(this.Passengers);
        }

        public void InitializeTimer()
        {
            Timer.Interval = 1000;
            Timer.Tick += OnTimerTick;
        }

        public void StartTime()
        {
            InitializeTimer();
            this.Time = 0;
            this.UpdateElevatorMoveTime = 2;
            this.UpdatePassengerMoveTime = 0;
            this.Timer.Start();
        }

        public void StopTime()
        {
            this.Timer.Stop();
            this.Passengers.Clear();
            this.ResetElevatorStats();
            for (int i = 0; i < NumberOfFloors; i++)
            {
                this.ClickedFloors[i] = false;
            }
        }

        public void ResetElevatorStats()
        {
            this.Elevator.CurrentFloor = 1;
            this.Elevator.CurrentDirection = Directions.None;
            for (int i = 0; i < NumberOfFloors; i++) {
                this.Elevator.ControlPanel.ClickedFloors[i] = false;
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            Time = Time + 1;
            TimeWasUpdated?.Invoke(this.Time);
            ChangeWeightState();
            if (this.Time >= this.UpdateElevatorMoveTime + 4) {
                if (Overweight == true) {
                    ResetWeightWarning();
                }
                this.UpdateElevatorMoveTime = this.Time;
                MoveElevator();
            }
            if (Time >= UpdatePassengerMoveTime + 4) {
                UpdatePassengerMoveTime = Time;

                while (true){
                    bool deleted = false;
                    foreach (Passenger passenger in Passengers) {
                        if (passenger.State == States.Delivered) {
                            PassengerDeleted?.Invoke(passenger.DeliveryFloor);
                            Passengers.Remove(passenger);
                            deleted = true;
                            this.UpdatePassengerData();
                            break;
                        }
                    }
                    if (deleted == false) {
                        break;
                    }
                }

                foreach (Passenger passenger in Passengers) {
                    MovePassenger(passenger);
                }
            }
        }

        public void ResetWeightWarning()
        {
            Overweight = false;
            DisableWeightAlert?.Invoke();
        }

        public void MoveElevator()
        {
            if (!Elevator.ControlPanel.ClickedFloors.Contains(true) && ClickedFloors.Contains(true))
            {
                for (int i = NumberOfFloors; i > 0; i--)
                {
                    if (ClickedFloors[i - 1] == true)
                    {
                        if (i > Elevator.CurrentFloor)
                        {
                            if (CheckDirection() == Directions.Down)
                            {
                                RideDone?.Invoke();
                                FreeRideDone?.Invoke();
                            }
                            Elevator.CurrentDirection = Directions.Up;
                        }
                        else if (i < Elevator.CurrentFloor)
                        {
                            if (CheckDirection() == Directions.Up)
                            {
                                RideDone?.Invoke();
                                FreeRideDone?.Invoke();
                            }
                            Elevator.CurrentDirection = Directions.Down;
                        }
                        Elevator.CurrentFloor = i;
                        ClickedFloors[i - 1] = false;
                        Elevator.ControlPanel.ClickedFloors[i - 1] = false;
                        ElevatorMove?.Invoke(i);
                        break;
                    }
                }
            } else if (Elevator.ControlPanel.ClickedFloors.Contains(true)) {
                if (CheckDirection() == Directions.None) {
                    for (int i = NumberOfFloors; i > Elevator.CurrentFloor; i--) {
                        if (Elevator.ControlPanel.ClickedFloors[i - 1] == true) {
                            Elevator.CurrentDirection = Directions.Up;
                            break;
                        }
                    }
                    for (int i = 1; i < Elevator.CurrentFloor; i++) {
                        if (Elevator.ControlPanel.ClickedFloors[i - 1] == true) {
                            Elevator.CurrentDirection = Directions.Down;
                            break;
                        }
                    }
                }

                if (CheckDirection() == Directions.Up) {
                    bool GoOppositeWay = true;
                    for (int i = Elevator.CurrentFloor; i <= NumberOfFloors; i++) {
                        if (Elevator.ControlPanel.ClickedFloors[i - 1] == true) {
                            Elevator.CurrentFloor = i;
                            ClickedFloors[i - 1] = false;
                            Elevator.ControlPanel.ClickedFloors[i - 1] = false;
                            foreach (Passenger passenger in Passengers) {
                                if (passenger.State == States.Riding) {
                                    passenger.InitialFloor = Elevator.CurrentFloor;
                                    UpdatePassengerData();
                                }
                            }
                            GoOppositeWay = false;
                            ElevatorMove?.Invoke(i);
                            break;
                        }
                    }
                    if (GoOppositeWay == true) {
                        Elevator.CurrentDirection = Directions.Down;
                        //RideDone?.Invoke();
                        StatisticMaker.IncrementNumberOfFreeRides();
                        for (int i = Elevator.CurrentFloor; i > 0; i--) {
                            if (Elevator.ControlPanel.ClickedFloors[i - 1] == true || ClickedFloors[i - 1] == true) {
                                Elevator.CurrentFloor = i;
                                ClickedFloors[i - 1] = false;
                                Elevator.ControlPanel.ClickedFloors[i - 1] = false;
                                foreach (Passenger passenger in Passengers) {
                                    if (passenger.State == States.Riding) {
                                        passenger.InitialFloor = Elevator.CurrentFloor;
                                        UpdatePassengerData();
                                    }
                                }
                                ElevatorMove?.Invoke(i);
                                break;
                            }
                        }
                    }
                }
                else if (CheckDirection() == Directions.Down) {
                    bool GoOppositeWay = true;
                    for (int i = Elevator.CurrentFloor; i > 0; i--) {
                        if (Elevator.ControlPanel.ClickedFloors[i - 1] == true || ClickedFloors[i - 1] == true) {
                            Elevator.CurrentFloor = i;
                            ClickedFloors[i - 1] = false;
                            Elevator.ControlPanel.ClickedFloors[i - 1] = false;
                            foreach (Passenger passenger in Passengers) {
                                if (passenger.State == States.Riding) {
                                    passenger.InitialFloor = Elevator.CurrentFloor;
                                    UpdatePassengerData();
                                }
                            }
                            GoOppositeWay = false;
                            ElevatorMove?.Invoke(i);
                            break;
                        }
                    }
                    if (GoOppositeWay == true) {
                        Elevator.CurrentDirection = Directions.Up;
                        RideDone?.Invoke();
                        for (int i = Elevator.CurrentFloor; i <= NumberOfFloors; i++) {
                            if (Elevator.ControlPanel.ClickedFloors[i - 1] == true) {
                                Elevator.CurrentFloor = i;
                                ClickedFloors[i - 1] = false;
                                Elevator.ControlPanel.ClickedFloors[i - 1] = false;
                                foreach (Passenger passenger in Passengers) {
                                    if (passenger.State == States.Riding) {
                                        passenger.InitialFloor = Elevator.CurrentFloor;
                                        UpdatePassengerData();
                                    }
                                }
                                GoOppositeWay = false;
                                ElevatorMove?.Invoke(i);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void MovePassenger(Passenger passenger)
        {
            if (passenger.State == States.Waiting && Elevator.CurrentFloor == passenger.InitialFloor) {
                if (Elevator.TotalWeight + passenger.Weight < Elevator.MaxWeight) {
                    passenger.State = States.Riding;
                    Elevator.TotalWeight += passenger.Weight;
                    PassengerGotIn?.Invoke(Elevator.CurrentFloor, passenger.name);
                    UpdatePassengerData();
                    if (Elevator.ControlPanel.ClickedFloors[passenger.DeliveryFloor - 1] == false)
                    {
                        Elevator.ControlPanel.ClickedFloors[passenger.DeliveryFloor - 1] = true;
                        ButtonPressed?.Invoke(passenger.DeliveryFloor);
                    }
                }
                else {
                    WeightAlert?.Invoke();
                    Overweight = true;
                }
            } else if (passenger.State == States.Waiting && (ClickedFloors[passenger.InitialFloor - 1] == false)) {
                ClickedFloors[passenger.InitialFloor - 1] = true;
                FloorButtonPressed?.Invoke(passenger.InitialFloor);
            } else if (passenger.State == States.Riding && Elevator.CurrentFloor == passenger.DeliveryFloor) {
                passenger.State = States.Delivered;
                Elevator.TotalWeight -= passenger.Weight;
                PassengerGotOut?.Invoke(Elevator.CurrentFloor);
                TotalDeliveredMassIncreased?.Invoke(passenger.Weight);
                UpdatePassengerData();
            }
        }
    }
}
