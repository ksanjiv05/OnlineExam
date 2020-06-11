using Exmination.Data.RegisterRepositry;
using Exmination.Models.Account;
using Exmination.Models.Services;
using Exmination.Models.Student;
using Exmination.ModelView.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.AdmitCardRepositry
{
    public class AdmitCardRepositry : IAdmitCardRepositry
    {
        private readonly ExaminationDBAccess dBAccess;
        private readonly IRegisterRepositry registerRepositry;

        public AdmitCardRepositry(ExaminationDBAccess dBAcces,IRegisterRepositry registerRepositry )
        {
            this.dBAccess = dBAcces;
            this.registerRepositry = registerRepositry;
        }

        public bool Add(StudentAdmitCard card)
        {
            try
            {
                StudentAdmitCard student = dBAccess.StudentAdmitCards.FirstOrDefault(f => f.GenrateExameFor == card.GenrateExameFor);
                if (student != null)
                    return false;

                IEnumerable<Registation> registations = dBAccess.Registations.Where(r=>r.ExaminationApplied == card.GenrateExameFor);
                if (registations == null)
                    return false;
                List<StudentAdmitCard> admitCards = new List<StudentAdmitCard>(); 
                foreach(Registation registation in registations)
                {
                    card.Roll = card.GenrateExameFor+registation.Registration_number;
                    card.Password = card.GenrateExameFor + registation.Password;
                    admitCards.Add(card);
                    
                }
                dBAccess.StudentAdmitCards.AddRange(admitCards);
                dBAccess.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public StudentAdmitCardViewModel GetAdmitCard(string reg, string examfor)
        {
            try
            {
               StudentAdmitCard admitCard = dBAccess.StudentAdmitCards.FirstOrDefault(s => s.Roll == examfor+reg);
                if (admitCard == null)
                    return null;
                Enrollment enrollment = dBAccess.Enrollments.FirstOrDefault(r=>r.Registration_number==reg);
                StudentAdmitCardViewModel studentAdmitCard = new StudentAdmitCardViewModel()
                {
                    Roll=admitCard.Roll,
                    PasswordForExamination =admitCard.Password,
                    ExameDate = admitCard.ExameDate,
                    reportingTime = admitCard.reportingTime,
                    EntryClosingTime = admitCard.EntryClosingTime,
                    ApplicantName= enrollment.Name,
                    DOB=enrollment.DOB.ToString(),
                    Sex=enrollment.Sex,
                    Category=enrollment.Catagory,
                    ExaminationVenue=null//dBAccess.EximinationCenters.FirstOrDefault(ex=>ex.Code==enrollment.ExameCenter).Address,
                };
                return studentAdmitCard;
            }catch(Exception ex)
            {
                return null;
            }
           
        }
    }
}
