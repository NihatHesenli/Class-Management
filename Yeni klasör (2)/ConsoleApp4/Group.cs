using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Group
    {
        Student[] students = new Student[0];

        public string GroupNo { get; set; }
        public int StudentLimit {
            get
            {
                return _StudentLimit;
            }
            set
            {
                if (value > 5 && value < 18)
                {
                    _StudentLimit = value;
                }


            }  }
            private int _StudentLimit;
        public Group (int studentLimit)
        {
            this._StudentLimit = studentLimit;
        }

        public bool CheckGroupNo(string groupNo)
        {

            return groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]); char.IsDigit(groupNo[3]);
        }
        public void AddStudent (Student student)
        {

            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1 ] = student;

            }
        }
        public void GetAllStudents(string groupNo)
        {
           

        }

        
            



                


                 
        
        
        


            
        
         
          


        



           

            
           

            
    }
}
