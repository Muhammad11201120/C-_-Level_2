using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace syncroniziation_example_ConsoleApp
{
    internal class Program
    {
        static int sharedCounter = 0;
        static object lockObject = new object();

        static void Main( string[] args )
        {
            Thread t1 = new Thread( IncrementCounter );
            Thread t2 = new Thread( IncrementCounter );

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine( "Shared counter: {0}", sharedCounter );
            Console.ReadKey();
        }
        static void IncrementCounter()
        {
            for ( int i = 0; i < 1000000; i++ )
            {
                lock ( lockObject ) // this look will make sure that only one thread can access the sharedCounter at a time
                {
                    sharedCounter++;
                }
            }
        }
    }
}
