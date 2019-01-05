using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public class TweetsManagerFile : TweetsManager
    {
        private string fileName = "tweets.txt";

        public string CreateFileForTweets(string creating)
        {
            System.IO.File.AppendAllLines(fileName, new string[] { creating });
            return " ";
        }

        public override string WriteTweet(string tweet)
        {
            System.IO.File.AppendAllLines(fileName, new string[] { tweet });

            return "Your tweet has been posted.";
        }

        public override string[] GetTweets()
        {
            if (System.IO.File.ReadAllLines(fileName).Length > 0)
                return System.IO.File.ReadAllLines(fileName);

            else
                return new string[] { "There are no tweets" };
        }

        public override int TweetCount()
        {
                return System.IO.File.ReadAllLines(fileName).Length;
        }
    }
}
