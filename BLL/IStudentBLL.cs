using DTO.Models;
using DTO.Responses;
using System.Collections.Generic;

namespace BLL
{
    public interface IStudentBLL
    {
        List<StudentDTO> GetAllStudents();
        MessageDTO DeleteStudent(string studentId);
    }
}
