using Castle.Windsor;

namespace Kalkulator.DI
{
    public class Installer
    {
        public void Run()
        {
            var container = new WindsorContainer();
            container.Install(
            );
        }
    }
}
