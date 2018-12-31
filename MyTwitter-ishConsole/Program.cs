using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter_ishConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tweets = new string[4];

            Console.Write("Enter Your Tweet: ");
            tweets[0] = Console.ReadLine();

            Console.Write("Enter Second Tweet: ");
            tweets[1] = Console.ReadLine();

            Console.Write("Enter Third Tweet: ");
            tweets[2] = Console.ReadLine();

            Console.Write("Enter Fourth Tweet: ");
            tweets[3] = Console.ReadLine();

            Console.WriteLine("Your Tweets Posted Successfully.");
            Console.WriteLine();

            Console.WriteLine("Your Tweets Are: ");
            Console.WriteLine(tweets[0]);
            Console.WriteLine(tweets[1]);
            Console.WriteLine(tweets[2]);
            Console.WriteLine(tweets[3]);

            Console.ReadLine();

        }
    }
}
