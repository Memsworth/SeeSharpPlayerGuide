using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpPlayerGuide.LevelFourteen
{
    internal class Manticore
    {
        private const int cityDefence = 15;
        private const int manticoreDefence = 10;
        private const int normalCanon = 1;
        private const int fireCanon = 3;
        private const int electricCanon = 5;
        private const int electricFireCanon = 10;
        public static void StartHunt()
        {
            int currentCityDefence = cityDefence;
            int currentManticoreDefence = manticoreDefence;
            int playerOneInput = AskPlayerOne();
            int turn = 1;
            bool gameStatus = false;
            Console.WriteLine("Player 2, it is your turn.");

            while (true)
            {
                DisplayStatus(turn, currentCityDefence, currentManticoreDefence);
                DamagePromt(turn);

                int playerTwoInput = LevelThirteen.TakeNumber.AskForNumberInRange("Enter desired cannon range: ",
                    0, 100);

                if (playerTwoInput > playerOneInput) { Console.WriteLine("That round OVERSHOT the target."); }
                else if (playerTwoInput < playerOneInput) { Console.WriteLine("That round FELL SHORT of the target."); }
                else
                { 
                    Console.WriteLine("That round was a DIRECT HIT!");

                    switch(DealDamage(turn))
                    {
                        case normalCanon:
                            currentManticoreDefence -= normalCanon;
                            break;

                        case fireCanon:
                            currentManticoreDefence -= fireCanon;
                            break;

                        case electricCanon:
                            currentManticoreDefence -= electricCanon;
                            break;
                        case electricFireCanon:
                            currentManticoreDefence -= electricFireCanon;
                            break;
                    }
                }

                gameStatus = IsGameOver(currentCityDefence, currentManticoreDefence);
                if (gameStatus) { break; }
                else
                {
                    currentCityDefence--;
                    turn++;
                }
            } 
        }

        private static void DisplayStatus(int turn, int currentCityDefence, int currentManticoreDefence)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"STATUS: Round: {turn} City: {currentCityDefence}/{cityDefence}" +
                    $" Manticore: {currentManticoreDefence}/{manticoreDefence}");
        }


        private static bool IsGameOver(int currentCityDefence, int currentManticoreDefence)
        {
            if(currentManticoreDefence<=0 && currentCityDefence>0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                return true;
            }
            else if (currentCityDefence<1 && currentManticoreDefence > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
                return true;
            }

            return false;
        }

        private static int AskPlayerOne()
        {
            int playerInput = LevelThirteen.TakeNumber.AskForNumberInRange("Player 1, how far away from the " +
                "city do you want to station the Manticore?", 0, 100);
            Console.Clear();
            return playerInput;
        }


        private static int DealDamage(int turn)
        {
            if (turn % fireCanon == 0 && turn % electricCanon == 0) { return electricFireCanon; }
            else if (turn % fireCanon == 0) { return fireCanon; }
            else if (turn % electricCanon == 0) { return electricCanon; }
            return normalCanon;
        }
        private static void DamagePromt(int turn)
        {
            Console.Write("The cannon is expected to deal ");

            if (turn % fireCanon == 0 && turn % electricCanon == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{electricFireCanon} damage ");
            }

            else if (turn % fireCanon==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{fireCanon} damage ");
            }
            else if(turn % electricCanon == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{electricCanon} damage ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"{normalCanon} damage ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("this round.");
        }
    }
}
