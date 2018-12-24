using Kalkulator.DI;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new Installer().Run();

            mainMenu.Run();
        }
    }
}
