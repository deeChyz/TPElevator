using Model.Interfaces;
using Presentation.Interfaces.Views;
using System;
using System.Windows.Forms;

namespace ElevatorFront
{
    public partial class BuildingView : Form, IBuildingView
    {
        private FloorCell[] FloorCells;

        public int CurrentNumberOfPassengers { get; set; }

        public event Action<int> AddNewPassenger;
        public event Action StartSimulation;
        public event Action StopSimulation;
        public event Action ShowPassengersInfo;

        private void InvokeAddNewPassengerEvent(int currentFloor)
        {
            AddNewPassenger.Invoke(currentFloor);
        }

        public BuildingView(IElevatorService elevatorService)
        {
            InitializeComponent();
            FloorCells = new FloorCell[elevatorService.NumberOfFloors];
            for (int i = 0; i < elevatorService.NumberOfFloors; i++)
            {
                FloorCells[i] = new FloorCell();
                floorMainPanel.Controls.Add(FloorCells[i]);
                floorButtonIndicatorsBox.Controls.Add(new FloorIndicator());
                var j = i;
                FloorCells[i].OpenAddNewPassengerView += () => InvokeAddNewPassengerEvent(j + 1);
            }
            FloorCells[0].ElevatorBox.Visible = true;
            FloorCells[0].ElevatorBox.Text = "0";
            CurrentNumberOfPassengers = 0;
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек ждет лифта на 1 этаже"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек едет на 3 этаж"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек едет на 3 этаж"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек едет на 3 этаж"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек ждет лифта на 2 этаже"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек доставлен на целевой этаж 2 "));

        }

        public void DrawPassenger(int currentFloor, string name)
        {
            Button button = new Button();
            button.BackColor = System.Drawing.Color.Pink;
            button.Location = new System.Drawing.Point(3, 3);
            button.Name = new Random().Next(0, 1000) * 41 / 80 + "";
            button.Size = new System.Drawing.Size(25, 25);
            button.Text = name.Substring(0, 1);
            button.TabIndex = 4;
            button.UseVisualStyleBackColor = false;
            button.Visible = true;
            FloorCells[currentFloor - 1].flowLayoutPanelForPassengers.Controls.Add(button);
        }

        public void UpdateTime(double Time)
        {
            label1.Text = $"Time: {Time.ToString()}";
        }

        public void DisableWeightAlert()
        {
            weightIndicator.BackColor = System.Drawing.Color.DarkGray;
        }

        public void EnableWeightAlert()
        {
            weightIndicator.BackColor = System.Drawing.Color.DarkRed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartSimulation?.Invoke();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopSimulation?.Invoke();
        }

        private void floorMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void floorButtonIndicatorsBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void peopleCounterLabel_Click(object sender, EventArgs e)
        {

        }

        public void PressFloorButtonCheckbox(int FloorNumber)
        {
            FloorCells[FloorNumber - 1].elevetorCellCheckbox.Checked = true;
        }

        public void PressElevatorButtonCheckbox(int FloorNumber)
        {
            throw new NotImplementedException();
        }

        public void MoveElevator(int Destination)
        {
            FloorCells[Destination - 1].ElevatorBox.Visible = true;
            FloorCells[Destination - 1].elevetorCellCheckbox.Checked = false;
            for (var i = 0; i < FloorCells.Length; i++)
            {
                if (i != (Destination - 1))
                {
                    FloorCells[i].ElevatorBox.Visible = false;
                }
            }
        }

        public void IncreaseNumberOfRides()
        {
            throw new NotImplementedException();
        }

        public void IncreaseNumberOfFreeRides()
        {
            throw new NotImplementedException();
        }

        public void ShowOverweightWarning()
        {
            throw new NotImplementedException();
        }

        public void HideOverweightWarning()
        {
            throw new NotImplementedException();
        }

        public void TransferPassengerToElevator(int FloorNumber)
        {
            CurrentNumberOfPassengers += FloorCells[FloorNumber - 1].flowLayoutPanelForPassengers.Controls.Count;
            FloorCells[FloorNumber - 1].ElevatorBox.Text = CurrentNumberOfPassengers.ToString();
            FloorCells[FloorNumber - 1].flowLayoutPanelForPassengers.Controls.Clear();
        }

        public void TransferPassengerFromElevator(int FloorNumber)
        {
            Button button = new Button();
            button.BackColor = System.Drawing.Color.Pink;
            button.Location = new System.Drawing.Point(3, 3);
            button.Name = "Out";
            button.Size = new System.Drawing.Size(25, 25);
            button.TabIndex = 4;
            button.UseVisualStyleBackColor = false;
            button.Visible = true;
            FloorCells[FloorNumber - 1].MovedOutPassengers.Controls.Add(button);
            DecreaseCurrentNumberOfPassenger();
            FloorCells[FloorNumber - 1].ElevatorBox.Text = CurrentNumberOfPassengers.ToString();
        }

        public void DispellPassenger(int FloorNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateTimeStatistics(double Time)
        {
            throw new NotImplementedException();
        }

        public void UpdateTotalWeightStatistics(int WeightToAdd)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int IncreaseCurrentNumberOfPassengers()
        {
            return ++CurrentNumberOfPassengers;
        }

        public int DecreaseCurrentNumberOfPassenger()
        {
            return --CurrentNumberOfPassengers;
        }

        public void DeletePessanger(int FloorNumber)
        {
            FloorCells[FloorNumber - 1].MovedOutPassengers.Controls.Clear();
        }
    }
}
