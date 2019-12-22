using Model.Interfaces;
using Presentation.Interfaces.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorFront
{
    public partial class BuildingView : Form, IBuildingView
    {
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
            for (int i = 0; i < elevatorService.NumberOfFloors; i++)
            {
                var floorCell = new FloorCell();
                floorMainPanel.Controls.Add(floorCell);
                floorButtonIndicatorsBox.Controls.Add(new FloorIndicator());
                var j = i;
                floorCell.OpenAddNewPassengerView += () => InvokeAddNewPassengerEvent(j+1);
            }

            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек ждет лифта на 1 этаже"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек едет на 3 этаж"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек едет на 3 этаж"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек едет на 3 этаж"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек ждет лифта на 2 этаже"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек доставлен на целевой этаж 2 "));

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

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
            throw new NotImplementedException();
        }

        public void PressElevatorButtonCheckbox(int FloorNumber)
        {
            throw new NotImplementedException();
        }

        public void MoveElevator(int Destination)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void TransferPassengerFromElevator(int FloorNumber)
        {
            throw new NotImplementedException();
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
    }
}
