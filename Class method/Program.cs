using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(50, "Dineo", 17);
            Student student2 = new Student(67, "Dinah", 10);

            Console.WriteLine(student1.IsObesse());
            Console.WriteLine(student2.IsObesse());

            Console.Read();
        }
    }
}
