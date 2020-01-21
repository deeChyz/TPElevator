using Model.Interfaces;

namespace Model
{
    public class Passenger : IPassenger
    {
        
        public Passenger(int initialFloor, int deliveryFloor, States state, double weight, string name)
        {
            InitialFloor = initialFloor;
            DeliveryFloor = deliveryFloor;
            State = state;
            Weight = weight;
            Name = name;
        }

        public int InitialFloor { get; set; }
        public int DeliveryFloor { get; set; }
        public double Weight { get; set; }
        public States State { get; set; }
        public string Name { get; set; }
    }
}
