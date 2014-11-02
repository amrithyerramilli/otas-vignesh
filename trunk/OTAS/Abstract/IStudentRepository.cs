using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OTAS.Models;

namespace OTAS.Abstract
{
    public interface IStudentRepository
    {
        IEnumerable<StudentModel> GetAllStudents();
        //StudentModel GetStudentByUSN(string usn);
        //StudentModel Add(StudentModel student);
        //bool Update(string usn, StudentModel student);
        //bool Delete(string usn);
    }

}