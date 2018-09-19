// <copyright file="Person.cs" company="Grasshoppers">
//     Copyright (c) Grasshoppers. All rights reserved.
// </copyright>
namespace Person_Teacher_Student
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Console;

    /// <summary>
    /// This class have two options
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// This member defines girls
        /// </summary>
        female,

        /// <summary>
        /// This member defines boys
        /// </summary>
        male
    }

    /// <summary>
    /// This class is abstract
    /// </summary>
    public class Person : IComparable<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class
        /// </summary>
        public Person()
        {
            this.Name = "Alex";
            this.Surname = "Fomin";
            this.Age = 20;
            Gender = Gender.male;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class
        /// </summary>
        /// <param name="name">
        /// Have information about name
        /// </param>
        /// <param name="surname">
        /// Have information about surname
        /// </param>
        /// <param name="age">
        /// Have information about age
        /// </param>
        /// <param name="genderr">
        /// Have information about gender
        /// </param>
        public Person(string name, string surname, int age, Gender genderr)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            Gender = genderr;
        }

        /// <summary>
        /// Gets or sets name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// This method is return 
        /// </summary>
        /// <returns>
        /// Different data properties
        /// </returns>
        public override string ToString()
        {
            return $"Name: {Name} {Surname} | Age:{Age} | Gender: {Gender}";
        }

        /// <summary>
        /// this function is used to print data
        /// </summary>
        public virtual void Print()
        { 
            WriteLine(this.ToString());
        }

        /// <summary>
        /// this function is used to input data
        /// </summary>
        public virtual void Input()
        {
            WriteLine("Input name:");
            string inpName = Convert.ToString(ReadLine());
            this.Name = inpName;
            WriteLine("Input Surname:");
            string inpSurname = Convert.ToString(ReadLine());
            this.Surname = inpSurname;
            WriteLine("Input Age: ");
            int inpAge = Convert.ToInt32(ReadLine());
            this.Age = inpAge;
            WriteLine("Input Gender: ");
            string inpGender = ReadLine();
            Gender = (Gender)Convert.ToInt32(inpGender);
            this.Print();
        }

        /// <summary>
        /// this method compare objects by their features
        /// </summary>
        /// <returns>
        /// False or surname
        /// </returns>
        /// <param name="obj">
        /// Object and person
        /// </param>
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
        /// this function is used to do something
        /// </summary>
        /// <returns>
        /// Surname with gethashcode
        /// </returns>
        public override int GetHashCode()
        {
            return this.Surname.GetHashCode();
        }

        /// <summary>
        /// this function is used to compare data and returns value
        /// </summary>
        /// <returns>
        /// value of 1 or -1
        /// </returns>
        /// <param name="other">
        /// other as Person
        /// </param>
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
