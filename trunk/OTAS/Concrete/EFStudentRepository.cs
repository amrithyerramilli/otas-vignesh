using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OTAS.Abstract;
using OTAS.Models;

namespace OTAS.Concrete
{
    public class EFStudentRepository 
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<StudentModel> GetAllStudents
        {
            get { return context.Students; }
        }
    }
}