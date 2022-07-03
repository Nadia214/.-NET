using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP1234;
namespace COMP1234
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //for testing purpose;
          TweetManager.Initialize();
          //TweetManager.ShowAll();


            //for production purpose
            //TweetManager.ShowAll();
            //TweetManager.ShowAll("Raptors");
            TweetManager.ShowAll("tweet");
        }
    }
}
