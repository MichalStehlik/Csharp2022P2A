using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cst05object
{
    internal class Student
    {
        private string firstname = "Fred";
        private string lastname;
        private int grade = 1;
        private double averageMark = 3;

        public Student(string firstname, string lastname, int grade, double averageMark)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.grade = grade;
            this.averageMark = averageMark;
        }

        public Student()
        {
            lastname = "Vopička";
        }

        public string GetFirstname()
        {
            return this.firstname;
        }
        public int GetGrade()
        {
            return grade;
        }

        public int Advance()
        {
            if (grade < 4)
            {
                this.grade++;
            }     
            return this.grade;
        }

        public void SetGrade(int value)
        {
            if (value > 0 && value <= 4)
                this.grade = value;
        }
    }
}
