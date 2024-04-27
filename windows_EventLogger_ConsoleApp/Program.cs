using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_EventLogger_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            // Create an event source
            string sourceName = "MyApp";

            // Check if the event source exists
            if ( !System.Diagnostics.EventLog.SourceExists( sourceName ) )
            {
                System.Diagnostics.EventLog.CreateEventSource( sourceName, "Application" );
                Console.WriteLine( "Event Source Created Successfully" );
            }

            // Log an information message to the event log
            System.Diagnostics.EventLog.WriteEntry( sourceName, "This is a test message", System.Diagnostics.EventLogEntryType.Information );
            System.Diagnostics.EventLog.WriteEntry( sourceName, "This is a test message", System.Diagnostics.EventLogEntryType.Error );
            System.Diagnostics.EventLog.WriteEntry( sourceName, "This is a test message", System.Diagnostics.EventLogEntryType.Warning );
            Console.ReadKey();
        }
    }
}
