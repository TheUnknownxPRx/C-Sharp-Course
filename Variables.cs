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

            string charactername = "John";
            int characterage;
            characterage = 35;

            Console.WriteLine("There once was a man named " + charactername);
            Console.WriteLine("He was " + characterage + " years old.");

            charactername = "Mike";
            Console.WriteLine("He really liked the name " + charactername);
            Console.WriteLine("But didn't like being " + characterage);

            Console.ReadLine();
        }
    }
}
