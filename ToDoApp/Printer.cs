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
        public string Content = File.ReadAllText(@"C:\Users\Szilard\Documents\greenfox\r0nuh-todo-app\ToDoApp\ToDo.txt");

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

            Console.WriteLine(Content);
        } 
    }
}

