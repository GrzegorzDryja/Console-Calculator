using Kalkulator.DI;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            new Installer().Run();

            var mainMenu = new Kalkulator.MainMenu.MainMenu();
            mainMenu.Run();
        }
    }
}
