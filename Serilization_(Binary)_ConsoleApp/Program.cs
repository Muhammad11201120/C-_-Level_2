﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person { Name = "Mohammed", Age = 46 };


        // Binary serialization
        BinaryFormatter formatter = new BinaryFormatter();
        using ( FileStream stream = new FileStream( "person.bin", FileMode.Create ) )
        {
            formatter.Serialize( stream, person );
        }


        // Deserialize the object back
        using ( FileStream stream = new FileStream( "person.bin", FileMode.Open ) )
        {
            Person deserializedPerson = ( Person ) formatter.Deserialize( stream );
            Console.WriteLine( $"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}" );
            Console.ReadKey();
        }
    }
}