using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Student : Person
    {
        protected String group;
        protected List<Task> tasks = new List<Task>();

        public String Group
        {
            get { return group; }
        }

        public Student(string name, int age, String group) : base(name, age)
        {
            this.group = group;
        }

        public Student(string name, int age, String group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        public void AddTask(String taskName, TaskStatus taskStatus)
        {
            Task task = new Task(taskName, taskStatus);
            this.tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            this.tasks.Remove(this.tasks[index]);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            this.tasks[index].Status = taskStatus;
        }

        public string RenderTasks(String prefix = "\t" )
        {
            String result = "Tasks: \n";
            int index = 1;
            foreach(Task task in this.tasks)
            {
                result += prefix + index + ". " + task + "\n";
                index++;
            }
            return result;
        }

        public override string ToString()
        {
            return "Student " + this.Name + " " + "(" + this.Age + " y.o )\n" +
                "Group: " + this.Group + "\n" + this.RenderTasks();
        }

        public bool Equals(Student? other)
        {
            if (this.Name == other.Name && this.Age == other.Age && this.Group == other.Group)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool SequenceEqual(List<Task> a, List<Task>b)
        {
            return false;   
        }
    }
}
