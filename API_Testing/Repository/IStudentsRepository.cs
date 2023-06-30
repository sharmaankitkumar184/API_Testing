using API_Testing.Models;

namespace API_Testing.Repository
{
    public interface IStudentsRepository
    {
        IEnumerable<Students> GetAllStudents();
        Students? GetStudents(int Id);
    }
}
