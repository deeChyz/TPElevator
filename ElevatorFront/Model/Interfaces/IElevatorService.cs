using System;
using System.Collections.Generic;

namespace Model.Interfaces
{
    public interface IElevatorService
    {
        event Action WeightAlert;
        event Action DisableWeightAlert;
        event Action FreeRideDone;
        event Action RideDone;
        event Action<int> ElevatorMove;
        event Action<int> PassengerGotOut;
        event Action<int> PassengerDeleted;
        event Action<int> PassengerGotIn;
        event Action<double> TimeWasUpdated;
        event Action<int> ButtonPressed;
        event Action<int> FloorButtonPressed;
        event Action<List<Passenger>> UpdatePassengerStats;
        event Action<double> TotalDeliveredMassIncreased;

        List<Passenger> Passengers { get; set; }
        Elevator Elevator { get; set; }
        StatisticMaker StatisticMaker { get; set; }
        bool[] ClickedFloors { get; set; }
        int NumberOfFloors { get; set; }
        bool Overweight { get; set; }

        bool AddNewPassenger(string name, int destination, int startFloor);
        void ChangeWeightState();
        Directions CheckDirection();
        void UpdatePassengerData();
        void InitializeFloors(int n);
        void InitializeTimer();
        void StartTime();
        void StopTime();
        void ResetElevatorStats();
        void ResetWeightWarning();
        void MoveElevator();
        void MovePassenger(Passenger passenger);
    }
}
