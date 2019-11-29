using System;

namespace Presentation.Interfaces.Views
{
    public interface ISetUpView : IView
    {
        string NumberOfFloors { get; }
        event Action SetUp;
        void ShowError(string message);
    }
}
