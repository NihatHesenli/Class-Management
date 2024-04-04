using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; },
        public double Point { get; set; }

       public Student(int id, string fullName , double point)
        {
            id = id;
            FullName = fullName;
            Point = point;


        }
        public void ShowFullInfo()
        {
            Console.WriteLine($"Fullname:{FullName} , Point:{Point}");

        }
    }
}
