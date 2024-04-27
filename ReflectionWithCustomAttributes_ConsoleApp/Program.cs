using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionWithCustomAttributes_ConsoleApp
{
    internal class Program
    {
        [AttributeUsage( AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true )]
        public class DescriptionAttribute : Attribute
        {
            public string Description { get; }
            public DescriptionAttribute( string description )
            {
                Description = description;
            }
        }
        /// <summary>
        /// /////////////////////////////////////////
        /// </summary>
        [Description( "This is a class" )]
        public class MyClass
        {
            [Description( "This is a method" )]
            public void MyMethod()
            {
            }
        }
        /// <summary>
        /// //////////////////////////////////////////
        /// </summary>
        static void Main( string[] args )
        {
            //Get Type Of MyClass
            Type type = typeof( MyClass );
            //Get  Class-level Description Attribute
            object[] attributes = type.GetCustomAttributes( typeof( DescriptionAttribute ), false );
            foreach ( DescriptionAttribute attribute in attributes )
            {
                Console.WriteLine( attribute.Description );
            }
            //Get Method MyMethod
            System.Reflection.MethodInfo method = type.GetMethod( "MyMethod" );
            // Get method-level Description attributes
            object[] methodAttributes = method.GetCustomAttributes( typeof( DescriptionAttribute ), false );
            foreach ( DescriptionAttribute attribute in methodAttributes )
            {
                Console.WriteLine( attribute.Description );
            }
            Console.ReadLine();
        }
    }
}
