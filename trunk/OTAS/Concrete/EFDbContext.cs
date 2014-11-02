using OTAS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OTAS.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
        public DbSet<SubjectModel> Subjects { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<ValidatorModel> Validator { get; set; }
        public DbSet<CombinationModel> Combination { get; set; }
        public DbSet<ElectiveModel> Electives { get; set; }
        public DbSet<RatingsModel> Ratings { get; set; }

    }
}