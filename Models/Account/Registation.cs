using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Models.Account
{
    public class Registation
    {
        public int id { get; set; }
        [Required]
        public string Registration_number { get; set; }
        [Required]
        public string ExaminationApplied { get; set; }
        [Required][MinLength(5)]
        public string CandidateName { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    
    }
}
