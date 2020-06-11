using Exmination.Models;
using Exmination.Models.Student;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.ModelView.Student
{
    public class EnrollmentViewModel
    {
       
            // clear
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public string ContactNumber { get; set; }
            public string Email { get; set; }
            [Required]    
            public string Sex { get; set; }
            [Required]
            public string Catagory { get; set; }
            [Required]
            public string Father { get; set; }
            public string Mobile { get; set; }

            [Required]
            public Address ParmanentAddress { get; set; }
            public bool SameAsParmanent { get; set; }
            public Address CorrespondanceAddress { get; set; }

            public string Programm { get; set; }

            public IEnumerable<EximinationCenter> ExameCenterCh1 { get; set; }
            public string   centerCode { get; set; }

        //public IEnumerable<ExameCenter> ExameCenterCh2 { get; set; }

        //public IEnumerable<ExameCenter> ExameCenterCh3 { get; set; }

        [Required]
            public IFormFile Profile { get; set; }
            [Required]
            public IFormFile Signature { get; set; }
    }
    }

