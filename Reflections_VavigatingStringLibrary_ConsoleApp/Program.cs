using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections_VavigatingStringLibrary_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            //Get Assembly Containing The System.String Type
            var stringAssembly = typeof( string ).Assembly;
            //Get The System.String Type
            var stringType = stringAssembly.GetType( "System.String" );
            if ( stringType != null )
            {
                Console.WriteLine( $"Methods of the System.String class:\n" );
                //Get All Methods of the System.String Type
                var methods = stringType.GetMethods( System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance ).OrderBy( method => method.Name );
                foreach ( var method in methods )
                {
                    Console.WriteLine( $"\t{method.ReturnType} {method.Name}({GetParameterList( method.GetParameters() )})" );
                }

            }
            else
            {
                Console.WriteLine( "System.String type not found!" );
            }
            Console.ReadKey();
        }
        static string GetParameterList( ParameterInfo[] parameters )
        {
            return string.Join( ", ", parameters.Select( parameter => $"{parameter.ParameterType} {parameter.Name}" ) );
        }
    }
}
