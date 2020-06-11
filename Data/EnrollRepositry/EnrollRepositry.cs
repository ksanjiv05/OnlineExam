using Exmination.Data.CenterRepositry;
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
        private readonly ICernterRepositry cernterRepositry;

        public EnrollRepositry(ExaminationDBAccess repo,ICernterRepositry cernterRepositry)
        {
            this.repo = repo;
            this.cernterRepositry = cernterRepositry;
        }
        public bool Add(Enrollment enrollment)
        {
            try
            {
                if (repo.EximinationCenters.FirstOrDefault(e => e.Code == enrollment.ExameCenter).SeatAvailable <= 0)
                    return false;
                cernterRepositry.SeatUpdate(enrollment.ExameCenter);
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

        public Enrollment GetEnrollmentById(string registration_num)
        {
            try
            {
               return  repo.Enrollments.FirstOrDefault(e => e.Registration_number == registration_num);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
