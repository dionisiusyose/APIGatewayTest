using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Microservices.Base;
using Employee.Microservices.Models;
using Employee.Microservices.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Microservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<Employees, EmployeeRepository>
    {
        public EmployeesController(EmployeeRepository repository) : base(repository)
        {
        }
    }
}
