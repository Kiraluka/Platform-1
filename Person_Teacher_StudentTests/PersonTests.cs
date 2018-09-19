using Microsoft.VisualStudio.TestTools.UnitTesting;
using Person_Teacher_Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Teacher_Student.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void PersonAttributesTest()
        {
            Person person = new Person();
            Assert.AreEqual(person.Name, "Alex");
            Assert.AreEqual(person.Surname, "Fomin");
            Assert.AreEqual(person.Age, 20);
            Assert.AreEqual(person.Genderr, Gender.male);
        }
        [TestMethod()]
        public void PersonConstructorTest()
        {
            Person person = new Person("Aleksey", "Kravchuk", 19, Gender.female);
            Assert.AreEqual(person.Name, "Aleksey");
            Assert.AreEqual(person.Surname, "Kravchuk");
            Assert.AreEqual(person.Age, 19);
            Assert.AreEqual(person.Genderr, Gender.female);
        }
        [TestMethod()]
        public void PersonEqualsTest()
        {
            Person person1 = new Person();
            Person person2 = new Person("Alex", "Fomin", 20, Gender.male);

            if (person1.Equals(10) || !person1.Equals(person2))
            {
                Assert.Fail();
            }
            return;
        }
        [TestMethod()]
        public void PersonCompareToTest()
        {
            Person person1 = new Person();
            Person person2 = new Person("Alex", "Fomin", 20, Gender.male);
            Person person3 = new Person("Oleg", "Petryk", 19, Gender.male);

            if (person1.CompareTo(person2) != 0 || person1.CompareTo(person3) != -1)
            {
                Assert.Fail();
            }
        }
    }
}