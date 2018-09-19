namespace Person_Teacher_Student
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents class Teacher
    /// </summary>
    class Teacher : Person, IEnumerable
    {
        /// <summary>
        /// List of students
        /// </summary>
        public List<Student> Group = new List<Student>();

        // <summary>
        /// Initializes a new instance of the <see cref="T:Person_Teacher_Student"/> class
        /// </summary>
        public Teacher() : base()
        {
            this.Salary = 15000;
            this.Subject = "Programming";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Person_Teacher_Student"/> class with specified name, surname, age, genderr, salary, subject
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="genderr"></param>
        /// <param name="salary"></param>
        /// <param name="subject"></param>
        public Teacher(string name, string surname, int age, Gender genderr, int salary, string subject) : base(name, surname, age, genderr)
        {
            this.Group.Capacity = 100;
            this.Group.Add(new Student("Dima", "Mysluk", 21, Gender.male, 4, 56547878, "Sergiy"));
            this.Salary = salary;
            this.Subject = subject;
        }

        /// <summary>
        /// Gets variable salary
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Gets variable subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Returns a string that represents the current instance
        /// </summary>
        /// <returns><see cref="T:System.String"/></returns>
        public override string ToString()
        {
            Console.WriteLine("______________________________________________________________________________________________________");
            return $"Name: {Name} {Surname} | Age:{Age} | Gender: {Genderr} | Salary: {Salary} | Subject: {Subject}";
        }

        /// <summary>
        /// Print all group
        /// </summary>
        public void PrintGroup()
        {
            foreach (var a in this.Group)
            {
                a.Print();
            }
        }

        /// <summary>
        /// Input information about student or teacher
        /// </summary>
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

        /// <summary>
        /// iterates through a collection
        /// </summary>
        /// <returns>enumerator that iterates through a collection</returns>
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)this.Group).GetEnumerator();
        }
    }
}
