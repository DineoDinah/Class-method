using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_method
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
            this.weight=aWeight;
            this.name=aName;
            this.age=aAge;
        }
        public bool IsObesse()
        {
            if (weight > 60)
            {
                return true;
            }
            else return false;
        }
    }
}
