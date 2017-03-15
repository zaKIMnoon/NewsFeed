using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Xml;
using System.ServiceModel.Syndication;
using System.IO;

namespace NewsFeeder
{

    public class Feeds
    {

        public string RSSFeed { get; set; }

        public InternetFeedsList ifList = new InternetFeedsList();

        public Feeds()
        {

        }

        public static List<Feeds> LoadFeedsFromFile(string filepath)
        {
            List<Feeds> feedList = new List<Feeds>();

            if (Path.GetExtension(filepath) == ".txt")
            {
                using (var reader = new StreamReader(filepath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Feeds feed = new Feeds();
                        feed.ifList = InternetFeedsList.LoadFromUrl(line);
                        feedList.Add(feed);
                    }
                }

            }
                  
            return feedList;
        }

    }


    public class InternetFeeds
    {
        public string subject { get; set; }
        public DateTimeOffset PublishedDate { get; set; }
        public DateTime FetchedDate
        {
            get
            {
                return DateTime.Now;
            }
        }
        public string Url { get; set; }

        public string Summary { get; set; }

        public InternetFeeds(string _Subject, DateTimeOffset _PublishedDate, string _Url, string _Summary)
        {
            subject = _Subject;
            PublishedDate = _PublishedDate;
            Url = _Url;
            Summary = _Summary;             
        }

  }

    public class InternetFeedsList :List<InternetFeeds>
    {
        public static InternetFeedsList LoadFromUrl(string url)
        {
            InternetFeedsList newIFList = new InternetFeedsList();

            try
            {
                XmlReader reader = XmlReader.Create(url);

                SyndicationFeed feed = SyndicationFeed.Load(reader);

                reader.Close();

                foreach (SyndicationItem item in feed.Items)
                {
                    newIFList.Add(new InternetFeeds(item.Title.Text, item.PublishDate, item.Links.FirstOrDefault().Uri.AbsoluteUri, item.Summary.Text));
                }
            }
            catch (Exception e)
            {
                newIFList.Add(new InternetFeeds("Error", DateTime.Now, url, "Error Downloading"));
            }
            
            return newIFList;
        }
    }

}
