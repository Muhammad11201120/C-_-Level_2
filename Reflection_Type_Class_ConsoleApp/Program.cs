using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Type_Class_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Type myType = typeof( string );
            Console.WriteLine( "TYPE INFORMATION: " );
            Console.WriteLine();
            Console.WriteLine( "Full Name: {0}", myType.FullName );
            Console.WriteLine( "Name: {0}", myType.Name );
            Console.WriteLine( "Namespace: {0}", myType.Namespace );
            Console.WriteLine( "Assembly Qualified Name: {0}", myType.AssemblyQualifiedName );
            Console.ReadKey();
        }
    }
}
