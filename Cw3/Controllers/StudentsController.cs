using Cw3.Models;
using Cw3.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Cw3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
          
            if(orderBy == "lastname")
            {
                return Ok(_dbService.GetStudents().OrderBy(s => s.LastName));
            }


            return Ok(_dbService.GetStudents());

           // return $"Jan, Anna, Krzysztof sortowanie={orderBy}";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if(id == 1)
            {
                return Ok("Jan");
            }
            return NotFound("Student was not found");
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1,200000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]

        public IActionResult put(int id)            
        {
            return Ok("Zaktualizowano " + id);
        }


        [HttpDelete("{id}")]

        public IActionResult delete(int id)
        {
            return Ok("Usunieto " + id);
        }
    }
}
