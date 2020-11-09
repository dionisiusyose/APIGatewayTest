using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Department.Microservices.Base;
using Department.Microservices.Models;
using Department.Microservices.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Department.Microservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseController<Departments, DepartmentRepository>
    {
        public DepartmentsController(DepartmentRepository repository) : base(repository)
        {
        }
    }
}
