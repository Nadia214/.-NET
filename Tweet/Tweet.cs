using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1234
{
    public class Tweet
    {
        //Field
        private static int CURRENT_ID = 1;

        //Properties
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        //Constructors
        //1
        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = CURRENT_ID.ToString();
            CURRENT_ID++;
        }
        //2
        public Tweet(string from, string to, string body, string tag, string id)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = id;
        }
        //Methods
        //1
        public override string ToString()
        {
            String tweetBody = Body;
            if (tweetBody.Length > 40)
            {
               tweetBody = tweetBody.Substring(0, 40);
            }

            string strOutput = "";
            strOutput += "Id: " + Id + "\n";
            strOutput += "From: " + From + "\n";
            strOutput += "To: " + To + "\n";
            strOutput += "Body: " + tweetBody + "\n";
            strOutput += "Tag: " + Tag + "\n";

            return strOutput;
        }
        //2
    
        public static Tweet Parse(string line)
        {
            Tweet tweet = null;
            String[] strlist = line.Split(new char[] { '\t' });
            if (strlist.Length == 4 || strlist.Length == 5)
            {
                string from = strlist[1];
                string to = strlist[2];

                string tag = strlist[0];
                string body = "";
                string id = "";
                if (strlist.Length == 4)
                {
                    body = strlist[3];
                    int index = body.LastIndexOf(' ');
                    id = body.Substring(index + 1);
                    body = body.Substring(0, index);

                }
                if (strlist.Length == 5)
                {
                    body = strlist[3];
                    id = strlist[4];
                }

                // string from, string to, string body, string tag, string id
                tweet = new Tweet(from, to, body, tag, id);
            }
        
             return tweet;
        }
    }
 }

