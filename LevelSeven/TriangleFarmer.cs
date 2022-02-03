using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelSeven
{
    internal class TriangleFarmer
    {
        public static void GetArea()
        {
            double height = 0.0;
            double triangleBase = 0.0;
            bool inputChecker = false;
             while(true)
            {
                Console.Write("Enter height of the triangle: ");
                inputChecker = double.TryParse(Console.ReadLine(), out height);
                if(inputChecker && height > 0)
                {
                    Console.Write("Enter base of the triangle: ");
                    inputChecker = double.TryParse(Console.ReadLine(), out triangleBase);
                    if(inputChecker && triangleBase > 0) { break; }
                }
            }

            double triangleArea = (triangleBase * height) / 2;

            Console.WriteLine($"The triangle base is: {triangleBase:N}");
            Console.WriteLine($"The triangle height is: {height:N}");
            Console.WriteLine($"The area of the triangle is: {triangleArea:N}");
        }
    }
}
