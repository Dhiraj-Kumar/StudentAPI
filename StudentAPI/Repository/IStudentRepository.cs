using StudentAPI.Models;

namespace StudentAPI.Repository
{
    public interface IStudentRepository
    {
        // add following methods: AddStudent, UpdateStudent, DeleteStudent, GetStudentById, GetAllStudents
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
        Student GetStudentById(int id);
        List<Student> GetAllStudents();
    }
}
