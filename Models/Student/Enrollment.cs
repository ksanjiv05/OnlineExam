using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Exmination.Models.Student
{
    public class Enrollment
    {
        // clear
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        
        [Required]
        public string Father { get; set; }
        public string Mobile { get; set; }

        [Required]
        public Address ParmanentAddress { get; set; }
        public bool SameAsParmanent { get; set; }
        public Address CorrespondanceAddress { get; set; }

        public string Programm { get; set; }

        public string ExameCenterCh1 { get; set; }

        public string ExameCenterCh2 { get; set; }

        public string ExameCenterCh3 { get; set; }

        [Required]
        public string Profile { get; set; }
        [Required]
        public string Signature { get; set; }
    }
}
