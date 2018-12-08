using System;

namespace Kalkulator.MainMenu
{
    public class MainMenu
    {
        public void Run()
        {
            ShowWelcomeInfo();
            GetUserString();

            Console.ReadLine();
        }

        public void ShowWelcomeInfo()
        {
            Console.WriteLine("I will be the best console calculator. Try me!");
            Console.WriteLine("Just type 4+6 or 4.56+6.3245+5+6.5 etc. and hit <enter>");
        }

        private void GetUserString()
        {
            string insertEquation = Console.ReadLine(); 
            GetAlgebraicExpressionFromString(insertEquation);            
        }

        private void GetAlgebraicExpressionFromString(string insertEquation)
        {
            //Here will start the algorithm for getting the numbers and signs from string
        }
    }
}
