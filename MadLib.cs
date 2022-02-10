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
            string color, pluralnoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralnoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralnoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}
