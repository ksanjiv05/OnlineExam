using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Models.Services
{
    public class StudentAdmitCard
    {
        public int id { get; set; }
        public string Roll { get; set; }
        public string Password { get; set; }
        public string ExameDate { get; set; }
        public string reportingTime { get; set; }
        public string EntryClosingTime { get; set; }
        public string GenrateExameFor { get; set; }
    }
}
