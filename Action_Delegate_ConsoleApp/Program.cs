using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Actions with named functions
        /// </summary>
        static Action<int, int> Operations = Add; // Action using For Procedures that return void
        static Action<int> IsEven = isEven;

        public static void Add( int a, int b )
        {
            Console.WriteLine( "Addition is: " + ( a + b ) );
        }
        public static void Subtract( int a, int b )
        {
            Console.WriteLine( "Subtraction is: " + ( a - b ) );
        }
        public static void Multiply( int a, int b )
        {
            Console.WriteLine( "Multiplication is: " + ( a * b ) );
        }
        public static void Divide( int a, int b )
        {
            Console.WriteLine( "Division is: " + ( a / b ) );
        }
        public static void isEven( int a )
        {
            if ( a % 2 == 0 )
            {
                Console.WriteLine( "YES" );
            }
            else
            {
                Console.WriteLine( "NO" );
            }
        }
        /// <summary>
        /// Actions with anonymous functions
        /// </summary>

        static Action<int> IsEven2 = ( int a ) =>
        {
            if ( a % 2 == 0 )
            {
                Console.WriteLine( "it is Even" );
            }
            else
            {
                Console.WriteLine( "it is Odd" );
            }
        };
        static void Main( string[] args )
        {
            Operations = Add;
            Operations += Subtract;
            Operations += Multiply;
            Operations += Divide;

            Operations( 5, 3 );
            Console.WriteLine();

            IsEven( 2 );
            IsEven( 5 );
            IsEven2( 4 );


            Console.ReadKey();
        }
    }
}
