using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_Class_ConsoleApp
{
    public class genericClass<T>
    {
        public T genericProp { get; set; }
        public void genericMethod( T genericParam )
        {
            Console.WriteLine( "Parameter type: {0}, value: {1}", typeof( T ), genericParam );
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            genericClass<int> intObj = new genericClass<int> { genericProp = 10 };
            intObj.genericMethod( intObj.genericProp );

            genericClass<string> stringObj = new genericClass<string> { genericProp = "Hello, World!" };
            stringObj.genericMethod( stringObj.genericProp );
            Console.ReadKey();
        }
    }
}
