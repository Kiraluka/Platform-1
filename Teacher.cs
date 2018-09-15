using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_task1
{
    class Teacher:Person
    {
        public int Salery { get; set; }
        List<Student> studentss = new List<Student>();
        
        private int used;
        private Student[] students;
        private void checkMem()
        {
            Student[] s = new Student[students.Length];
            for (int i = 0; i < students.Length; ++i)
            {
                s[i] = students[i];
                students = s;
            }
        }
        Teacher(int salery):base("Olga","Mechnikova",Gender.female)
        {
            Salery = salery;
        }

         public override void print()
        {
            Console.WriteLine(ToString());
        }
    }
}
