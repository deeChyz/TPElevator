namespace Model.Interfaces
{
    public enum Directions
    {
        Up,
        Down,
        None
    }

    interface IElevator
    {
        int CurrentFloor { get; set; }
        double TotalWeight { get; set; }
        int MaxWeight { get; set; }
        bool IsPending { get; set; }
        Directions CurrentDirection { get; set; }
        ElevatorControlPanel ControlPanel { get; set; }
    }  
}
