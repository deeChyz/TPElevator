using Model.Interfaces;
using Ninject;
using Presentation.Interfaces.Views;
using System;
using System.Text.RegularExpressions;

namespace Presentation
{
    public class AddNewPassengerPresenter : IAddNewPassengerView
    {
        private int _currentFloor;
        private readonly IAddNewPassengerView _view;
        private readonly IKernel _container;
        private readonly IElevatorService _elevatorService;
        private readonly IBuildingView _buildingView;

        //public BuildingPresenter BuildingPresenter { get; set; }

        public event Action<string, string> AddNewPassenger;

        public AddNewPassengerPresenter(IKernel container, IAddNewPassengerView view, IElevatorService elevatorService)
        {
            _view = view;
            _container = container;
            _elevatorService = elevatorService;
            
            _view.AddNewPassenger += CreateNewPassenger;
        }

        private void CreateNewPassenger(string name, string destination)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                _view.ShowError("Введите имя");
                return;
            }
            
            if (!Regex.Match(name, @"[А-Яа-яЁё]\s?[А-Яа-яЁё]*").Success)
            {
                _view.ShowError("Имя должно содержать только русские буквы в виде \"Имя - Фамилия\"");
                return;
            }

            if (!int.TryParse(destination, out var dest) || dest < 1 || dest > _elevatorService.NumberOfFloors)
            {
                _view.ShowError($"Введите число между 1 и {_elevatorService.NumberOfFloors}");
                return;
            }

            if (dest == _currentFloor)
            {
                _view.ShowError("Пассажир уже находится на этом этаже");
                return;
            }

            if (_elevatorService.AddNewPassenger(name, dest, _currentFloor))
            {
                _container.Get<BuildingPresenter>().DrawPassenger(_currentFloor, name);
                _view.Close();
                return;
            }

            //TODO: implement error handling
        }

        public void Run(int currentFloor)
        {
            _currentFloor = currentFloor;
            _view.Show();
        }

        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
