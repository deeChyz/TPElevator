using System;

namespace Presentation.Interfaces.Views
{
    public interface IAddNewPassengerView : IView
    {
        event Action<string, string> AddNewPassenger;
        void ShowError(string message);
    }
}
