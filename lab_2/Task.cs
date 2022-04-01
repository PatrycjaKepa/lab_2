using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Task
    {
        private String name;
        private TaskStatus status;

        public String Name { get { return name; } }
        public TaskStatus Status { get { return status; } set { this.status = value; } }

        public Task(String name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return  this.Name + " " + "[" + this.Status + "]";
        }

        public bool Equals (Task? other)
        {
            if (this.Name == other.Name)
            {
                return true;
            }
            return false;
        }
    }
}
