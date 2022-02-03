using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelTwelve
{
    internal class Replicator
    {
        public static void Replicate()
        {
            const int ArrLen = 5;
            bool inputChecker = false;
            int numberInput = 0;

            int[] arrayOne = new int[ArrLen];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                while(true)
                {
                    Console.Write($"Enter a number at position {i+1}: ");
                    inputChecker = int.TryParse(Console.ReadLine(), out numberInput);
                    if (inputChecker) { break; }
                }

                arrayOne[i] = numberInput;
            }

            int[] arrayCopy = new int[arrayOne.Length];

            for (int i = 0; i < arrayCopy.Length; i++) { arrayCopy[i] = arrayOne[i]; }

            for (int i = 0; i < ArrLen; i++) { Console.WriteLine($"copy[{i}] = {arrayCopy[i]} & original[{i}] = {arrayOne[i]}"); }
        }
    }
}
