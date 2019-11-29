using Model.Interfaces;
using Presentation.Interfaces.Views;
using System.Text.RegularExpressions;

namespace Presentation
{
    public class AddNewPassengerPresenter
    {
        private int _currentFloor;
        private readonly IAddNewPassengerView _view;
        private readonly IElevatorService _elevatorService;

        public AddNewPassengerPresenter(IAddNewPassengerView view, IElevatorService elevatorService)
        {
            _view = view;
            _elevatorService = elevatorService;
            _view.AddNewPassenger += (name, destination) => CreateNewPassenger(name, destination);
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
    }
}
