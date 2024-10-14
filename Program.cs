using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Child process started.");

            foreach (var arg in args)
            { 
                Console.WriteLine($"Argument: {arg}");
            }

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Child process completed.");
        }
    }
}
