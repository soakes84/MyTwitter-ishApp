using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter_ishConsole
{
    public abstract class TweetsManager
    {
        int maxTweets = 10;

        public string PostTweets(string tweet)
        {
            if (tweet.Length > 280)
                return "Tweets have to be 280 characters or less.";

            if (TweetCount() > maxTweets)
                return "You are only allowed 10 tweets. Sorry.";

            return WriteTweet(tweet);

        }

        public abstract string[] GetTweets();
        public abstract int TweetCount();
        public abstract string WriteTweet(string tweet);
    }
}
