
#define myAttribute // Here is defining the attribute

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Diagnostics;

namespace Attributes_ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// There Are many Attributes here is Some:
        /// 1-Serialization Attributes
        /// 2-Conditional Attributes
        /// 3-Obsolete Attributes
        /// 4-Custom Attributes (We will Cover This Topic in Reflection Lessons)
        /// </summary>

        [Serializable]
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            [NonSerialized] // this field will not be serialized to the object file
            public string PhoneNumber;
        }


        static void Main( string[] args )
        {

            Person person = new Person
            {
                Name = "Ahmed",
                Age = 20,
                PhoneNumber = "01000000000"
            };
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer( typeof( Person ) );
            using ( System.IO.MemoryStream stream = new System.IO.MemoryStream() )
            {
                jsonSerializer.WriteObject( stream, person );
                string json = Encoding.UTF8.GetString( stream.ToArray() );
                File.WriteAllBytes( "Person.json", stream.ToArray() );
            }
            using ( FileStream stream = new FileStream( "person.json", FileMode.Open ) )
            {
                Person desrializePerson = ( Person ) jsonSerializer.ReadObject( stream );
                Console.WriteLine( $"Name = {desrializePerson.Name} AGE = {desrializePerson.Age}" );
            }

            PrintError( "Error" );
            Console.WriteLine( "Rest Of Program" );
            DepricatedMethod();
            Console.ReadKey();
        }
        [Conditional( "DEBUG" )] // only work in debug mode even if the method is called in release mode
        static void PrintError( string message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( message );
            Console.ResetColor();
        }
        [Obsolete( "This Method will Deprecated next update" )]
        static void DepricatedMethod()
        {
            Console.WriteLine( "This Method will Deprecated next update" );
        }

    }
}
