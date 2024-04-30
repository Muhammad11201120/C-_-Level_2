using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace downloading_three_web_pages_using_multythreading_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Threads Starts:" );


            Thread t1 = new Thread( () => DownloadWebPage( "http://www.cnn.com" ) );
            Console.WriteLine( "Downloading cnn started.." );
            t1.Start();



            Thread t2 = new Thread( () => DownloadWebPage( "http://www.microsoft.com" ) );
            t2.Start();
            Console.WriteLine( "Downloading microsoft started.." );



            Thread t3 = new Thread( () => DownloadWebPage( "http://www.yahoo.com" ) );
            t3.Start();
            Console.WriteLine( "Downloading yahoo started.." );



            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine( "Threads Ends.." );
            Console.ReadKey();
        }
        static void DownloadWebPage( string url )
        {
            var webClient = new System.Net.WebClient();
            var content = webClient.DownloadString( url );
            Console.WriteLine( $"webPage Has : ( {content.Length} ) Characters" );
        }
    }
}
