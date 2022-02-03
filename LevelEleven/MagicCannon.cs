using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelEleven
{
    internal class MagicCannon
    {
        public static void RapidFire()
        {
            const int fire = 3;
            const int electric = 5;

            for (int i = 1; i < 101; i++)
            {
                if (i % fire == 0 && i % electric == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}: Electric and Fire"); 
                }

                else if(i%fire ==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}: Fire");
                }

                else if(i%electric == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}: Electric");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"{i}: Normal");
                }
            }
        }
    }
}
