using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Classroom
    {
        private String name;
        private Person[] persons;

        public String Name
        {
            get { return name; }
        }

        public Classroom(String name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }

        public override string ToString()
        {
            String Result = "Classroom: " + this.Name + "\n\n";
            foreach (Person person in this.persons)
            {
                Result += person + "\n";
            }

            return Result;
        }
    }
}
