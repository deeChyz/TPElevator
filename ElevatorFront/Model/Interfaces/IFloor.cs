using System;

namespace Model.Interfaces
{
    interface IFloor
    {
        bool IsButtonPressed { get; set; }
        int PassengersNumber { get; set; }
        void IncrementPassengersNumber();
        void DecrementPassengersNumber();
    }
}
