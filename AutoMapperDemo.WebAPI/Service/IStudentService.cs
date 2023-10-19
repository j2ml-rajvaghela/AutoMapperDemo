using AutoMapperDemo.WebAPI.Model;

namespace AutoMapperDemo.WebAPI.Service
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        void SaveChanges();
    }
}
