using DTO.Models;
using DTO.Responses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL : IStudentDAL
    {
        public MessageDTO DeleteStudent(string studentId)
        {
            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM students WHERE student_id = @StudentId", connection);
                command.Parameters.AddWithValue("@StudentId", studentId);

                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        return new MessageDTO
                        {
                            StatusCode = 200,
                            Message = "Xóa sinh viên thành công."
                        };
                    }

                    return new MessageDTO
                    {
                        StatusCode = 500,
                        Message = "Đã có lỗi xảy ra."
                    };
                }
                catch (Exception ex)
                {
                    return new MessageDTO
                    {
                        StatusCode = 500,
                        Message = ex.Message,
                    };
                }
            }
        }

        public List<StudentDTO> GetAllStudents()
        {
            List<StudentDTO> students = new List<StudentDTO>();

            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM students", connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            students.Add(new StudentDTO()
                            {
                                Id = reader.GetInt32(0),
                                StudentId = reader.GetString(1),
                                FullName = reader.GetString(2),
                                DateOfBirth = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                MajorName = reader.GetString(5),
                            });
                        } 
                    }

                    connection.Close();
                } 
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }

            return students;
        }
    }
}
