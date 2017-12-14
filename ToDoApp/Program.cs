using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cliArguments = {
            "-l   Lists all the tasks",
            "-a   Adds a new task",
            "-r   Removes a task",
            "-c   Completes a task" };

            Console.WriteLine("Command Line Todo application");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("Command line arguments:");
            foreach (string argument in cliArguments)
            {
                Console.WriteLine(argument);
            }
            Console.Read();
        }
    }
}
