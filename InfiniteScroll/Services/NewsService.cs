using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InfiniteScroll.Services
{
    public class NewsService
    {
        const int PAGE_SIZE = 4;
        private static List<Entry> AllEntries { get; set; } 
        public List<Entry> getFeed(int pageNo)
        {
            if (AllEntries == null)
            {
                var wc = new WebClient();
                var xml = wc.DownloadString("http://rss.liberation.fr/rss/latest/");
                var serializer = new XmlSerializer(typeof(Feed));
                var sr = new StringReader(xml);
                var feeds = (Feed)serializer.Deserialize(sr);
                AllEntries = feeds.Entry.ToList();
            }            
            return AllEntries.Skip(pageNo * PAGE_SIZE).Take(PAGE_SIZE).ToList();                        
                
        }
    }
}
