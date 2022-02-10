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
            int[] luckyNumber = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[10];
            friends[0] = "Jim";
            friends[1] = "Pam"; 

            luckyNumber[1] = 16;

            Console.WriteLine(luckyNumber[1]);
            Console.WriteLine(friends[0]);

            Console.ReadLine();
        }
    }
}
