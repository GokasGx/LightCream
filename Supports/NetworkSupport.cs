using System;
using System.Net;

namespace LightCream
{
    public class NetworkCream
    {
        ///<summary>
        ///Version comparator, pas1 (version of your application), pas 2 (version to update) 
        ///</summary>
        public static bool UpdateCompare(string pas1, string pas2)
        {
            using (WebClient client = new WebClient())
            {
                string compare2 = client.DownloadString(pas2);
                return pas1 != compare2;
            }
        }


        ///<summary>
        ///File downloader, pastebinUrls (link of pastebin raw that contains links of files to download) 
        ///</summary>
        public static void DownloadFiles(string pastebinUrls)
        {
            using (WebClient client = new WebClient())
            {
                string pastebinContent = client.DownloadString(pastebinUrls);
                List<string> urls = new List<string>();
                string[] lines = pastebinContent.Split(new[]{ Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    urls.Add(line);
                }
                foreach (string url in urls)
                {
                    Log.LogInfo($"Descargando archivo: [{url}]");
                    client.DownloadFile(url, Path.GetFileName(url));
                    Log.LogInfo($"Archivo descargado: [{Path.GetFileName(url)}]");
                }
            }
        }
    }
}
