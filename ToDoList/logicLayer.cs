using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ToDoList.ToDoList;

namespace ToDoList
{
    // Interface CreateTask
    // Interface SaveList
    public interface IToDoList
    {
       // bool SaveTaskList();   // move to UI interface
        bool AddTaskToList();

    }

    public class Task
    {
        public string Description { get; set; }

        public bool IsDone { get; set; }

    }



    public class ToDoList : IToDoList
    {
        public List<Task> Tasks = new List<Task>();

        public bool SaveTaskList()
        {
            return false;
        }

        public bool AddTaskToList()
        {
            Task newTask = new Task();
            newTask.Description = "New task";
            newTask.IsDone = false;
            Tasks.Add(newTask);
            return true;
        }

    }
}
