namespace Model.Interfaces
{
    public interface IStatisticMaker
    {
        void IncrementNumberOfFreeRides();
        void IncrementNumberRides();
        void AddTotalMovedMass(int mass);
        int TotalMovedMass { get; }
        int NumberOfRides { get; }
        int NumberOfFreeRides { get; }
        int NumberOfCreatedPassengers { get; set; }
    }
}
