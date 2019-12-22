namespace Model.Interfaces
{
    public interface IStatisticMaker
    {
        void IncrementNumberOfFreeRides();
        int NumberOfFreeRides { get; }
        int NumberOfCreatedPassengers { get; set; }
    }
}
