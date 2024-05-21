using DAL;
using DTO.Models;
using DTO.Responses;
using System.Collections.Generic;

namespace BLL
{
    public class StudentBLL : IStudentBLL
    {
        private readonly IStudentDAL _studentDAL = new StudentDAL();

        public MessageDTO AddStudent(StudentDTO student)
        {
            if (student.StudentId.Equals(""))
            {
                return new MessageDTO
                {
                    StatusCode = 400,
                    Message = "MSSV không được để trống."
                };
            }

            if (student.FullName.Equals(""))
            {
                return new MessageDTO
                {
                    StatusCode = 400,
                    Message = "Tên sinh viên không được để trống."
                };
            }

            if (student.MajorName.Equals(""))
            {
                return new MessageDTO
                {
                    StatusCode = 400,
                    Message = "Tên ngành không được để trống."
                };
            }

            StudentDTO existingStudent = _studentDAL.GetStudent(student.StudentId);
            if (existingStudent != null)
            {
                return new MessageDTO
                {
                    StatusCode = 400,
                    Message = "Đã tồn tại sinh viên với mã sinh viên được nhập."
                };
            }

            return _studentDAL.AddStudent(student);
        }

        public MessageDTO DeleteStudent(string studentId)
        {
            return _studentDAL.DeleteStudent(studentId);
        }

        public List<StudentDTO> GetAllStudents()
        {
            return _studentDAL.GetAllStudents();
        }

        public MessageDTO UpdateStudent(StudentDTO student)
        {
            if (student.StudentId.Equals(""))
            {
                return new MessageDTO
                {
                    StatusCode = 400,
                    Message = "MSSV không được để trống."
                };
            }

            if (student.FullName.Equals(""))
            {
                return new MessageDTO
                {
                    StatusCode = 400,
                    Message = "Tên sinh viên không được để trống."
                };
            }

            if (student.MajorName.Equals(""))
            {
                return new MessageDTO
                {
                    StatusCode = 400,
                    Message = "Tên ngành không được để trống."
                };
            }

            StudentDTO existingStudent = _studentDAL.GetStudent(student.StudentId);
            if (existingStudent != null && existingStudent.Id != student.Id)
            {
                return new MessageDTO
                {
                    StatusCode = 400,
                    Message = "Đã tồn tại sinh viên với mã sinh viên được nhập."
                };
            }

            return _studentDAL.UpdateStudent(student);
        }
    }
}
