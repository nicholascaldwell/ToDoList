using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList;

namespace ToDoList
{
    public partial class HomeForm : Form
    {
        public ToDoList myToDoList { get; set; } = new ToDoList();

        public ListIO myIOHandler = new ListIO();
        
        public HomeForm()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            myToDoList.AddTaskToList(txtDescription.Text);
            clbToDoList.Items.Add(txtDescription.Text);
            txtDescription.Clear();
        }

        void PopulateTodoList(string description, bool status)
        {
            clbToDoList.Items.Add(description, status);

        }
        private void HomeForm_Load_1(object sender, EventArgs e)
        {
            //TODO: Load default list when forms is launched.
            //PopulateTodoList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LabeLClick");
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            myIOHandler.SaveTaskList(myToDoList.Tasks);
        }



        private void todoList_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                myToDoList.MarkTaskAsDone(e.Index);
            }
            else
            {
                myToDoList.MarkTaskAsNotCompleted(e.Index);
            }
        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            // clear the checkBoxList
            for (int i = clbToDoList.Items.Count - 1; i >= 0; i--)
            {
                clbToDoList.Items.RemoveAt(i);
            }
            clbToDoList.Refresh();
            myToDoList.Tasks.Clear();
            myIOHandler.LoadTaskList(myToDoList);
            foreach (Task task in myToDoList.Tasks)
            {
                PopulateTodoList(task.Description, task.IsDone);
            }
            
        }
    }
}
