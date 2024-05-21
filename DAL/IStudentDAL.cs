using DTO.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IStudentDAL
    {
        List<StudentDTO> GetAllStudents();
    }
}
