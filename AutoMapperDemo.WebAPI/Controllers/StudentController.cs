using AutoMapper;
using AutoMapperDemo.WebAPI.Dto;
using AutoMapperDemo.WebAPI.Model;
using AutoMapperDemo.WebAPI.Repositories;
using AutoMapperDemo.WebAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.WebAPI.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper) 
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public IActionResult GetAllStudents() 
        {
            var students = _studentService.GetAllStudents();
            //var studentDtos = _mapper.Map<IEnumerable<StudentDto>, IEnumerable<Student>> (students);
            return Ok(students);
        }

        [HttpPost("create")]
        public IActionResult CreateStudent(StudentDto studentDto) 
        {
            var student = _mapper.Map<StudentDto, Student>(studentDto);
            _studentService.AddStudent(student);
            _studentService.SaveChanges();

            ResponseModel response = new ResponseModel();
            response.Success = true;
            response.Message = "Student created successfully.";
            return Ok(response);
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateStudent(long id, StudentDto studentDto)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }

            _mapper.Map(studentDto, student);
            _studentService.UpdateStudent(student);
            _studentService.SaveChanges();

            ResponseModel response = new ResponseModel();
            response.Success = true;
            response.Message = "Student updated successfully.";
            return Ok(response);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetStudentById([FromRoute(Name = "id")] long id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }

            var studentDto = _mapper.Map<Student, StudentDto>(student);
            return Ok(studentDto);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteStudent([FromRoute(Name = "id")] long id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }

            _studentService.DeleteStudent(student);
            _studentService.SaveChanges();

            ResponseModel response = new ResponseModel();
            response.Success = true;
            response.Message = "Student deleted successfully.";
            return Ok(response);
        }

    }
}
