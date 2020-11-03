using System;
using Module3.Classes;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Michal";
            s1.Semester = 7;
            s1.SetBirthDate(new DateTime(1997, 7, 22));
            int studentAge = s1.GetAge();

            Console.WriteLine(s1.Name + " is " + studentAge + " years old");
            Console.WriteLine("Current semester: " + s1.Semester);
            s1.GoToNextSemester();
            Console.WriteLine("Current semester: " + s1.Semester);

            Professor p1 = new Professor();
            p1.Name = "Laura";
            p1.Salary = 1000;
            p1.IncrementSalary(25);
            p1.GenerateID();

            Console.WriteLine("Professor: " + p1.Name + " has a salary of " + p1.Salary);

            Person person = new Person();
            person.Name = "Peter";
            Console.WriteLine("Person name: " + person.Name);

            Person ps2 = new Student();
            ps2.Name = "Ana";

            if (ps2 is Student)
            {
                Student copyStudent = (Student)ps2;
                copyStudent.Semester = 7;
                Console.WriteLine(copyStudent.Name + "'s current semester is " + copyStudent.Semester);
            }
            else
                Console.WriteLine(ps2.Name + " is not a student");

            Person pf = new Professor();
            pf.Name = "David";

            Professor copyProf = person as Professor;

            if (copyProf != null)
            {
                copyProf.TeachingHours = 30;
                Console.WriteLine(copyProf.Name + "'s teaching hours: " + copyProf.TeachingHours);
            }
            else
                Console.WriteLine(person.Name + " is not a professor");


            Console.ReadKey();
        }
    }
}
