namespace PhoneBookTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using PhoneBook;

    [TestFixture]
    public class PhoneBookTests
    {
        [Test]
        public void Employee_Check_All_Info()
        {
            var employee = new Employee("Emma", "Mazuni", 123, Departments.Koszalin, "00-4567");
            Assert.Multiple(() =>
            {
                Assert.That(employee.Name, Is.EqualTo("Emma"));
                Assert.That(employee.SurName, Is.EqualTo("Mazuni"));
                Assert.That(employee.BadgeID, Is.EqualTo(123));
                Assert.That(employee.Department, Is.EqualTo(Departments.Koszalin));
                Assert.That(employee.InternalPhone, Is.EqualTo("00-4567"));
            });           
        }

        [Test]
        public void Employee_Check_Basic_Print()
        {
            var employee = new Employee("Emma", "Mazuni", 123, Departments.Koszalin, "00-4567");
            var employeeNameAndDepartment = employee.Name + " " + employee.Department;
            Assert.That(employee.PrintBasicInfo(), Is.EqualTo(employeeNameAndDepartment));
        }

        [Test]
        public void Employee_Check_Full_Print()
        {
            var employee = new Employee("Emma", "Mazuni", 123, Departments.Koszalin, "00-4567");
            var employeeFullData = employee.Name + " " + employee.SurName + " " + employee.BadgeID.ToString() + " " + employee.Department + " " + employee.InternalPhone;
            Assert.That(employee.PrintFullInfo(), Is.EqualTo(employeeFullData));
        }
    }
}
