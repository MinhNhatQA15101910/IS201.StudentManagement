using DAL;
using DTO.Models;
using DTO.Responses;
using System.Collections.Generic;

namespace BLL
{
    public class StudentBLL : IStudentBLL
    {
        private readonly IStudentDAL _studentDAL = new StudentDAL();

        public MessageDTO DeleteStudent(string studentId)
        {
            return _studentDAL.DeleteStudent(studentId);
        }

        public List<StudentDTO> GetAllStudents()
        {
            return _studentDAL.GetAllStudents();
        }
    }
}
