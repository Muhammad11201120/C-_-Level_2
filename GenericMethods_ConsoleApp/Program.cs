using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods_ConsoleApp
{
    class Util
    {
        public static void Swap<T>( ref T value1, ref T value2 )
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            int a = 10, b = 20;
            Console.WriteLine( "Before Swap: a = {0}, b = {1}", a, b );
            Util.Swap<int>( ref a, ref b );
            Console.WriteLine( "After Swap: a = {0}, b = {1}", a, b );

            string str1 = "Hello", str2 = "World";
            Console.WriteLine( "Before Swap: str1 = {0}, str2 = {1}", str1, str2 );
            Util.Swap<string>( ref str1, ref str2 );
            Console.WriteLine( "After Swap: str1 = {0}, str2 = {1}", str1, str2 );

            Console.ReadKey();
        }
    }
}
