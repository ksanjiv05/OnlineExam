using Exmination.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.RegisterRepositry
{
    public class RegisterRepositry : IRegisterRepositry
    {
        private readonly ExaminationDBAccess repo;

        public RegisterRepositry(ExaminationDBAccess repo)
        {
            this.repo = repo;
        }
        //public bool SaveAll()
        //{

        //    //return dBWebData.SaveChanges() > 0;
        //}
        public int getTotalNumberOfReg()
        {
            try
            {
                return repo.Registations.OrderBy(r => r.Email).ToList().Count;
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        public bool UserExistes( string email, string mobile)
        {
            try
            {
                Registation registation = repo.Registations.FirstOrDefault(r => r.Email == email || r.Mobile == mobile);
                if (registation == null)
                    return false;
                return true;
            }
            catch(Exception ex)
            {
                return true;
            }
        }

        public bool Add(Registation registation)
        {
            try
            {
                if (UserExistes(registation.Email, registation.Mobile))
                    return false;
                registation.Registration_number = (20200001+getTotalNumberOfReg()).ToString();
                Console.WriteLine(registation.Email);
                repo.Registations.Add(registation);
                repo.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public IEnumerable<Registation> GetRegistation()
        {
           return repo.Registations
                                .OrderBy(r => r.Email)
                                .ThenBy(r => r.CandidateName)
                                .Take(5)
                                .ToList();
        }

        public Registation GetRegistationById(string email)
        {
            return repo.Registations
                                    .FirstOrDefault(r => r.Email == email);
        }

        public Registation GetRegistationByRegistration_num(string reg)
        {
            try
            {
                return repo.Registations
                                   .FirstOrDefault(r => r.Registration_number == reg);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Remove(string email)
        {
           repo.Registations
                            .Remove(repo.Registations.FirstOrDefault(r => r.Email == email));
            try
            {
                repo.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Login(string regstration_number, string password)
        {
            try
            {
                Registation reg = repo.Registations.FirstOrDefault(r => r.Registration_number == regstration_number);

                if (reg != null)
                {
                    if (reg.Password == password)
                    {
                        return true;
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return false;
        }
    }
}
