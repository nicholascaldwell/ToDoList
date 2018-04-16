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

        void PopulateTodoList()
        {
            //var checkBoxList = (ListBox)clbToDoList;

        }
        private void HomeForm_Load_1(object sender, EventArgs e)
        {
            PopulateTodoList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            bool success = myToDoList.SaveTaskList();
        }


        private void todoList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // find the proper task in myToDoList and update it.  Syntax for get an item from a list
                myToDoList.MarkTaskAsDone(e.Index);
            }
        }

    }
}
