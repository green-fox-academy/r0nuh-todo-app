using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var print = new Printer();
            var handle = new TaskHandler();

            if (args.Length == 0)
            {
                print.NoArgument();
            }
            else if (args[0] != "-l" && args[0] != "-a" && args[0] != "-r" && args[0] != "-c")
            {
                Console.WriteLine("Unsupported argument");
                Console.WriteLine();
                print.NoArgument();
            }
            else if (args[0] == "-l")
            {
                print.ListTasks();
            }
            else if (args[0] == "-a")
            {
                try
                {
                    handle.AddTask(args[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }
            else if (args[0] == "-r")
            {
                try
                {
                    handle.RemoveTask(Convert.ToInt32(args[1]));
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to remove: no index provided");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Unable to remove: index is out of bound");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to remove: index is not a number");
                }
            }
            else if (args[0] == "-c")
            {
                try
                {
                    handle.CheckTask(Convert.ToInt32(args[1]));
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to check: no index provided");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Unable to check: index is out of bound");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to check: index is not a number");
                }
            }
        }
    }
}
