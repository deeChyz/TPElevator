using Model.Interfaces;

namespace Model
{
    public class Passenger : IPassenger
    {
        
        public Passenger(int initialFloor, int deliveryFloor, States state, double weight)
        {
            InitialFloor = initialFloor;
            DeliveryFloor = deliveryFloor;
            State = state;
            Weight = weight;
        }

        public int InitialFloor { get; set; }
        public int DeliveryFloor { get; set; }
        public double Weight { get; set; }
        public States State { get; set; }
    }
}
