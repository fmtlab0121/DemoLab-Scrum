using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleProject.Models;
using MultipleProject.Models.Contracts;

namespace MultipleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private IRepositoryWrapper _repo;

        public DepartmentsController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Department>> GetAll()
        {
            return Ok(_repo.Departments.FindAll().ToList());
        }
    }
}