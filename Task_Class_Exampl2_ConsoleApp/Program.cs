using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Task_Class_Exampl2_ConsoleApp
{
    internal class Program
    {
        static async Task Main()
        {

            Console.WriteLine();

            Task t1 = DownloadAndPrintAsync( "https://www.google.com" );
            Task t2 = DownloadAndPrintAsync( "https://www.facebook.com" );
            Task t3 = DownloadAndPrintAsync( "https://www.amazon.com" );

            await Task.WhenAll( t1, t2, t3 );
            Console.WriteLine( "All tasks are completed" );
            Console.ReadKey();

        }
        static async Task DownloadAndPrintAsync( string url )
        {

            string content;

            // Using statement ensures that the WebClient is disposed of properly
            using ( WebClient client = new WebClient() )
            {
                // Simulate some work by adding a delay
                await Task.Delay( 100 );

                // Download the content of the web page asynchronously
                content = await client.DownloadStringTaskAsync( url );
            }

            // Print the URL and the length of the downloaded content
            Console.WriteLine( $"{url}: {content.Length} characters downloaded" );
        }
    }
}
