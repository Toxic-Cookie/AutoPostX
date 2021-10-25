using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostX;
using System.Threading;

namespace AutoPostX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attempting to process assembly at path: " + args[0]);

            try
            {
                NeosAssemblyPostProcessor.Process(args[0]);

                Console.WriteLine("Successfully processed assembly!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception running post processing!");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Exiting in 5 seconds...");

                Thread.Sleep(5000);
            }
        }
    }
}
