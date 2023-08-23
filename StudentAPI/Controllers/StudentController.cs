using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Repository;
namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // inject IStudentRepository with constructor and all methods
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
            return Ok("Student Added");
        }
        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
            return Ok("Student Updated");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
            return Ok("Student Deleted");
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            return Ok(student);
        }
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = _studentRepository.GetAllStudents();
            return Ok(students);
        }
    }
}
