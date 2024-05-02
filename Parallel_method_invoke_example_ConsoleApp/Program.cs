using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_method_invoke_example_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Thread.Sleep( 1000 );

            Parallel.Invoke( method1, method2, method3 ); // it will create 3 threads and run all the methods in parallel

            Thread.Sleep( 1000 );


            Console.WriteLine( "fininshed" );
            Console.ReadLine();
        }

        static void method1()
        {
            Console.WriteLine( "Method 1" );
        }
        static void method2()
        {
            Console.WriteLine( "Method 2" );
        }
        static void method3()
        {
            Console.WriteLine( "Method 3" );
        }
    }
}
