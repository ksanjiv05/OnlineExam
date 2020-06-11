using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Exmination.Models;

namespace Exmination.ModelView.Services
{
    public class StudentAdmitCardViewModel
    {
        public string Roll { get; set; }
        public string PasswordForExamination { get; set; }
        public string  ExameDate { get; set; }
        public string reportingTime { get; set; }
        public string EntryClosingTime { get; set; }
        public string ApplicantName { get; set; }
        public string DOB { get; set; }
        public string Sex { get; set; }
        public string Category { get; set; }
        public Address ExaminationVenue { get; set; }
        public Address Address { get; set; }
    }
}


