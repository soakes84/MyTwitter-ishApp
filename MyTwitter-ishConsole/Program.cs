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
            string choice;
            string[] tweets = new string[10];

            int tweetCount = 0;

            do
            {
                Console.WriteLine("------Main Menu------");
                Console.WriteLine();
                Console.WriteLine("1: View All Tweets");
                Console.WriteLine("2: Post New Tweet");
                Console.WriteLine("3: Exit");

                choice = Console.ReadLine();
                Console.WriteLine();

                if(choice == "1")
                {
                    for (int i = 0; i < tweetCount; i++)
                        Console.WriteLine("Tweet #{0}: {1}", i + 1, tweets[i]);
                    Console.WriteLine();
                }
                if(choice == "2")
                {
                    Console.Write("Enter your tweet: ");
                    string tweet = Console.ReadLine();
                    Console.WriteLine();

                    if(tweet.Length > 280)
                    {
                        Console.WriteLine("Your tweet is over 280 characters and will not be saved.");
                        continue;
                    }

                    tweets[tweetCount++] = tweet;
                }

               
            }
            while (choice != "3");

            Console.ReadLine();

            //string[] tweets = new string[4];

            //for (int i = 0; i < tweets.Length; i++)
            //{
            //    Console.Write("Enter Tweet #{0}: ", i + 1);
            //    tweets[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Your Tweets Posted Successfully.");
            //Console.WriteLine();

            //Console.WriteLine("Your tweets are: ");

            //for (int i = 0; i < tweets.Length; i++)
            //{
            //    Console.WriteLine("Your tweet #{0} is '{1}' ", i + 1, tweets[i]);
            //}

            //Console.ReadLine();

        }
    }
}
