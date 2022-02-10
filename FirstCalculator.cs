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

            //Basic Sum Calculator
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.Readline());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.Readline());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
