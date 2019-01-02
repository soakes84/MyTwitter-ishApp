using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter_ishConsole
{
    class TweetsManagerMemory : TweetsManager
    {
        string[] tweets = new string[10];

        int tweetCount = 0;

        public override string WriteTweet(string tweet)
        {
            tweets[tweetCount++] = tweet;

            return "Your tweet has been posted.";
        }

        public override string[] GetTweets()
        {
            return tweets;
        }

        public override int TweetCount()
        {
            return tweetCount;
        }
    }
}
