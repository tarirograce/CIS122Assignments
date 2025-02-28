using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    class Manager : Employee
    {
        // additional variable/property 
        private int numberofemployeesmanaged = 90;

        public int Numberofemployeesmanaged
        {
            get { return numberofemployeesmanaged; }
            set { numberofemployeesmanaged = value; }
        }

        // constructor
        public Manager(string aName, int aSalary, int aNumberofemployeesmanaged)
            : base(aName, aSalary)
        {
            Numberofemployeesmanaged = aNumberofemployeesmanaged;
        }

        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary}, Number of Employees managed: {Numberofemployeesmanaged}";
        }
    }
}
