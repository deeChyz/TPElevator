using Model.Interfaces;

namespace Model
{
    public class ElevatorService : IElevatorService
    {
        public int NumberOfFloors { get; set; }
        public bool AddNewPassenger(string name, int destination, int startFloor)
        {
            //TODO: implement passenger adding
            return true;
        }
    }
}
