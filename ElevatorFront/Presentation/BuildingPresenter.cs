using Model.Interfaces;
using Ninject;
using Presentation.Interfaces.Presenter;
using Presentation.Interfaces.Views;

namespace Presentation
{
    public class BuildingPresenter : IPresenter
    {
        private readonly IKernel _container;
        private readonly IBuildingView _view;
        private readonly IElevatorService _service;

        public BuildingPresenter(IKernel container, IBuildingView view, IElevatorService service)
        {
            _container = container;
            _service = service;
            _view = view;
            _view.AddNewPassenger += (currentFloor) => AddNewPassenger(currentFloor);
            _view.StartSimulation += StartSimulation;
            _view.StopSimulation += StopSimulation;
            _service.TimeWasUpdated += UpdateTime;
            _service.DisableWeightAlert += DisableWeightAlert;
            _service.ElevatorMove += MoveElevator;
            _service.PassengerDeleted += DeletePassenger;
            _service.FloorButtonPressed += PressFloorButton;
            _service.PassengerGotIn += PassengerGotIn;
            _service.PassengerGotOut += PassengeGotOut;
        }

        public void AddNewPassenger(int currentFloor)
        {
            _container.Get<AddNewPassengerPresenter>().Run(currentFloor);
        }

        public void DrawPassenger(int currentFloor, string name)
        {
            _view.DrawPassenger(currentFloor, name);
        }

        public void StartSimulation()
        {
            _service.StartTime();
        }

        public void StopSimulation()
        {
            _service.StopTime();
        }

        public void UpdateTime(double Time)
        {
            _view.UpdateTime(Time);
        } 

        public void Run()
        {
            _view.Show();
        }

        public void DisableWeightAlert()
        {
            _view.DisableWeightAlert();
        }

        public void MoveElevator(int Destination)
        {
            _view.MoveElevator(Destination);
        }

        public void DeletePassenger(int FloorNumber)
        {
            _view.DeletePessanger(FloorNumber);
        }

        public void PressFloorButton(int FloorNumber)
        {
            _view.PressFloorButtonCheckbox(FloorNumber);
        }

        public void PassengerGotIn(int FloorNumber, string Name)
        {
            _view.TransferPassengerToElevator(FloorNumber, Name);
        }

        public void PassengeGotOut(int FloorNumber)
        {
            _view.TransferPassengerFromElevator(FloorNumber);
        }
    }
}
