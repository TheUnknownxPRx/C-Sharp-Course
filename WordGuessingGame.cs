using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "giraffe";
            string guess = "";

            int guessCount = 0;
            int guessLimit = 3;
            bool OutofGuesses = false;

            while(guess != secretWord && !OutofGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("giraffe hippo tiger lion rat monkey");
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    OutofGuesses = true;
                }
                
            }

            if(OutofGuesses)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            Console.ReadLine();
        }

        static string getDay(int dayNum)
        {
            string dayname;

            switch (dayNum)
            {
                case 0:
                    dayname = "Sunday";
                    break;

                case 1:
                    dayname = "Monday";
                    break;

                case 2:
                    dayname = "Tuesday";
                    break;

                case 3:
                    dayname = "Wednesday";
                    break;

                case 4:
                    dayname = "Thursday";
                    break;

                case 5:
                    dayname = "Friday";
                    break;

                case 6:
                    dayname = "Saturday";
                    break;

                default:
                    dayname = "Invalid Day Number";
                    break;

            }

            return dayname;
        }

    }
}
