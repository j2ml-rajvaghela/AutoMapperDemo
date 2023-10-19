using AutoMapperDemo.WebAPI.Model;
using AutoMapperDemo.WebAPI.Repositories;

namespace AutoMapperDemo.WebAPI.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }


        public Student GetStudentById(long id)
        {
            return _studentRepository.GetStudentById(id);
        }


        public void AddStudent(Student student)
        {
           _studentRepository.AddStudent(student);
        }


        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }


        public void DeleteStudent(Student student)
        {
           _studentRepository.DeleteStudent(student);
        }


        public void SaveChanges()
        {
            _studentRepository.SaveChanges();
        }

    }
}
