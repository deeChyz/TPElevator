using System;
using System.Windows.Forms;
using Model;
using Model.Interfaces;
using Ninject;
using Presentation;
using Presentation.Interfaces.Views;

namespace ElevatorFront
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ISetUpView>().To<SetUpView>();
            kernel.Bind<IBuildingView>().To<BuildingView>().InSingletonScope();
            kernel.Bind<IAddNewPassengerView>().To<AddNewPassengerView>();
            kernel.Bind<SetUpPresenter>().ToSelf();
            kernel.Bind<BuildingPresenter>().ToSelf();
            kernel.Bind<AddNewPassengerPresenter>().ToSelf();
            kernel.Bind<FloorCellPresenter>().ToSelf();
            kernel.Bind<IElevatorService>().To<ElevatorService>().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<SetUpPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BuildingView(kernel.Get<IElevatorService>()));  
        }
    }
}
