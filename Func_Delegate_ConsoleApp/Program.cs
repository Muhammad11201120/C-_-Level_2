using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegate_ConsoleApp
{
    internal class Program
    {
        // using named Functions
        static Func<int, int> Square;
        static int squareMethod( int x )
        {
            return x * x;
        }

        // using lambda expression
        static Func<int, int> Square2 = ( x ) => x * x;


        static void Main( string[] args )
        {

            Square = squareMethod;

            int result = Square( 5 );
            int result2 = Square2( 10 );
            Console.WriteLine( "Result = " + result );
            Console.WriteLine( "Result2 = " + result2 );
            Console.ReadLine();
        }
    }
}
