using Model.Interfaces;
using System;
using System.Collections.Generic;

namespace Model
{
    public class Floor : IFloor
    {
        private List<Passenger> passengers = new List<Passenger>();
        public List<Passenger> Passengers
        {
            get { return passengers; }

        }
        public bool IsButtonPressed { get; set; }
        public int PassengersNumber { get; set; }

        public void DecrementPassengersNumber()
        {
            PassengersNumber--;
        }

        public void IncrementPassengersNumber()
        {
            PassengersNumber++;
        }
    }
}
