using DAL;
using DTO.Models;
using System.Collections.Generic;

namespace BLL
{
    public class StudentBLL : IStudentBLL
    {
        private readonly IStudentDAL _studentDAL = new StudentDAL();

        public List<StudentDTO> GetAllStudents()
        {
            return _studentDAL.GetAllStudents();
        }
    }
}
