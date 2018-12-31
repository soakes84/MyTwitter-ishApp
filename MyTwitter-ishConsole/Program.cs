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

            for (int i = 0; i < tweets.Length; i++)
            {
                Console.Write("Enter Tweet #{0}: ", i + 1);
                tweets[i] = Console.ReadLine();
            }

            Console.WriteLine("Your Tweets Posted Successfully.");
            Console.WriteLine();

            Console.WriteLine("Your tweets are: ");

            for (int i = 0; i < tweets.Length; i++)
            {
                Console.WriteLine("Your tweet #{0} is '{1}' ", i + 1, tweets[i]);
            }

            Console.ReadLine();

        }
    }
}
