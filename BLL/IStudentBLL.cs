﻿using DTO.Models;
using System.Collections.Generic;

namespace BLL
{
    public interface IStudentBLL
    {
        List<StudentDTO> GetAllStudents();
    }
}
