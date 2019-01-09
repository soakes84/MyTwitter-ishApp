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
            if (System.IO.File.Exists(fileName))
                return System.IO.File.ReadAllLines(fileName);

            else
                return new string[0];
        }

        public override int TweetCount()
        {
            if (System.IO.File.Exists(fileName))
                return System.IO.File.ReadAllLines(fileName).Length;
            else
                return 0;
        }
    }
}
