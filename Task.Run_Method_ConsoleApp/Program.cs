using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Run_Method_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            // Task.Run Methods
            Task task1 = Task.Run( () => DownloadFile( "File One" ) );
            task1.Wait();
            Task task2 = Task.Run( () => DownloadFile( "File Two" ) );
            task2.Wait();

            Console.WriteLine( "All tasks completed" );
            Console.ReadLine();
        }
        // Download File Method
        static void DownloadFile( string fileName )
        {
            Console.WriteLine( $"Downloading {fileName} Has been Started" );
            Thread.Sleep( 2000 );
            string dot = string.Empty;
            for ( int i = 0; i < 5; i++ )
            {
                dot += ".";
                Console.Write( dot );
                Thread.Sleep( 1000 );
            }

            Console.WriteLine( $"Downloading {fileName} Has been Completed" );
            Thread.Sleep( 2000 );
        }
    }
}
