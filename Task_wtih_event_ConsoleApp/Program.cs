using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_with_event_ConsoleApp
{
    // Custom Event Args
    internal class CustomEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CustomEventArgs( string name, int age )
        {
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        // Event Handler
        public delegate void CallBackEventHandler( object sender, CustomEventArgs e );
        // Event
        public static event CallBackEventHandler CallBackEvent;

        static async Task Main()
        {
            // Subscribe to the event
            CallBackEvent += OnCallBackEvent;
            // Perform the async operation
            Task perfomTask = PerformAsyncOperation( CallBackEvent );
            // Do some work
            Console.WriteLine( "Doing Some Work..." );
            // Wait for the task to complete
            await perfomTask;
            // Done
            Console.WriteLine( "Done" );
            Console.ReadLine();
        }
        // Perform Async Operation
        static async Task PerformAsyncOperation( CallBackEventHandler callBack )
        {
            await Task.Delay( 2000 );
            CustomEventArgs eventArgs = new CustomEventArgs( "Muhammed", 25 );
            callBack?.Invoke( null, eventArgs );
        }
        // Event Handler
        static void OnCallBackEvent( object sender, CustomEventArgs e )
        {
            Console.WriteLine( "Name: {0}, Age: {1}", e.Name, e.Age );
        }
    }
}
