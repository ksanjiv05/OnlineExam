using Exmination.Models.Services;
using Exmination.ModelView.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.AdmitCardRepositry
{
    public interface IAdmitCardRepositry
    {
        public bool Add(StudentAdmitCard card);
        public StudentAdmitCardViewModel GetAdmitCard(string reg, string examfor);

    }
}
