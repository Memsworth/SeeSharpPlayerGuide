using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelTwelve
{
    internal class FreachLaws
    {
        public static void Replace()
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int minValue = int.MaxValue;
            int sumValue = 0;
            foreach (int item in array)
            {
                if (minValue > item) { minValue = item; }
                sumValue += item;
            }

            Console.WriteLine($"Minimum value: {minValue}");
            Console.WriteLine($"Average value: {sumValue}/{array.Length} = {(sumValue/array.Length):N}");
        }
    }
}
