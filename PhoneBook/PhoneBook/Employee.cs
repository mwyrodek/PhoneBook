using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Employee
    {
        public string Name { get; }
        public string SurName { get; }
        public int BadgeID { get; }
        public Departments Department { get; }
        public string InternalPhone { get; }

        public Employee(string name, string surName, int badgeId, Departments department, string internalPhone)
        {
            this.Name = name;
            this.SurName = surName;
            this.BadgeID = badgeId;
            this.Department = department;
            this.InternalPhone = internalPhone;
            PrintBasicInfo();
            PrintFullInfo();
        }

        public string PrintFullInfo()
        {
            string fullInfoAboutEmployee = Name + " " + SurName + " " + BadgeID.ToString() + " " + Department + " " + InternalPhone;
            return fullInfoAboutEmployee;
        }

        public string PrintBasicInfo()
        {
            string fullInfoAboutEmployee = Name + " " + Department;
            return fullInfoAboutEmployee;
        }
    }
}
