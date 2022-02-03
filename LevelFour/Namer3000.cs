using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelFour
{
    internal class Namer3000
    {
        public static void Namer()
        {
            Console.WriteLine("What kind of thing are we talking about?");

            string a = Console.ReadLine(); //We need to get input about topic
            
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine(); /* we are describing its properties*/

            string c = "of Doom"; //Describing its doomsday
            string d = "3000"; // version number 
            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

            /*Rename a to type b to properties c to doom, and d to version*/
        }
    }
} 
