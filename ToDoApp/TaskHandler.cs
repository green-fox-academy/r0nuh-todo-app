using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoApp
{
    class TaskHandler
    {
        string path = @"C:\Users\Szilard\Documents\greenfox\r0nuh-todo-app\ToDoApp\ToDo.txt";

        public void AddTask(string task)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("[ ] " + task);
            writer.Close();
        }

        public void RemoveTask(int row)
        {
            List<string> todoList = new List<string>();
            string[] content = File.ReadAllLines(path);
            todoList.AddRange(content);

            todoList.Remove(todoList[row - 1]);

            File.WriteAllLines(path, todoList.ToArray());
        }

        public void CheckTask(int taskNumber)
        {
            string[] content = File.ReadAllLines(path);
            
            content[taskNumber - 1] = content[taskNumber - 1].Replace("[ ]", "[X]");
            
            File.WriteAllLines(path, content);
        }
    }
}
