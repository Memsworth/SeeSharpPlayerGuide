using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelTen
{
    internal class BuyingInventory
    {
        public static void Browse()
        {
            const decimal ropePrice = 10.0m;
            const decimal torchesPrice = 15.0m;
            const decimal climbingEquipmentPrice = 25.0m;
            const decimal cleanWaterPrice = 1.0m;
            const decimal machetePrice = 20.0m;
            const decimal canoePrice = 200.0m;
            const decimal foodSupplies = 1.0m;
            const string sentPerson = "Cloud";
            const double discount = 0.50;

            ShowMenu();
            Console.Write("What number do you want to see the price of?  ");

            int inventoryChoice = 0;
            inventoryChoice = int.Parse(Console.ReadLine());
            Console.Write("How sent you here? ");
            string nameInput = Console.ReadLine();
            switch (inventoryChoice)
            {
                case 1:
                    if(nameInput == sentPerson) { PrintPrice(ropePrice, discount); }
                    else { PrintPrice(ropePrice); }
                    break;
                case 2:
                    if (nameInput == sentPerson) { PrintPrice(torchesPrice, discount); }
                    else { PrintPrice(torchesPrice); }

                    break;
                case 3:
                    if (nameInput == sentPerson) { PrintPrice(climbingEquipmentPrice, discount); }
                    else { PrintPrice(climbingEquipmentPrice); }

                    break;
                case 4:
                    if (nameInput == sentPerson) { PrintPrice(cleanWaterPrice, discount); }
                    else { PrintPrice(cleanWaterPrice); }

                    break;
                case 5:
                    if (nameInput == sentPerson) { PrintPrice(machetePrice, discount); }
                    else { PrintPrice(machetePrice); }

                    break;
                case 6:
                    if (nameInput == sentPerson) { PrintPrice(canoePrice, discount); }
                    else { PrintPrice(canoePrice); }

                    break;
                case 7:
                    if (nameInput == sentPerson) { PrintPrice(foodSupplies, discount); }
                    else { PrintPrice(foodSupplies); }
                    break;
                default:
                    Console.WriteLine("Invalid input customer");
                    break;
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("The following items are available:\n" +
                "1 – Rope\n" +
                "2 – Torches\n" +
                "3 – Climbing Equipment\n" +
                "4 – Clean Water\n" +
                "5 – Machete\n" +
                "6 – Canoe\n" +
                "7 – Food Supplies\n");
        }

        private static void PrintPrice(decimal price, double discount)
        {
            Console.WriteLine($"{(decimal)discount*price:N} gold");
        }

        private static void PrintPrice(decimal price)
        {
            Console.WriteLine($"{price} gold");
        }
    }
}
