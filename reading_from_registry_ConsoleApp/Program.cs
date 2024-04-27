using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reading_from_registry_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            string keyPath = @"HKEY_CURRENT_USER\Software\DVLD_AR";
            string valueName = "userName";
            try
            {
                string valueData = Microsoft.Win32.Registry.GetValue( keyPath, valueName, null ) as string;
                if ( !( valueData is null ) )
                {
                    Console.WriteLine( $"Value of {valueName} is {valueData}" );
                }
                else
                {
                    Console.WriteLine( $"Value Of {valueName} Can`t Be Found.." );
                }
            }
            catch ( Exception ex )
            {

                Console.WriteLine( ex.Message );
            }
            Console.ReadKey();
        }
    }
}
