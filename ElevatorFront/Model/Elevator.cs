using Model.Interfaces;

namespace Model
{
    public class Elevator : IElevator

    {
        public Elevator(int NumOfFloors)
        {
            this.MaxWeight = 400;
            ControlPanel = new ElevatorControlPanel(NumOfFloors);
        }

        public int CurrentFloor { get; set; }
        public int MaxWeight { get; set; }
        public double TotalWeight { get; set; }
        public bool IsPending { get; set; }
        public Directions CurrentDirection { get; set; }
        public ElevatorControlPanel ControlPanel { get; set; }
      
    }
}
