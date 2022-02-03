using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelThirteen
{
    internal class TakeNumber
    {
        public static void AskMe()
        {
            int result = 0;
            while(true)
            {
                int minValue = AskForNumber("Enter a min value");
                int maxValue = AskForNumber("Enter a max value");

                if (minValue > maxValue) 
                { 
                    Console.WriteLine("minValue is larger than max. Please enter correct inputs");
                    continue;
                }

                result = AskForNumberInRange("Enter number in range", minValue, maxValue);
                break;
            }

            Console.WriteLine($"Result: {result}");
        }

        internal static int AskForPositiveNumber(string message)
        {
            int numberInput = 0;
            bool inputChecker = false;
            while (true)
            {
                Console.Write($"{message}: ");
                inputChecker = int.TryParse(Console.ReadLine(), out numberInput);
                if (inputChecker && numberInput>0) { break; }
            }

            return numberInput;

        }
        internal static int AskForNumber(string message)
        {
            int numberInput = 0;
            bool inputChecker = false;
            while(true)
            {
                Console.Write($"{message}: ");
                inputChecker = int.TryParse(Console.ReadLine(), out numberInput);
                if (inputChecker) { break; }
            }

            return numberInput;
        }

        internal static int AskForNumberInRange(string message, int min, int max)
        {
            bool inputChecker = false;
            int numberInput = 0;

            while(true)
            {
                Console.Write($"{message} {min} & {max}: ");
                inputChecker = int.TryParse(Console.ReadLine(), out numberInput);

                if((numberInput>min && numberInput<max) && inputChecker) { break; }
            }

            return numberInput;
        }
    }
}
