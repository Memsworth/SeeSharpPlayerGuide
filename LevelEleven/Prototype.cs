using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelEleven
{
    internal class Prototype
    {
        public static void Test()
        {
            int userOneInput = 0;
            bool inputChecker = false;
            do
            {
                Console.Write("User 1, enter a number between 0 & 100: ");
                inputChecker = int.TryParse(Console.ReadLine(), out userOneInput);

            } while (!inputChecker && (userOneInput < 0 && userOneInput > 101));

            Console.Clear();

            while(true)
            {
                Console.WriteLine("User 2, guess the number.");
                Console.Write("What is your next guess? ");
                int userTwoInput = 0;
                inputChecker = int.TryParse(Console.ReadLine(), out userTwoInput);
                if (inputChecker && (userTwoInput > userOneInput)) { Console.WriteLine($"{userTwoInput} Too high."); }
                else if (inputChecker && (userTwoInput < userOneInput)) { Console.WriteLine($"{userTwoInput} Too low"); }
                else { Console.WriteLine("You guessed the number"); break; }
            }
        }
    }
}
