using System;

namespace Presentation.Interfaces.Views
{
    public interface IBuildingView : IView
    {
        int CurrentNumberOfPassengers { get; set; }
        event Action<int> AddNewPassenger;
        event Action StartSimulation;
        event Action StopSimulation;
        event Action ShowPassengersInfo;
        void PressFloorButtonCheckbox(int FloorNumber);
        void PressElevatorButtonCheckbox(int FloorNumber);
        void MoveElevator(int Destination);
        void IncreaseNumberOfRides();
        void IncreaseNumberOfFreeRides();
        void ShowOverweightWarning();
        void HideOverweightWarning();
        void TransferPassengerToElevator(int FloorNumber);
        void TransferPassengerFromElevator(int FloorNumber);
        void DispellPassenger(int FloorNumber);
        void UpdateTimeStatistics(double Time);
        void UpdateTotalWeightStatistics(int WeightToAdd);
        void DrawPassenger(int currentFloor, string name);
        void UpdateTime(double Time);
        void DisableWeightAlert();
        void EnableWeightAlert();
        void DeletePessanger(int FloorNumber);
        int IncreaseCurrentNumberOfPassengers();
        int DecreaseCurrentNumberOfPassenger();
    }
}