using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder_ConsoleApp
{
    internal class Program
    {
        public static string ConcatenateString( int itrations )
        {
            string result = string.Empty;
            for ( int i = 0; i <= itrations; i++ )
            {
                result += "a";
            }
            return result;
        }
        public static string ConcatonateStringBuilder( int itrations )
        {
            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i <= itrations; i++ )
            {
                sb.Append( "a" );
            }
            return sb.ToString();
        }
        static void Main( string[] args )
        {
            int itrations = 300000;
            DateTime start = DateTime.Now;
            ConcatenateString( itrations );
            DateTime end = DateTime.Now;
            Console.WriteLine( "Time taken by string concatenation: " + ( end - start ).TotalMilliseconds );
            //////////////////////////////////////////////
            start = DateTime.Now;
            ConcatonateStringBuilder( itrations );
            end = DateTime.Now;
            Console.WriteLine( "Time taken by StringBuilder: " + ( end - start ).TotalMilliseconds );
            Console.ReadLine();
        }
    }
}
