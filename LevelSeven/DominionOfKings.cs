using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelSeven
{
    internal class DominionOfKings
    {
        public static void Dominate()
        {
            const int estatePoint = 1;
            const int duchyPoint = 3;
            const int provincePoint = 6;

            int estates = GetInput("estates");
            int duchy = GetInput("duchies");
            int province = GetInput("provinces");

            int totalPoints = (estates * estatePoint) + (duchy * duchyPoint) + (province * provincePoint);

            Console.WriteLine($"You have {estates} estates, {duchy} duchies, & {province} provinces");
            Console.WriteLine($"The points you own is {totalPoints}");
        }

        private static int GetInput(string message)
        {
            int numberInput = 0;
            bool inputChecker = false;

            while(true)
            {
                Console.Write($"Enter how many {message} you own: ");
                inputChecker = int.TryParse(Console.ReadLine(), out numberInput);
                if(inputChecker && numberInput >= 0) { break; }
            }

            return numberInput;
        }
    }
}
