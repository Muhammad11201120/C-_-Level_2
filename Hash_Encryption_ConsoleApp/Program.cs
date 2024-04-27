using System.Security.Cryptography;
using System;
using System.Text;

namespace Hash_Encryption_ConsoleApp
{

    internal class Program
    {

        static void Main( string[] args )
        {
            // Input data
            string data = "Mohammed Aissa";


            // Compute the SHA-256 hash of the input data
            string hashedData = ComputeHash( data );


            // Display the original data and its hash
            Console.WriteLine( $"Original Data: {data}" );
            Console.WriteLine( $"Hashed Data: {hashedData}" );


            // Pause to keep the console window open for viewing the results
            Console.ReadKey();
        }

        static string ComputeHash( string input )
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using ( SHA256 sha256 = SHA256.Create() )
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash( Encoding.UTF8.GetBytes( input ) );


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString( hashBytes ).Replace( "-", "" ).ToLower();
            }
        }

    }
}
