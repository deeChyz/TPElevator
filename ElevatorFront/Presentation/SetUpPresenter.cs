using Model.Interfaces;
using Ninject;
using Presentation.Interfaces.Presenter;
using Presentation.Interfaces.Views;
using System;

namespace Presentation
{
    public class SetUpPresenter : IPresenter
    {
        private readonly IKernel _container;
        private readonly ISetUpView _view;
        private readonly IElevatorService _elevatorService;
        public SetUpPresenter(IKernel container, ISetUpView view, IElevatorService elevatorService)
        {
            _container = container;
            _view = view;
            _elevatorService = elevatorService;

            _view.SetUp += () => SetUp(_view.NumberOfFloors);
        }

        private void SetUp(string numberOfFloors)
        {
            if (!int.TryParse(numberOfFloors, out var n) || n < 2 || n > 20)
            {
                _view.ShowError("Введите число от 2 до 20");
                return;
            }

            try
            {
                _elevatorService.NumberOfFloors = n;
                _elevatorService.InitializeFloors(n);
            }
            catch (Exception e)
            {
                _view.ShowError(e.Message);
                return;
            }

            _container.Get<BuildingPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
