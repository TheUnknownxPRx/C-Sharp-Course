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
            string name = "Mike";
            SayHi(name, 34);
            SayHi("Tom", 12);
            SayHi("Sam", 44);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age);
        }

    }
}
