using DTO.Models;
using DTO.Responses;
using System.Collections.Generic;

namespace DAL
{
    public interface IStudentDAL
    {
        List<StudentDTO> GetAllStudents();
        MessageDTO DeleteStudent(string studentId);
    }
}
