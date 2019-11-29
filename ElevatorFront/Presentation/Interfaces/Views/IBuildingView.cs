using System;

namespace Presentation.Interfaces.Views
{
    public interface IBuildingView : IView
    {
        event Action<int> AddNewPassenger;
    }
}
