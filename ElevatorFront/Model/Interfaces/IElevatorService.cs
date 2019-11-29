namespace Model.Interfaces
{
    public interface IElevatorService
    {
        int NumberOfFloors { get; set; }
        bool AddNewPassenger(string name, int destination, int startFloor);
    }
}
