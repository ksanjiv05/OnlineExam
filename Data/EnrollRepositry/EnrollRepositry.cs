using Exmination.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.EnrollRepositry
{
    public class EnrollRepositry : IEnrollRepositry
    {
        private readonly ExaminationDBAccess repo;

        public EnrollRepositry(ExaminationDBAccess repo)
        {
            this.repo = repo;
        }
        public bool Add(Enrollment enrollment)
        {
            try
            {
                repo.Enrollments.Add(enrollment);
                repo.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public IEnumerable<Enrollment> GetEnrollment()
        {
            throw new NotImplementedException();
        }

        public Enrollment GetEnrollmentById()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
