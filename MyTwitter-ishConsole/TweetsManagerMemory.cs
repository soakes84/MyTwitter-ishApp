using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter_ishConsole
{
    class TweetsManagerMemory
    {
        string[] tweets = new string[10];

        int tweetCount = 0;

        public string PostTweet(string tweet)
        {
            if (tweet.Length > 280)
                return "Tweets have to be 280 characters or less.";

            if (tweetCount > tweets.Length)
                return "You are only allowed 10 tweets. Sorry.";

            tweets[tweetCount++] = tweet;

            return "Your tweet has been posted.";
        }

        public string[] GetTweets()
        {
            return tweets;
        }

        public int TweetCount()
        {
            return tweetCount;
        }
    }
}
