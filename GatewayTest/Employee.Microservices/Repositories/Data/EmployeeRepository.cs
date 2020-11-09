using Employee.Microservices.Context;
using Employee.Microservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Microservices.Repositories.Data
{
    public class EmployeeRepository : GeneralRepository<Employees, MyContext>
    {
        public EmployeeRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
