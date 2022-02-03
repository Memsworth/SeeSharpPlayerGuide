using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelNine
{
    internal static class ClocktowerRepair
    {
        public static void Repair()
        {
            int numberInput = 0;
            bool inputChecker = false;

            while(true)
            {
                Console.Write("Enter your clock input: ");
                inputChecker = int.TryParse(Console.ReadLine(), out numberInput);
                if (inputChecker && numberInput>=0) { break; }
            }

            if (numberInput % 2 == 0) { Console.WriteLine("Tick"); }
            else { Console.WriteLine("Tock"); }
        }
    }
}
