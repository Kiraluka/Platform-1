namespace Person_Teacher_Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents class Student
    /// </summary>
    class Student : Person
    {
        /// <summary>
        /// Instance Teacher
        /// </summary>
        public Teacher Curator = new Teacher();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Person_Teacher_Student"/> class
        /// </summary>
        public Student() : base()
        {
            this.Course = 5;
            this.NumberOfDocument = 20000001;
            this.Curator.Name = "AAA";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Person_Teacher_Student"/> class with specified name, surname, age, genderr, course, numberOfDocument, numberOfCurator
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="genderr"></param>
        /// <param name="course"></param>
        /// <param name="numberOfDokument"></param>
        /// <param name="nameOfCurator"></param>
        public Student(string name, string surname, int age, Gender genderr, int course, int numberOfDokument, string nameOfCurator) : base(name, surname, age, genderr)
        {
            this.Course = course;
            this.NumberOfDocument = numberOfDokument;
            this.Curator.Name = nameOfCurator;
        }

        /// <summary>
        /// Gets variable course
        /// </summary>
        /// <value>The course</value>
        public int Course { get; set; }

        /// <summary>
        /// Gets variable numberOfDocument
        /// </summary>
        /// <value>The numberOfDocument</value>
        public int NumberOfDocument { get; set; }

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
            Console.WriteLine("Input Course: ");
            int inpCourse = Convert.ToInt32(Console.ReadLine());
            this.Course = inpCourse;
            Console.WriteLine("Input Number of Gradebook: ");
            int inpNumberOfDocument = Convert.ToInt32(Console.ReadLine());
            this.NumberOfDocument = inpNumberOfDocument;
            Console.WriteLine("Input name of Curator: ");
            string inpCurator = Convert.ToString(Console.ReadLine());
            this.Curator.Name = inpCurator;
            Console.WriteLine("Student which you created:");
            this.Print();
            Console.ReadKey();
        }
    }
}
