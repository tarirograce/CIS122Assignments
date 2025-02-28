using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    class Employee
    {
        // class variables
        private string name = "n/a";
        private int salary = 75000;

        //getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // constructors 

        public Employee(string aName, int aSalary)
        {
            Name = aName;
            Salary = aSalary;
        }

        public override string ToString()
        {
            return $"Employee: {Name}, Salary ${Salary}";
        }
    }
}
