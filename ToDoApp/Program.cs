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
            var print = new Printer();

            foreach(string arg in args)
            {
                if (arg == "-l")
                {
                print.ListTasks("-l");
                }
                else if (args == null)
                {
                print.NoArgument();
                }

            }
            //Console.Read();
            
        }
    }
}
