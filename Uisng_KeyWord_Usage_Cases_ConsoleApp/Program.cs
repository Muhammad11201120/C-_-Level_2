using System; // 1-We Can Us It To Import Libs
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MO = System.Console; //2-We Can Use Alias To Rename The Namespace
using static System.Math; //3-We Can Use Static Keyword To Import Static Members

namespace Uisng_KeyWord_Usage_Cases_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            MO.WriteLine( "Hello There" );
            double number = Sqrt( 9 ); //We Can Use Static Members Without The Class Name
            MO.WriteLine( "The Square Root Of 9 Is: " + number );
            MO.ReadKey();

            using ( var reader = new System.IO.StreamReader( "example.txt" ) ) // 4-We Can Use Using Keyword To Dispose The Object After The Block
            {
                string line;
                while ( ( line = reader.ReadLine() ) != null )
                {
                    Console.WriteLine( line );
                }
            }
            // The StreamReader will be automatically closed and resources released.
        }
    }
}
