using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Models;

namespace Exmination.Data.CenterRepositry
{
    public interface ICernterRepositry
    {
        public bool Add(EximinationCenter eximination);
        public void Remove(int id);
        public IEnumerable<EximinationCenter> GetExamCenters();
        public EximinationCenter GetExamCenterById(string code);
        public void SeatUpdate(string code);
        public bool SeatAvaiablity(string code);
        public IEnumerable<EximinationCenter> GetExamCentersSeatAvaiablity();
    }
}
