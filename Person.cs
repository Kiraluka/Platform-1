using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_task1
{
    public enum Gender { male, female }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender gender { get; set; }
        public Person(string name, string surname, Gender ggender)
        {
            Name = name;
            Surname = surname;
            gender = ggender;
        }

        public override string ToString()
        {
            return string.Format($"Name:{Name} {Surname}\nGender:{gender} ");
        }
        public virtual void print()
        {
            Console.WriteLine(ToString());
        }
    }
}
