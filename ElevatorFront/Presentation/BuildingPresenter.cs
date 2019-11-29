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

        public BuildingPresenter(IKernel container, IBuildingView view)
        {
            _container = container;
            _view = view;
            _view.AddNewPassenger += (currentFloor) => AddNewPassenger(currentFloor);
        }

        public void AddNewPassenger(int currentFloor)
        {
            _container.Get<AddNewPassengerPresenter>().Run(currentFloor);
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
