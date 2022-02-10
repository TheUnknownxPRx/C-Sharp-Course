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

            string phrase = "Demon " + "Slayers Corps";
            Console.WriteLine(phrase);

            Console.WriteLine(phrase.ToUpper() );
            Console.WriteLine(phrase.ToLower() );
            Console.WriteLine(phrase.Contains("Demon"));
            Console.WriteLine(phrase[2]);

            Console.WriteLine(phrase.IndexOf('S'));
            Console.WriteLine(phrase.Substring(6,7));

            // Prints lenght of string
            Console.WriteLine(phrase.Length);

            Console.ReadLine();
        }
    }
}
