using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Valya", "Romanchuk", Gender.female);
            person.print();
            //Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}
