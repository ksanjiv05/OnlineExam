using Exmination.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.RegisterRepositry
{
    public interface IRegisterRepositry
    {
        public bool Add(Registation registation);
        public bool Remove(string email);
        public Registation GetRegistationById(string email);
        public IEnumerable<Registation> GetRegistation();
        public bool Login(string email, string password);
    }
}
