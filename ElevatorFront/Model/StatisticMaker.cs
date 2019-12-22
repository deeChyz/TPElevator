using Model.Interfaces;

namespace Model
{
    public class StatisticMaker : IStatisticMaker
    {
        public int NumberOfFreeRides { get; set; }

        public int NumberOfCreatedPassengers { get; set; }

        public void IncrementNumberOfFreeRides()
        {
            NumberOfFreeRides++; 
        }
    }
}
