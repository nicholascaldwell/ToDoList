using System;
using System.Windows.Forms;

namespace ToDoList
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbToDoList = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbToDoList
            // 
            this.clbToDoList.FormattingEnabled = true;
            this.clbToDoList.Location = new System.Drawing.Point(100, 100);
            this.clbToDoList.Name = "clbToDoList";
            this.clbToDoList.Size = new System.Drawing.Size(500, 89);
            this.clbToDoList.TabIndex = 0;
            this.clbToDoList.SelectedIndexChanged += new System.EventHandler(this.todoList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clbToDoList);
            this.Name = "HomeForm";
            this.Text = "To-do List";
            this.Load += new System.EventHandler(this.HomeForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbToDoList;

        private Button button1;
    }
}

