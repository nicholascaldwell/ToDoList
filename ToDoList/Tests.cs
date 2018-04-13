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
        public void GetNewTask()
        {
            Task task = new Task
            {
                Description = "Test"
            };
            String getDescription = task.Description;
            getDescription.ShouldBe("Test");
        }

        [Fact]
        public void Task_Description_default_is_null()
        {
            Task task = new Task();
            String getDescription = task.Description;
            getDescription.ShouldBe(null);
        }

        [Fact]
        public void Task_IsDone_Default_is_false()
        {
            Task task = new Task();

            // Verify default value is false
            task.IsDone.ShouldBe(false);

        }
        [Fact]
        public void Task_Description_is_settable()
        {
            Task task = new Task();
            task.Description = "Test Description";
            String getDescription = task.Description;
            getDescription.ShouldBe("Test Description");
        }
        [Fact]
        public void Mark_task_done()
        {
            Task task = new Task();
            task.IsDone = true;
        }
    }
}
