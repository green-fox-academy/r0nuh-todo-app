using System;
using System.IO;

namespace ToDoApp
{
    class Printer
    {
        protected string[] content = File.ReadAllLines(@"C:\Users\Szilard\Documents\greenfox\r0nuh-todo-app\ToDoApp\ToDo.txt");

        string[] cliArguments = {
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
            foreach (string argument in cliArguments)
            {
                Console.WriteLine(argument);
            }
        }

        public void ListTasks()
        {
            if (content.Length > 0)
            {
                int i = 0;
                foreach (string line in content)
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

