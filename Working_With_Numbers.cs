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

            Console.WriteLine(5 % 2);
            Console.WriteLine( 4 + 2 * 3);

            int num = 5;
            num++;
            Console.WriteLine(num); 
            num--;
            Console.WriteLine(num);
            Console.WriteLine(Math.Pow(3,2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4,90));
            Console.WriteLine(Math.Min(4,90));
            Console.WriteLine(Math.Round(4.6));


            Console.ReadLine();
        }
    }
}
