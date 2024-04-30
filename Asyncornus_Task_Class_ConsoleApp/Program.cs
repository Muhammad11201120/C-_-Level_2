using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asyncornus_Task_Class_ConsoleApp
{
    internal class Program
    {
        static async Task Main( string[] args )
        {
            // this will return a task
            Task<int> taskResult = myTask();//Task<int> taskResult = myTask().Result; // this will block the main thread

            Console.WriteLine( "Main Thread is working" );// this will print first

            int result = await taskResult;// this will block the main thread

            Console.WriteLine( $"Result = > {result}" );// this will print last
            Console.ReadKey();
        }
        // this method will return a task
        static async Task<int> myTask()
        {
            await Task.Delay( 3000 );
            return 3;
        }
    }
}
