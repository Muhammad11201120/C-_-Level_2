using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Factory_Class_ConsoleApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            TaskFactory taskFactory = new TaskFactory(
                token,
                TaskCreationOptions.PreferFairness,
                TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Default
                );

            Task task1 = taskFactory.StartNew( () =>
            {
                Thread.Sleep( 2000 );
                Console.WriteLine( "Task1 Staeted.." );
                Thread.Sleep( 2000 );
                Console.WriteLine( "ask1 End.." );
            } );
            Task task2 = taskFactory.StartNew( () =>
            {
                Thread.Sleep( 2000 );
                Console.WriteLine( "Task2 Staeted.." );
                Thread.Sleep( 2000 );
                Console.WriteLine( "ask2 End.." );
            } );


            try
            {
                // Wait for both tasks to complete
                Task.WaitAll( task1, task2 );
                Console.WriteLine( "All tasks completed." );
            }
            catch ( AggregateException ae )
            {
                // Handle exceptions if any task throws
                foreach ( var e in ae.InnerExceptions )
                    Console.WriteLine( $"Exception: {e.Message}" );
            }


            // Dispose of the CancellationTokenSource
            cts.Dispose();
            Console.ReadLine();
        }
    }
}
