using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_task1
{
    class Student:Person
    {
        public int DocumentNumber { get; set; }
        List<int> marks;
        public override string ToString()
        {
            return string.Format("Student -> Name: {0}, Surname: {1}, Number: {2}", this.Name, this.Surname, this.DocumentNumber);
        }
        public override void print()
        {
            // return string.Format($"Name:{Name} {Surname}\nGender:{gender}\nDocument number:{DocumentNumber} ");
            Console.WriteLine(ToString());
        }

        Student():base("Alex","Fomin",Gender.male)
        {
            
        }
    }
}
