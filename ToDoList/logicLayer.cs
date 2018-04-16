using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ToDoList.ToDoList;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;  // remove after debugging

namespace ToDoList
{
    // Interface CreateTask
    // Interface SaveList
    public interface IToDoListFunctions
    {
       // bool SaveTaskList();   // move to UI interface
        bool AddTaskToList(string value);

        bool SaveTaskList();

        bool MarkTaskAsDone(int index);

    }

    public class Task
    {
        public string Description { get; set; }

        public bool IsDone { get; set; }

    }



    public class ToDoList : IToDoListFunctions
    {
        public List<Task> Tasks = new List<Task>();

        public bool SaveTaskList()
        {
            
            using (TextWriter TW = new StreamWriter("ToDoList.txt"))
            {
                foreach (Task task in Tasks)
                {
                    TW.WriteLine(task.IsDone + "," + task.Description);
                }
            }
            Process.Start("ToDoList.txt");
            return false;
        }

        public bool AddTaskToList(string description)
        {
            Task newTask = new Task();
            newTask.Description = description;
            newTask.IsDone = false;
            Tasks.Add(newTask);
            return true;
        }

        public bool MarkTaskAsDone(int index)
        {
            Tasks[index].IsDone = true;
            return true;
        }

    }
}
