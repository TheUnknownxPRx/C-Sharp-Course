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
            Console.WriteLine(getDay(1));

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
