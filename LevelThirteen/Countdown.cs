using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelThirteen
{
    internal class Countdown
    {
        public static void Initiate()
        {
            int numberInput = TakeNumber.AskForPositiveNumber("Enter countdown");
            StartCoutdown(numberInput);
        }

        public static void StartCoutdown(int countDown)
        {
            if (countDown == 0)
            {
                Console.WriteLine("BOOM");
                return;
            }

           Console.WriteLine($"{countDown}");
           StartCoutdown(countDown-1);
        }
    }
}
