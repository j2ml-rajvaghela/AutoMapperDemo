using AutoMapperDemo.WebAPI.Model;

namespace AutoMapperDemo.WebAPI.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(long id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        void SaveChanges();
    }
}
