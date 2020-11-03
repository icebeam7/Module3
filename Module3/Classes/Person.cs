using System;
using System.Linq;

namespace Module3.Classes
{
    public class Person
    {
        private string ID;

        public string Name;

        protected DateTime BirthDate;

        public Person()
        {
            Console.WriteLine("New person");
        }

        public Person(DateTime date)
        {
            BirthDate = date;
        }

        public void GenerateID()
        {
            Random random = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            string result = new string(Enumerable.Repeat(characters, 5).Select(
                s => s[random.Next(s.Length)]).ToArray());

            Console.WriteLine(result);
            ID = result;
        }

        public virtual int GetAge()
        {
            DateTime today = DateTime.Now;
            TimeSpan difference = today.Subtract(BirthDate);
            double days = difference.TotalDays;

            int age = (int)(days / 365); // (int)(7.2) = 7
            return age;
        }

    }
}
