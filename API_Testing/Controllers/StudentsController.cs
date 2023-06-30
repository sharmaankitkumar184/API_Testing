using API_Testing.Models;
using API_Testing.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsRepository _students;

        public StudentsController(IStudentsRepository students)
        {
            _students = students;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Students>> Get()
        {
            try
            {
                return Ok(_students.GetAllStudents());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Students> GetProduct(int id)
        {
            try
            {
                var result = _students.GetStudents(id);

                if (result == null) return NotFound("Student data not available");

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }

        }
    }
}
