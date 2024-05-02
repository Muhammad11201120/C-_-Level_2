using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_foreach_example_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            List<string> urls = new List<string>
            {
               "https://www.cnn.com",
                "https://www.amazon.com",
                "https://www.programmingadvices.com"
            };

            // Download the content of the web pages in parallel
            Parallel.ForEach( urls, url =>
            {
                DownloadingUrl( url );
            } );
            Console.ReadLine();
        }
        static void DownloadingUrl( string url )
        {
            string content;
            using ( WebClient client = new WebClient() )
            {
                // Simulate some work by adding a delay
                Thread.Sleep( 100 );


                // Download the content of the web page
                content = client.DownloadString( url );
            }
            Console.WriteLine( $"{url}: {content.Length} characters downloaded" );
        }
    }
}
