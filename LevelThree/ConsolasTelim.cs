using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelThree
{
    internal class ConsolasTelim
    {
        public static void Ask()
        {
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            string name = Console.ReadLine();
            Console.WriteLine($"Noted: {name} got the bread.");
        }
    }
}
