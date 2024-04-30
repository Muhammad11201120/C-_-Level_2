using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading_ConsoleApp
{
    internal class Point
    {
        private int _X;
        private int _Y;
        public Point( int x, int y )
        {
            _X = x;
            _Y = y;
        }

        public static Point operator +( Point p1, Point p2 )
        {
            return new Point( p1._X + p2._X, p1._Y + p2._Y );
        }
        public static Point operator -( Point p1, Point p2 )
        {
            return new Point( p1._X - p2._X, p1._Y - p2._Y );
        }
        public static Point operator *( Point p1, Point p2 )
        {
            return new Point( p1._X * p2._X, p1._Y * p2._Y );
        }
        public static bool operator ==( Point p1, Point p2 )
        {
            return ( p1._X == p2._X && p1._Y == p2._Y );
        }
        public static bool operator !=( Point p1, Point p2 )
        {
            return ( p1._X != p2._X || p1._Y != p2._Y );
        }
        public override string ToString()
        {
            return $"X: {_X}, Y: {_Y}";
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            Point point1 = new Point( 1, 2 );
            Point point2 = new Point( 3, 4 );

            // Using the overloaded + operator for point addition
            Point point3 = point1 + point2;
            // Using the overloaded + operator for point addition
            Point point4 = point1 - point2;

            Point point5 = new Point( 1, 2 );
            if ( point1 == point2 )
            {
                Console.WriteLine( "Yes => point1 == point2" );
            }
            else
            {
                Console.WriteLine( "No => point1 != point2" );
            }
            if ( point1 == point5 )
            {
                Console.WriteLine( "Yes => point1 == point5" );
            }
            else
            {
                Console.WriteLine( "No => point1 != point5" );
            }
            Console.WriteLine( $"Point1 : {point1}" );
            Console.WriteLine( $"Point2 : {point2}" );
            Console.WriteLine( $"Point3 is the result of point1 + point2: {point3}" );
            Console.WriteLine( $"Point4 is the result of point1 - point2: {point4}" );

            Console.ReadKey();
        }
    }
}
