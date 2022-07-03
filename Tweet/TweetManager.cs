using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace COMP1234
{
    public static class TweetManager
    {
        //Field
        private static List<Tweet> TWEETS;
        private static string FILENAME = @"D:\Assignment1\Tweet-20220619T094720Z-001\Tweet\Assignment_02_TweetFile.txt";
        //Constructor
        static TweetManager()
        {
            TWEETS = new List<Tweet>();
            if (File.Exists(FILENAME))
            {
                TextReader reader = new StreamReader(FILENAME);
                string line = reader.ReadLine();
                while (line != null)
                {
                    TWEETS.Add(Tweet.Parse(line));
                    line = reader.ReadLine();
                }
                reader.Close();
            }

        }
        //Method
        public static void Initialize()
        {

            TWEETS.Add(new Tweet("Ronaldo ", "Messi", "first custom teesting tweet", "tweet"));
            TWEETS.Add(new Tweet("james", "helen", "is everything working fine!", "tweet"));
            TWEETS.Add(new Tweet("Trudeau", "Obama", "No war,peace!", "tweet"));
            TWEETS.Add(new Tweet("Trudeau", "Bieber", "Go! we are with you ", "newsongOut"));
            TWEETS.Add(new Tweet("Drake", "Obama", "Go Raptors! Go!", "WeTheNorth"));
            //from to body tag
            //Raptors	Tory	Drake	Yes Toronto will get them!  10014
            //WeTheNorth	Trudeau	Obama	Toronto is the greatest city!   10024
            //Ford	Trudeau	Bieber	Go Raptors! Go! 10008
            //WeTheNorth Drake   Obama Go Raptors! Go! 10009
        }

        public static void ShowAll()
        {
            Console.WriteLine("All Tweets in collection: ");
            Console.WriteLine("---------------------");
            foreach (var tweet in TWEETS)
            {
                Console.WriteLine(tweet);
            }
        }
        public static void ShowAll(string tag)
        {
            Console.WriteLine("All Tweet matched with {0} tag", tag);
            Console.WriteLine("---------------------");
            foreach (var tweet in TWEETS)
            {
                if (tweet.Tag.ToLower() == tag.ToLower())
                {
                    Console.WriteLine(tweet);
                }
            }
        }

    }
}
