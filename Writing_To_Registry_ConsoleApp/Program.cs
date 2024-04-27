using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_To_Registry_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            //specify the path to the key
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_AR";
            string valueName = "userName";
            string valueData = "ميدو";
            try
            {
                // write the value to the registry
                Microsoft.Win32.Registry.SetValue( keyPath, valueName, valueData );
                Console.WriteLine( $"value {valueName} successfully written to the registry.." );
            }
            catch ( Exception ex )
            {

                Console.WriteLine( ex.Message );
            }
            Console.ReadLine();
        }
    }
}
