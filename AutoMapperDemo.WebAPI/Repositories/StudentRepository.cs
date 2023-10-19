using AutoMapperDemo.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperDemo.WebAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _studentContext;

        public StudentRepository(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public IEnumerable<Student> GetAllStudents()
        {
           return _studentContext.Students.ToList();
        }

        public Student GetStudentById(long id)
        {
            return _studentContext.Students.FirstOrDefault(s => s.StudentId == id);
        }


        public void AddStudent(Student student)
        {
            _studentContext.Students.Add(student);
        }


        public void UpdateStudent(Student student)
        {
            _studentContext.Entry(student).State = EntityState.Modified;
        }


        public void DeleteStudent(Student student)
        {
            _studentContext.Students.Remove(student);
        }


        public void SaveChanges()
        {
            _studentContext.SaveChanges();
        }
    }
}
