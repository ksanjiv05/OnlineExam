using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Models.Student
{
    public class AdmitCard
    {
        [Required]
        public string RollNumber { get; set; }
        [Required]
        public string ExamFor { get; set; }
        
    }
}
