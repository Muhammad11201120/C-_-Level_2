using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableValues_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            int? PersonID = null;
            if ( PersonID.HasValue )
            {
                Console.WriteLine( "yes" );
            }
            else
            {
                Console.WriteLine( "No" );
            }

            PersonID = 1;
            if ( PersonID.HasValue )
            {
                Console.WriteLine( "yes" );
            }
            else
            {
                Console.WriteLine( "No" );
            }

            Console.ReadLine();
        }
    }
}
