using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelSix
{
    internal class VariableShop
    {
        public static void DisplayItems()
        {
            int a = 355;
            uint b = 3666666;

            short c = -3600;
            ushort d = 31000;

            long e = 300000000000;
            ulong f = 34755698726;

            byte g = 254;
            sbyte h = 122;

            char i = 'A';
            string j = "Ahmet";

            bool k = true;

            float l = 45.2f;
            double m = 3.14;
            decimal n = 6.20m;


            Console.WriteLine($"Value of A: {a}");
            Console.WriteLine($"Value of B: {b}");
            Console.WriteLine($"Value of C: {c}");
            Console.WriteLine($"Value of D: {d}");
            Console.WriteLine($"Value of e: {e}");
            Console.WriteLine($"Value of f: {f}");
            Console.WriteLine($"Value of g: {g}");
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);
        }
    }
}
