using Exmination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.CenterRepositry
{
    public class CernterRepositry : ICernterRepositry
    {
        private readonly ExaminationDBAccess repo;

        public CernterRepositry(ExaminationDBAccess repo)
        {
            this.repo = repo;
        }

        public bool Add(EximinationCenter eximination)
        {
            try
            {
                repo.EximinationCenters.Add(eximination);
                repo.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<EximinationCenter> GetExamCenters()
        {
            return repo.EximinationCenters
                                .OrderBy(r => r.Name)
                                .ThenBy(r => r.Code)
                                .ToList();
        }

        public EximinationCenter GetExamCenterById(string code)
        {
            return repo.EximinationCenters.FirstOrDefault(e => e.Code == code);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
        public void SeatUpdate(string code)
        {
            try
            {
                EximinationCenter center = GetExamCenterById(code);
                center.SeatAvailable = center.SeatAvailable - 1;
                repo.EximinationCenters.Update(center);
                repo.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public bool SeatAvaiablity(string code)
        {
            if (GetExamCenterById(code).SeatAvailable > 0)
                return true;
            return false;
        }

        public IEnumerable<EximinationCenter> GetExamCentersSeatAvaiablity()
        {
            try
            {
                return repo.EximinationCenters.Where(e => e.SeatAvailable > 0).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
