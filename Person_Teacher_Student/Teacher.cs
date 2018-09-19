using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Teacher_Student
{
    class Teacher : Person, IEnumerable
    {
         {
        public List<Student> Group = new List<Student>();

        public Teacher() : base()
        {
            this.Salary = 15000;
            this.Subject = "Programming";
        }

        public Teacher(string name, string surname, int age, Gender genderr, int salary, string subject) : base(name, surname, age, genderr)
        {
            this.Group.Capacity = 100;
            this.Group.Add(new Student("Dima", "Mysluk", 21, Gender.male, 4, 56547878, "Sergiy"));
            this.Salary = salary;
            this.Subject = subject;
        }

        public int Salary { get; set; }

        public string Subject { get; set; }

        public override string ToString()
        {
            Console.WriteLine("______________________________________________________________________________________________________");
            return $"Name: {Name} {Surname} | Age:{Age} | Gender: {Genderr} | Salary: {Salary} | Subject: {Subject}";
        }

        public void PrintGroup()
        {
            foreach (var a in this.Group)
            {
                a.Print();
            }
        }

        public override void Input()
        {
            Console.WriteLine("Input name:");
            string inpName = Convert.ToString(Console.ReadLine());
            this.Name = inpName;
            Console.WriteLine("Input Surname:");
            string inpSurname = Convert.ToString(Console.ReadLine());
            this.Surname = inpSurname;
            Console.WriteLine("Input Age: ");
            int inpAge = Convert.ToInt32(Console.ReadLine());
            this.Age = inpAge;
            Console.WriteLine("Input Gender (male - 1, female - 0): ");
            string inpGender = Console.ReadLine();
            this.Genderr = (Gender)Convert.ToInt32(inpGender);
            Console.WriteLine("Input Salary: ");
            int inpSalary = Convert.ToInt32(Console.ReadLine());
            this.Salary = inpSalary;
            Console.WriteLine("Input Subject: ");
            string inpSubject = Convert.ToString(Console.ReadLine());
            this.Subject = inpSubject;
            Console.WriteLine("Teacher which you created:");
            this.Print();
            Console.ReadKey();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)this.Group).GetEnumerator();
        }
    }
}
