using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Person
    {
        protected string name;
        protected int age;

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person? other)
        {
            if (this.Name == other.Name && this.Age == other.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "person" + this.Name + this.Age;
        }  
    }
}
