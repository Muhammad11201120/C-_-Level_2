using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutomAttributesForValidation_ConsoleApp
{
    [AttributeUsage( AttributeTargets.Property, AllowMultiple = false, Inherited = false )]
    public class RangeAttribute : Attribute
    {
        public int Min { get; }
        public int Max { get; }
        public string ErrorMessage { get; set; }
        public RangeAttribute( int min, int max )
        {
            Min = min;
            Max = max;
        }
    }
    public class Person
    {
        [Range( 18, 60, ErrorMessage = "Age must be between 18 and 60" )]
        public int Age { get; set; }

        [Range( 20, 30, ErrorMessage = "Experience must be between 20 and 30" )]
        public int Experience { get; set; }

        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            Person person = new Person
            {
                Age = 18,
                Name = "Saeed",
                Experience = 10
            };
            if ( ValidatePerson( person ) )
            {
                Console.WriteLine( "Person  Is Valid" );
            }
            else
            {
                Console.WriteLine( "Person  Is Not Valid" );
            }
            Console.ReadKey();
        }
        public static bool ValidatePerson( Person person )
        {
            Type type = typeof( Person );
            foreach ( var property in type.GetProperties() )
            {
                if ( Attribute.IsDefined( property, typeof( RangeAttribute ) ) )
                {
                    var rangeAttribute = ( RangeAttribute ) Attribute.GetCustomAttribute( property, typeof( RangeAttribute ) );
                    int value = ( int ) property.GetValue( person );
                    if ( value < rangeAttribute.Min || value > rangeAttribute.Max )
                    {
                        Console.WriteLine( $"Validation Vailed For Property {property.Name} : {rangeAttribute.ErrorMessage}" );
                        return false;
                    }
                }
            }
            return true;
        }
    }
}