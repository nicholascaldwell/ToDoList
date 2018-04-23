using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;

namespace ToDoList
{
    public class Tests
    {

        [Fact]
        private void GetNewTask()
        {
            Task task = new Task
            {
                Description = "Test"
            };
            String getDescription = task.Description;
            getDescription.ShouldBe("Test");
            bool status = task.IsDone;
            status.ShouldBe(false);
        }

        [Fact]
        private void Task_DescriptionDeafultIsNull()
        {
            Task task = new Task();
            String getDescription = task.Description;
            getDescription.ShouldBe(null);
        }

        [Fact]
        private void Task_IsDoneDefaultIsFalse()
        {
            Task task = new Task();

            // Verify default value is false
            task.IsDone.ShouldBe(false);

        }
        [Fact]
        private void Task_UpdateTaskDescription()
        {
            Task task = new Task();
            task.Description = "Test Description";
            string getDescription = task.Description;
            getDescription.ShouldBe("Test Description");
        }
        [Fact]
        private void CreateNewList()
        {
            ToDoList testList = new ToDoList();
            testList.Tasks.Count.ShouldBe(0);
        }

        [Fact]
        private void List_AddTaskToList()
        {
            ToDoList testList = new ToDoList();
            testList.AddTaskToList("This is a test");
            testList.Tasks[0].Description.ShouldBe("This is a test");
        }

        private void List_CompleteTask()
        {
            ToDoList testList = new ToDoList();
            testList.AddTaskToList("List_CompleteTask");
            testList.MarkTaskAsDone(0);
            testList.Tasks[0].Description.ShouldBe("List_CompleteTask");
            testList.Tasks[0].IsDone.ShouldBe(true);
        }

        [Fact]
        private void List_UncompletedTask()
        {
            ToDoList testList = new ToDoList();
            testList.AddTaskToList("List_UncompletedTask");
            testList.MarkTaskAsNotCompleted(0);
            testList.Tasks[0].Description.ShouldBe("List_UncompletedTask");
            testList.Tasks[0].IsDone.ShouldBe(false);
        }


        [Fact]
        private void List_SaveList()
        {
            ToDoList testList = new ToDoList();
            testList.AddTaskToList("List_SaveList One");
            testList.MarkTaskAsDone(0);
            testList.AddTaskToList("List_SaveList Two");
            testList.MarkTaskAsNotCompleted(1);
            testList.AddTaskToList("List_SaveList Three");
            testList.MarkTaskAsDone(2);

            ListIO listIO = new ListIO();
            listIO.SaveTaskList(testList.Tasks);

        }

        [Fact]
        private void List_LoadList()
        {
            // This test is fragile as it relies on having the list from List_SaveList already
            // run.  Better would be for it to pull in a separate file, but that would 
            // require modifying ListIOFunctions.LoadTaskList to suppoort having a filename
            ToDoList testList = new ToDoList();
            ListIO listIO = new ListIO();
            listIO.LoadTaskList(testList);
            testList.Tasks[0].Description.ShouldBe("List_SaveList One");
            testList.Tasks[0].IsDone.ShouldBe(true);
            testList.Tasks[1].Description.ShouldBe("List_SaveList Two");
            testList.Tasks[1].IsDone.ShouldBe(false);
            testList.Tasks[2].Description.ShouldBe("List_SaveList Three");
            testList.Tasks[2].IsDone.ShouldBe(true);
        }

    }
}
