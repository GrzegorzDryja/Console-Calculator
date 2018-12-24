using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Kalkulator.Installers;

namespace Kalkulator.DI
{
    public class Installer
    {
        public MainMenu.IMainMenu Run()
        {
            var container = new WindsorContainer();
            container.Install(
                new KalkulatorInstaller()
            );

            //only for ConsoleApplication purpose. Should return nothing
            container.Register(Component.For<MainMenu.IMainMenu>().ImplementedBy<MainMenu.MainMenu>());
            var mainMenu = container.Resolve<MainMenu.IMainMenu>();
            return mainMenu;
        }
    }
}
