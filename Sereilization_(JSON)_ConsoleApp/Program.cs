using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
namespace Sereilization__JSON__ConsoleApp
{

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
    }

    internal class Program
    {
        static void Main( string[] args )
        {
            Person person = new Person
            {
                Name = "Saad",
                Age = 20,
                PhoneNumber = "1234567890"
            };

            // JSON serialization
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer( typeof( Person ) );
            using ( MemoryStream stream = new MemoryStream() )
            {
                jsonSerializer.WriteObject( stream, person );
                string json = Encoding.Default.GetString( stream.ToArray() );
                File.WriteAllText( "person.json", json );
            }
            using ( FileStream stream = new FileStream( "person.json", FileMode.Open ) )
            {
                Person deserializePerson = ( Person ) jsonSerializer.ReadObject( stream );
                Console.WriteLine( $"Name: {deserializePerson.Name} Age: {deserializePerson.Age}" );
            }
            Console.ReadLine();
        }
    }
}
