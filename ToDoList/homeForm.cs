using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class HomeForm : Form
    {
        public ToDoList myToDoList { get; set; } = new ToDoList();
        
        public HomeForm()
        {
            InitializeComponent();
        }

        private void todoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            myToDoList.AddTaskToList();
            foreach (Task task in myToDoList.Tasks)
            {
                MessageBox.Show(task.Description);
                clbToDoList.Items.Add(task.Description);
                //checkBoxList.DisplayMember = "name";
                //checkBoxList.ValueMember = "enabled";
            }
        }

        void PopulateTodoList()
        {
            //var checkBoxList = (ListBox)clbToDoList;

        }
        private void HomeForm_Load_1(object sender, EventArgs e)
        {
            PopulateTodoList();
        }
    }
}
