using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelSix
{
    internal class VariableShopReturns
    {
        public static void ModifyVariables()
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

            a = 1;
            b = 2;

            c = -3;
            d = 3;

            e = 9821;
            f = 21225;

            g = 127;
            h = -128;

            i = 'b';
            j = "Abu";

            k = false;

            l = 45.67f;
            m = 6.6;
            n = 12.65m;
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
