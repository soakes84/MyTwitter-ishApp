﻿using System;
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
            TweetsManagerFile tm = new TweetsManagerFile();

            string choice;  

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
                    for (int i = 0; i < tm.TweetCount(); i++)
                        Console.WriteLine("Tweet #{0}: {1}", i + 1, tm.GetTweets()[i]);
                    Console.WriteLine();
                }

                if(choice == "2")
                {
                    Console.Write("Enter your tweet: ");
                    string tweet = Console.ReadLine();

                    string msg = tm.PostTweet(tweet);
                    Console.WriteLine(msg);
                }
     
            }
            while (choice != "3");

            Console.ReadLine();

        }
    }
}
