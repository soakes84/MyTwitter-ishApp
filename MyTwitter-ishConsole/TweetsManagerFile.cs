using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter_ishConsole
{
    class TweetsManagerFile
    {
        private string fileName = "tweets.txt";

        public string PostTweet(string tweet)
        {
            if (tweet.Length > 280)
                return "Tweets have to be 280 characters or less.";

            if (TweetCount() > GetTweets().Length)
                return "You are only allowed 10 tweets. Sorry.";

            System.IO.File.AppendAllLines(fileName, new string[] { tweet });

            return "Your tweet has been posted.";
        }

        public string[] GetTweets()
        {
            return new string[5];
        }

        public int TweetCount()
        {
            return 0;   
        }
    }
}
}
