namespace Model.Interfaces
{
    interface IPassenger
    {
        int InitialFloor { get; set; }
        int DeliveryFloor { get; set; }
        States State { get; set; }
        double Weight { get; set; }
    }

    public enum States{
        Waiting,
        Riding,
        Delivered
    }
}
