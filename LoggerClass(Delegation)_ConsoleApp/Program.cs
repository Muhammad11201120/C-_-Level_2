using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerClass_Delegation__ConsoleApp
{
    public class Logger
    {
        // Declare Delegate
        public delegate void LoggerDelegate( string message );
        // get instance 
        private LoggerDelegate _logger;
        // constructor with delegate as a parameter
        public Logger( LoggerDelegate loggerDelegate )
        {
            _logger = loggerDelegate;
        }
        //method to call the delegate
        public void Log( string message )
        {
            _logger( message );
        }
    }
    internal class Program
    {
        public static void LogToScreen( string message )
        {
            Console.WriteLine( message );
        }
        public static void LogToFile( string message )
        {
            System.IO.File.WriteAllText( "log.txt", message );
        }
        static void Main( string[] args )
        {
            Logger logToScreen = new Logger( LogToScreen );
            Logger logToFile = new Logger( LogToFile );

            logToScreen.Log( "here is a message to log to the screen" );
            logToFile.Log( "here is a message to log to the file" );
            Console.ReadKey();
        }
    }
}
