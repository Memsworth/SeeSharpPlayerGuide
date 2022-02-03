using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelNine
{
    internal class Watchtower
    {
        public static void Scout()
        {
            int axisX = 0;
            int axisY = 0;
            bool inputChecker = false;

            while(true)
            {
                Console.Write("Enter X-Axis: ");
                inputChecker = int.TryParse(Console.ReadLine(), out axisX);
                if(inputChecker)
                {
                    Console.Write("Enter Y-Axis: ");
                    inputChecker = int.TryParse(Console.ReadLine(), out axisY);
                    if (inputChecker) { break; }
                }
            }

            if (axisX < 0 && axisY > 0) Console.WriteLine("The enemy is to the north west!");
            if (axisX == 0 && axisY > 0) Console.WriteLine("The enemy is to the north!");
            if (axisX > 0 && axisY > 0) Console.WriteLine("The enemy is to the north east!");
            if (axisX < 0 && axisY == 0) Console.WriteLine("The enemy is to the west!");
            if (axisX == 0 && axisY == 0) Console.WriteLine("The enemy is here!");
            if (axisX > 0 && axisY == 0) Console.WriteLine("The enemy is to the east!");
            if (axisX < 0 && axisY < 0) Console.WriteLine("The enemy is to the south west!");
            if (axisX == 0 && axisY < 0) Console.WriteLine("The enemy is to the south!");
            if (axisX > 0 && axisY < 0) Console.WriteLine("The enemy is to the south east!");
        }
    }
}
