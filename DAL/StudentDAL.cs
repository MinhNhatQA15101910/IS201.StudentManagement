using DTO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL : IStudentDAL
    {
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
