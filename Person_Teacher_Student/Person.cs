namespace Person_Teacher_Student
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum Gender
    {
        female, male
    }

    class Person
    {
        public Person()
        {
            this.Name = "Alex";
            this.Surname = "Fomin";
            this.Age = 20;
            this.Genderr = Gender.male;
        }

        public Person(string name, string surname, int age, Gender genderr)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Genderr = genderr;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Gender Genderr { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} {Surname} | Age:{Age} | Gender: {Genderr}";
        }

        public virtual void Print()
        {
            Console.WriteLine(this.ToString());
        }

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

        public override int GetHashCode()
        {
            return this.Surname.GetHashCode();
        }

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
