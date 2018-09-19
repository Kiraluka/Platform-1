namespace Person_Teacher_Student
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents listing of genders
    /// </summary>
    public enum Gender
    {
        female, male
    }

    /// <summary>
    /// Represents person
    /// </summary>
    class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Person_Teacher_Student"/> class
        /// </summary>
        public Person()
        {
            this.Name = "Alex";
            this.Surname = "Fomin";
            this.Age = 20;
            this.Genderr = Gender.male;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Person_Teacher_Student"/> class with specified name, surname, age, genderr
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="genderr"></param>
        public Person(string name, string surname, int age, Gender genderr)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Genderr = genderr;
        }

        /// <summary>
        /// Gets variable name
        /// </summary>
        /// <value>The name</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets variable surname
        /// </summary>
        /// <value>The surname</value>
        public string Surname { get; set; }

        /// <summary>
        /// Gets variable age
        /// </summary>
        /// <value>The age</value>
        public int Age { get; set; }

        /// <summary>
        /// Gets variable genderr
        /// </summary>
        /// <value>The genderr</value>
        public Gender Genderr { get; set; }

        /// <summary>
        /// Returns a string that represents the current instance
        /// </summary>
        /// <returns><see cref="T:System.String"/></returns>
        public override string ToString()
        {
            return $"Name: {Name} {Surname} | Age:{Age} | Gender: {Genderr}";
        }

        /// <summary>
        /// Print
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Input information about student or teacher
        /// </summary>
        public virtual void Input()
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
            Console.WriteLine("Input Gender: ");
            string inpGender = Console.ReadLine();
            this.Genderr = (Gender)Convert.ToInt32(inpGender);
            this.Print();
        }

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="T:Person_Teacher_Student"/>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true or false</returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person p = (Person)obj;
                return this.Surname == p.Surname;
            }
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="T:Person_Teacher_Student"/> object 
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table</returns>
        public override int GetHashCode()
        {
            return this.Surname.GetHashCode();
        }

        /// <summary>
        /// Compares instance
        /// </summary>
        /// <param name="other"></param>
        /// <returns>1 0 -1</returns>
        public int CompareTo(Person other)
        {
            Person person = other as Person;
            if (other.Age > this.Age)
            {
                return 1;
            }
            else if (other.Age < this.Age)
            {
                return -1;
            }

            return 0;
        }
    }
}
