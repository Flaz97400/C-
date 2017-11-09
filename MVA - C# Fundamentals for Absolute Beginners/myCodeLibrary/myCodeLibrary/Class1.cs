using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace myCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage( string url)
        {
            return GetWebPage(url);       
        }

        public string ScrapeWebPage(string url, string filePath)
        {
            string reply = GetWebPage(url);
            File.WriteAllText(filePath, reply);
            return reply;
        }


        private string GetWebPage(string url)
        {
            WebClient myWebClient = new WebClient();
            return myWebClient.DownloadString(url);    
        }
    }
}
