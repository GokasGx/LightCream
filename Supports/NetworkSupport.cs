using System;
using System.Net;

namespace LightCream
{
    public class NetworkCream
    {
        public static void DownloadFile(string url, string fileName)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadProgressChanged += (s, e) =>
                {
                    double percentage = (double)e.BytesReceived / (double)e.TotalBytesToReceive;
                    int progress = (int)(percentage * 100);
                    int chars = Console.WindowWidth - 20;
                    int completedChars = (int)(percentage * chars);
                    string progressBar = "[" + new string('=', completedChars) + new string('-', chars - completedChars) + "]";
                    Console.Write($"\rDescargando... {progressBar} {progress}%");
                };
                Console.Write("Descargando...");
                client.DownloadFile(url, fileName);
                Console.WriteLine("\nDescarga completada.");
            }
        }
    }
}
