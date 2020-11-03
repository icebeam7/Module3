using System;
using System.Collections.Generic;
using System.Text;

namespace Module3.Classes
{
    public  class Student : Person
    {
        public int Semester;

        public string Career;

        public string Advisor;

        public Student() : base(DateTime.Now)
        {
            Console.WriteLine("New student");
        }

        public Student(DateTime date) : base(date)
        {
            Console.WriteLine("New student");
        }

        public void GoToNextSemester()
        {
            Semester++;
        }

        public void SetBirthDate(DateTime date)
        {
            BirthDate = date;
        }

        public sealed override int GetAge()
        {
            return 20;
        }


    }
}
