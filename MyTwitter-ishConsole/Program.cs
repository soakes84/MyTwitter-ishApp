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


            TweetsManagerFile tmf = new TweetsManagerFile();        // use this to save tweets to your disk

            TweetsManagerMemory tmm = new TweetsManagerMemory();    // use this for in memory/get erased every use

            string choice;

            do
            {
                Console.WriteLine("------Main Menu------");
                Console.WriteLine();
                Console.WriteLine("1: Post New Tweet");
                Console.WriteLine("2: View All Tweets");
                Console.WriteLine("3: Search Tweets");
                Console.WriteLine("4: Exit");

                choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.Write("Enter your tweet: ");
                    string tweet = Console.ReadLine();

                    string msg = tmf.WriteTweet(tweet);
                    Console.WriteLine(msg);
                }

                if (choice == "2")
                {
                    for (int i = 0; i < tmf.TweetCount(); i++)
                        Console.WriteLine("Tweet #{0}: {1}", i + 1, tmf.GetTweets()[i]);

                    Console.WriteLine();
                }

                if (choice == "3")
                {
                    Console.Write("Enter word to search for: ");
                    string search = Console.ReadLine();
                    List<string> results = tmf.Search(search);
                    Console.WriteLine("Found " + results.Count + " tweets.");
                }

            }
            while (choice != "4");

            Console.ReadLine();

        }
    }
}
