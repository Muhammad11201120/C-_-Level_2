using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegate_ConsoleApp
{
    internal class Program
    {
        static Predicate<int> isEven = ( x ) => x % 2 == 0; // predicate used to check if a number is even and return bool value
        static void Main( string[] args )
        {
            Console.WriteLine( isEven( 2 ) );

            Console.ReadKey();
        }
    }
}
