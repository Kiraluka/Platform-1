namespace Person_Teacher_Student
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateObj();

            Student student = new Student();

            Student student1 = new Student("Vova", "Berkela", 21, Gender.male, 3, 4555656, "Bogdan");

            Student student2 = new Student("Bodya", "Shomko", 20, Gender.male, 3, 6544545, "Misha");

            Student[] groupp = new Student[] { student, student1 };

            for (int i = 0; i < groupp.Length; ++i)
            {
                Console.WriteLine(groupp[i]);
            }

            Console.WriteLine("______________________________ CLONE ______________________________");

            Student[] coppy = (Student[])groupp.Clone();

            for (int i = 0; i < coppy.Length; ++i)
            {
                Console.WriteLine(coppy[i]);
            }

            Console.ReadKey();

            Console.WriteLine("______________________________ Equals by Surname: ______________________________");

            Person person = new Person("Vakyz", "Berkela", 19, Gender.female);

            person.Print();

            Person p1 = new Person("Ivan", "Makarchuk", 19, Gender.male);

            Person p2 = new Person("Valentina", "Romanchuk", 20, Gender.female);

            p1.Print();

            p2.Print();

            bool b1 = person.Equals(p1);

            bool b2 = person.Equals(p2);

            Console.WriteLine($"Equals first with second: {b1}");

            Console.WriteLine($"Equals first with third: {b2}");

            Console.ReadKey();

            Console.WriteLine("______________________________ Read from file ______________________________");

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Bogdan/source/repos/Person_Teacher_Student/Person_Teacher_Student/Persons.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

            Console.WriteLine("______________________________ List of students ______________________________");

            Teacher teacher = new Teacher("Ivan", "Kochin", 25, Gender.male, 3500, "Programming");

            teacher.Group.Add(student);

            teacher.Group.Add(student1);

            foreach (var a in teacher.Group)
            {
                a.Print();
            }

            Console.ReadKey();

            teacher.Group.Add(student2);

            Teacher teacher1 = new Teacher("Bogdan", "Shomko", 35, Gender.male, 8500, "TIMC");

            Console.WriteLine("______________________________ Compare obj by Age ______________________________");

            teacher.Group.Sort();

            foreach (var a in teacher.Group)
            {
                a.Print();
            }

            Console.ReadKey();

            Console.WriteLine("<<<______________________________ Teacher ______________________________>>>");

            teacher.Print();

            Console.WriteLine("<<<______________________________ Teacher's Students ______________________________>>>");

            teacher.PrintGroup();

            Console.ReadKey();

            Console.WriteLine("__________________________ Wild Boars ______________________________________");

            List<Person> faculty = new List<Person>();

            faculty.Add(student);
            faculty.Add(student1);
            faculty.Add(student2);
            faculty.Add(teacher);
            faculty.Add(teacher1);
            foreach (var a in faculty)
            {
                a.Print();
            }

            var buffer = new StringBuilder();
            buffer.AppendLine("#key");
            faculty.ForEach(person_item => buffer.AppendLine(person_item.ToString()));
            File.WriteAllText("persons.txt", buffer.ToString());
            Console.ReadKey();
            int s = 0;
            int t = 0;
            foreach (var a in faculty)
            {
                if (a.Age >= 25)
                {
                    ++t;
                }
                else
                {
                    ++s;
                }
            }

            Console.WriteLine($"Number of Teachers: {t}\nNumber of Students: {s}");
            Console.ReadKey();

            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectedTeams = from item_t in teams
                                where item_t.ToUpper().StartsWith("Б")
                                orderby item_t
                                select item_t;

            foreach (string item_s in selectedTeams)
            {
                Console.WriteLine(item_s);
            }

            Console.ReadKey();
            var selected_person = from kolya in faculty
                                  where kolya.Age == 20
                                  select kolya;
            foreach (var a in selected_person)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }

        private static void CreateObj()
        {
            Console.WriteLine("Input 'T' or 't' if you want to create 'Teacher' and input 'S' or 's' if you want to create 'Student': ");
            string userChoise = Console.ReadLine();
            switch (userChoise)
            {
                case "T":
                    Teacher teacher1 = new Teacher();
                    teacher1.Input();
                    break;
                case "t":
                    Teacher teacher2 = new Teacher();
                    teacher2.Input();
                    break;
                case "S":
                    Student student1 = new Student();
                    student1.Input();
                    break;
                case "s":
                    Student student2 = new Student();
                    student2.Input();
                    break;
                default:
                    Console.WriteLine("Incorrect letter");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
