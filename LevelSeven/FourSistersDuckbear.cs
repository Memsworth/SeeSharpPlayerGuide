using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelSeven
{
    internal class FourSistersDuckbear
    {
        public static void GetEggs()
        {
            const int numberOfSisters = 4;
            int eggInput = 0;

            while (true)
            {
                Console.Write("Enter number of eggs: ");
                bool inputChecker = int.TryParse(Console.ReadLine(), out eggInput);
                if (inputChecker && eggInput >= 0 && eggInput <= int.MaxValue) { break; }
                else { Console.WriteLine("There can't be negative eggs dummy."); }
            }
            int eggPerSister = eggInput / numberOfSisters;
            eggPerSister = Convert.ToInt32(Math.Floor((double)eggPerSister));
            int eggDuckbear = eggInput % numberOfSisters;
            Console.WriteLine($"number of eggs per sister: {eggPerSister}");
            Console.WriteLine($"number of eggs for duckbear: {eggDuckbear}");
        }
    }
}
