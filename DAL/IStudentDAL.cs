using DTO.Models;
using DTO.Responses;
using System.Collections.Generic;

namespace DAL
{
    public interface IStudentDAL
    {
        List<StudentDTO> GetAllStudents();
        StudentDTO GetStudent(string studentId);
        MessageDTO DeleteStudent(string studentId);
        MessageDTO AddStudent(StudentDTO student);
        MessageDTO UpdateStudent(StudentDTO student);
    }
}
