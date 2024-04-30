using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multy_threading_ConsoleApp
{
    internal class Program
    {

        static void Main( string[] args )
        {

            Thread t1 = new Thread( MyThread );
            Thread t2 = new Thread( () => myThread2( "method2" ) );// if we use parameter in method then we use lambda expression

            t1.Start();
            t2.Start();

            //t1.Join(); // it will wait for t1 to complete

            for ( int i = 0; i < 20; i++ )
            {
                Console.WriteLine( "main: => " + i );
                Thread.Sleep( 500 );
            }
            Console.ReadKey();
        }


        static void MyThread()
        {
            for ( int i = 0; i < 10; i++ )
            {
                Console.WriteLine( "MyThread-1: => " + i );
                Thread.Sleep( 500 );
            }
        }
        static void myThread2( string methodName )
        {
            for ( int i = 0; i < 10; i++ )
            {
                Console.WriteLine( $"{methodName} : => " + i );
                Thread.Sleep( 500 );
            }
        }
    }
}
