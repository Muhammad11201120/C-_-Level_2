using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_For_Examole_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            //Parallel.For( 0, 10, i =>
            //{
            //    Console.WriteLine( "i = " + ( i + 1 ) + $" ---- Task id = {Task.CurrentId}" );
            //} );


            Parallel.For( 0, 10, performTask ); // performTask is a method
            Console.WriteLine( " \n---- All Iterations End ---- " );
            Console.ReadLine();
        }
        static void performTask( int i ) // i will come from parallel for loop
        {
            Console.WriteLine( "i = " + ( i + 1 ) + $" ---- Task id = {Task.CurrentId}" );
        }
    }
}
