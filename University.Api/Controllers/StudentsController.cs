using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniversityManagementUseRepositoryUnitOfWork.Domain;
using UniversityManagementUseRepositoryUnitOfWork.Entity;

namespace UniversityManagementUseRepositoryUnitOfWork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<Students>
        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            return await _unitOfWork.Students.GetAll();
        }

        [HttpGet]
        public IEnumerable<Student> GetByName([FromQuery] string Name)
        {
            return _unitOfWork.Students.GetStudentsByName(Name);
        }

        // GET api/<Students>/5
        [HttpGet("{id}")]
        public async Task<Student> Get(int id)
        {
            return await _unitOfWork.Students.Get(id);
        }

        // POST api/<Students>
        [HttpPost]
        public IActionResult Post()
        {
            var Student = new Student
            {
                Id = 1,
              Name="Rubel",
              Email="rubelislam301@gmail.com",
              Mobile="+8801717254072"
            };

            var Subject = new Subject
            {
                Id=1,
                Name="C#",
               Code="200",
               Description="This is C# Subject"
            };

            _unitOfWork.Students.Add(Student);
            _unitOfWork.Subjects.Add(Subject);
            _unitOfWork.Complete();
            return Ok();
        }

        // PUT api/<Students>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Students>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
