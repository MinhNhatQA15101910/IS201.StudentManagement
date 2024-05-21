using DTO.Models;
using DTO.Responses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL : IStudentDAL
    {
        public MessageDTO AddStudent(StudentDTO student)
        {
            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO students (student_id, full_name, date_of_birth, gender, major_name) VALUES (@StudentId, @FullName, @DateOfBirth, @Gender, @MajorName)", 
                    connection
                    );
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.Parameters.AddWithValue("@FullName", student.FullName);
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@MajorName", student.MajorName);

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
                            Message = "Thêm sinh viên thành công."
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
                SqlCommand command = new SqlCommand("SELECT * FROM students ORDER BY id DESC", connection);

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

        public StudentDTO GetStudent(string studentId)
        {
            StudentDTO student = null;

            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM students WHERE student_id = @StudentId", connection);
                command.Parameters.AddWithValue("@StudentId", studentId);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            student = new StudentDTO()
                            {
                                Id = reader.GetInt32(0),
                                StudentId = reader.GetString(1),
                                FullName = reader.GetString(2),
                                DateOfBirth = reader.GetDateTime(3),
                                Gender = reader.GetString(4),
                                MajorName = reader.GetString(5),
                            };
                            break;
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }

            return student;
        }

        public MessageDTO UpdateStudent(StudentDTO student)
        {
            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE students SET student_id = @StudentId, full_name = @FullName, date_of_birth = @DateOfBirth, gender = @Gender, major_name = @MajorName WHERE id = @Id",
                    connection
                    );
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.Parameters.AddWithValue("@FullName", student.FullName);
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@MajorName", student.MajorName);
                command.Parameters.AddWithValue("@Id", student.Id);

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
                            Message = "Cập nhật sinh viên thành công."
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
    }
}
