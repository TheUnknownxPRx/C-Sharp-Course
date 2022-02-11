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

            for(int x = 1; x <= 5; x++)
            {
                Console.WriteLine(x);
            }

            int[] luckyNumbers = { 4, 8, 16, 32, 64 };

            for (int i = 1; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
        }

    }
}
