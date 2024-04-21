using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Serilaization__XML__ConsoleApp
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string phoneNumber { get; set; }

        public void PrintPersonInfo()
        {
            Console.WriteLine( $"Person Name: {this.Name}, Person Age: {this.Age}, Person Phone Number: {this.phoneNumber}" );
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            Person person = new Person
            {
                Name = "Ahmed",
                Age = 25,
                phoneNumber = "123456789"
            };
            // XML serialization
            XmlSerializer sterilizer = new XmlSerializer( typeof( Person ) );
            using ( System.IO.StreamWriter streamWriter = new System.IO.StreamWriter( "Person.xml" ) )
            {
                sterilizer.Serialize( streamWriter, person );
            }
            // Deserialize the object back
            using ( TextReader reader = new StreamReader( "person.xml" ) )
            {
                Person deserializedPerson = ( Person ) sterilizer.Deserialize( reader );
                Console.WriteLine( $"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}" );
            }
            Console.ReadLine();
        }
    }
}
