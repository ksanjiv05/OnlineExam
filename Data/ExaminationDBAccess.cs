using Exmination.Models;
using Exmination.Models.Account;
using Exmination.Models.Services;
using Exmination.Models.Student;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data
{
    public class ExaminationDBAccess : DbContext
    {

        public ExaminationDBAccess(DbContextOptions<ExaminationDBAccess> options) : base(options)
        {

        }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Registation> Registations { get; set; }
        public DbSet<EximinationCenter> EximinationCenters { get; set; }
        public DbSet<StudentAdmitCard> StudentAdmitCards { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
        }
    }
}
