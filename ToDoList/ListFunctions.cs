using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ToDoList.ToDoList;
using System.IO;
using System.Diagnostics;


namespace ToDoList
{

    public interface IToDoListFunctions
    {
        void AddTaskToList(string value, bool status);

        void MarkTaskAsDone(int index);
    }

    public class Task
    {
        public string Description { get; set; }

        public bool IsDone { get; set; }

    }



    public class ToDoList : IToDoListFunctions
    {
        public List<Task> Tasks = new List<Task>();

        public void AddTaskToList(string description, bool status = false)
        {
            Task newTask = new Task();
            newTask.IsDone = status;
            newTask.Description = description;
            Tasks.Add(newTask);
        }


        public void ChangeTaskState (int index, bool state)            {
            //Tasks[index]
        }


        public void MarkTaskAsDone(int index)
        {
            Tasks[index].IsDone = true;
        }

        public void MarkTaskAsNotCompleted(int index)
        {
            Tasks[index].IsDone = false;
        }






    }
}
