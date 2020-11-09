using Department.Microservices.Context;
using Department.Microservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department.Microservices.Repositories.Data
{
    public class DepartmentRepository : GeneralRepository<Departments, MyContext>
    {
        public DepartmentRepository(MyContext myContext) : base(myContext)
        {
        }
    }
}
