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
        bool AddTaskToList(string value, bool status);

        bool SaveTaskList();

        bool MarkTaskAsDone(int index);

        bool LoadTaskList();
    }

    public class Task
    {
        public string Description { get; set; }

        public bool IsDone { get; set; }

    }



    public class ToDoList : IToDoListFunctions
    {
        public List<Task> Tasks = new List<Task>();



        public bool AddTaskToList(string description, bool status = false)
        {
            Task newTask = new Task();
            newTask.IsDone = status;
            newTask.Description = description;
            Tasks.Add(newTask);
            return true;
        }

        public bool MarkTaskAsDone(int index)
        {
            Tasks[index].IsDone = true;
            return true;
        }


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


        public bool LoadTaskList()
        {
            StreamReader file = new StreamReader(@"ToDoList.txt");
            int counter = 0;
            string line;
            string status;
            bool taskIsDone;
            string description;

            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                string[] taskElements = line.Split(',');
                status = taskElements[0];
                description = taskElements[1];
                if (status == "False")
                    { taskIsDone = false;  }
                else
                    { taskIsDone = true; }
                if (taskElements.Length == 2)
                {
                    AddTaskToList(description, taskIsDone);
                }
                else
                    MessageBox.Show("There is an error in the ToDoList.txt file.  It is not in the proper format.");

                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
            return true;

        }
    }
}
