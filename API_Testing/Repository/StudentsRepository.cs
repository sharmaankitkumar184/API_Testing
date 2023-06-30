using API_Testing.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace API_Testing.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        public StudentsRepository() {
        }
        private List<Students> studentData = new List<Students>() {
            new Students() { Id=1, Name = "Rohit", Course="Science",Age=23 },
            new Students() { Id = 2, Name = "Mohit", Course = "Arts", Age = 21 },
            new Students() { Id = 3, Name = "Sohan", Course = "Commerce", Age = 26 },
        };

        public IEnumerable<Students> GetAllStudents()
        {
            return studentData.ToList();
        }

        public Students? GetStudents(int Id)
        {
            var student = studentData.FirstOrDefault(mp=>mp.Id==Id);
            if (student == null)
                return null;
            return student;
        }
    }
}
