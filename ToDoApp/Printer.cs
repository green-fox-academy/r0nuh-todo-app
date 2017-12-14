using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Printer
    {
        public string[] Content = File.ReadAllLines(@"C:\Users\Szilard\Documents\greenfox\r0nuh-todo-app\ToDoApp\ToDo.txt");

        public string[] CliArguments = {
            "-l   Lists all the tasks",
            "-a   Adds a new task",
            "-r   Removes a task",
            "-c   Completes a task" };

        public void NoArgument()
        {
            Console.WriteLine("Command Line Todo application");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("Command line arguments:");
            foreach (string argument in CliArguments)
            {
                Console.WriteLine(argument);
            }
        }

        public void ListTasks(string argument)
        {
            if (Content.Length > 0)
            {
                int i = 0;
                foreach (string line in Content)
                {
                    ++i;
                    Console.WriteLine("{0} - {1}", i, line);
                }
            }
            else
            {
                Console.WriteLine("No todos for today! :)");
            }
            
        } 
    }
}

