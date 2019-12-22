using System;
using Model.Interfaces;

namespace Model
{
    public class ElevatorControlPanel : IElevatorControlPanel
    {
        public ElevatorControlPanel(int NumOfFloors)
        {
            this.ClickedFloors = new bool[NumOfFloors];
        }
        public int NumberOfFloors { get; set; }
        public bool[] ClickedFloors { get; set; }

        public void AddClickedFloor(int NumOfFloor)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveClickedFloor(int NumOfFloor)
        {
            throw new System.NotImplementedException();
        }
    }
}
