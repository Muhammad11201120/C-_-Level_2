using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MultyCastDelegate_ConsoleApp
{
    public delegate void MyDelegate( string message );

    internal class Program
    {

        static void Main( string[] args )
        {
            MyDelegate myDelegate = null;


            myDelegate += method1;
            myDelegate += method2;

            myDelegate( "Hello World" );


            myDelegate -= method1;

            myDelegate( "Hello World" );
            Console.ReadKey();
        }

        static void method1( string message )
        {

            Console.WriteLine( "Method1: " + message + "From Method 1" );
        }
        static void method2( string message )
        {
            Console.WriteLine( "Method2: " + message + "From Method 2" );
        }
    }

}
