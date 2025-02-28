using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    class Engineer : Employee
    {
        // additional variable/property 
        private string specialization = "n/a";

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        // constructor
        public Engineer(string aName, int aSalary, string aSpecialization)
            : base(aName, aSalary)
        {
            Specialization = aSpecialization;
        }
        
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary}, Specialization: {Specialization}";
        }

        
    }
}
