using DTO.Models;

namespace BLL
{
    public interface IStudentBLL
    {
        public List<StudentDTO> GetAllStudents();
    }
}
