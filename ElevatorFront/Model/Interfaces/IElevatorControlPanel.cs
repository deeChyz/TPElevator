using System;

namespace Model.Interfaces
{
    interface IElevatorControlPanel
    {
        int NumberOfFloors { get; set; }
        bool[] ClickedFloors { get; set; }
        void AddClickedFloor(int NumOfFloor);
        void RemoveClickedFloor(int NumOfFloor);
    }
}
