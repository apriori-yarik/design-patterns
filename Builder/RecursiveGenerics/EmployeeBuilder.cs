using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveGenerics
{
    public class EmployeeBuilder : PersonBuilder<EmployeeBuilder>
    {
        public EmployeeBuilder WorksAt(string worksAt)
        {
            this.person.WorksAt = worksAt;
            return this;
        }

        public EmployeeBuilder Salary(int salary)
        {
            this.person.Salary = salary;
            return this;
        }
    }
}
