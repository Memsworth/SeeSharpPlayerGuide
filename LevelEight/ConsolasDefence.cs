using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelEight
{
    internal class ConsolasDefence
    {
        public static void EnforceDefence()
        {
            Console.Title = "Defense of Consolas";
            int targetRow = 0;
            int targetCol = 0;
            bool inputChecker = false;
            while(true)
            {
                Console.Write("Target Row: ");
                inputChecker = int.TryParse(Console.ReadLine(), out targetRow);
                if(inputChecker && (targetRow>0 && targetRow<8))
                {
                    Console.Write("Target column: ");
                    inputChecker = int.TryParse(Console.ReadLine(), out targetCol);
                    if(inputChecker && (targetCol>0 && targetRow < 8)) { break; }
                }
            }

            Console.WriteLine("Deploy to: ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine($"({targetRow}, {targetCol-1})");
            Console.WriteLine($"({targetRow-1}, {targetCol})");
            Console.WriteLine($"({targetRow}, {targetCol+1})");
            Console.WriteLine($"({targetRow+1}, {targetCol})");

            Console.Beep(440,1000);
        }
    }
}
