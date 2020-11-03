using System;

namespace Module3.Classes
{
    public class Professor : Person
    {
        public string Department;

        public double Salary;

        public int TeachingHours;

        public Professor() : base(DateTime.Parse("1982/07/11"))
        {
            Salary = 0;
            Department = "IT";

            Console.WriteLine("New professor");
        }

        public void IncrementSalary(double percentage)
        {
            Salary *= (1 + percentage / 100);
        }
    }
}
