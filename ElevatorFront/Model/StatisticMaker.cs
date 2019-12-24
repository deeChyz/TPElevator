using Model.Interfaces;

namespace Model
{
    public class StatisticMaker : IStatisticMaker
    {
        public int NumberOfFreeRides { get; set; }

        public int NumberOfCreatedPassengers { get; set; }

        public int NumberOfRides { get; set; }

        public int TotalMovedMass { get; set; }

        public StatisticMaker()
        {
            NumberOfFreeRides = 0;
            NumberOfCreatedPassengers = 0;
            NumberOfRides = 0;
            TotalMovedMass = 0;
        }

        public void IncrementNumberOfFreeRides()
        {
            NumberOfFreeRides++; 
        }

        public void IncrementNumberRides()
        {
            NumberOfRides++;
        }

        public void AddTotalMovedMass(int mass)
        {
            TotalMovedMass += mass;
        }
    }
}
