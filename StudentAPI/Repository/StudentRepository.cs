using StudentAPI.Models;
namespace StudentAPI.Repository
{
    public class StudentRepository:IStudentRepository
    {
        // Implement IStudentRepository interface and add methods with DataContext
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public int AddStudent(Student student)
        {
            _context.Students.Add(student);
            return _context.SaveChanges();
        }
        public int UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            return _context.SaveChanges();
        }
        public int DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            _context.Students.Remove(student);
            return _context.SaveChanges();
        }
        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
        public Student GetStudent(int id)
        {
            return _context.Students.Find(id);
        }
    }
}
