using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace ToDoList
{
    public interface IListIO

    {
        void SaveTaskList(List<Task> list);

        void LoadTaskList(ToDoList list);

    }

    public class ListIO : IListIO
    {

        public void SaveTaskList(List<Task> list)
        {

            using (TextWriter TW = new StreamWriter("ToDoList.txt"))
            {
                foreach (Task task in list)
                {
                    TW.WriteLine(task.IsDone + "," + task.Description);
                }
            }
            Process.Start("ToDoList.txt");
        }

        public void LoadTaskList(ToDoList list)
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
                    taskIsDone = false; 
                else
                    taskIsDone = true;

                if (taskElements.Length == 2)
                    list.AddTaskToList(description, taskIsDone)
                else
                    MessageBox.Show("There is an error in the ToDoList.txt file.  It is not in the proper format.");

                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);

        }
    }
}
