using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Models
{
    public class EximinationCenter
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Pincode { get; set; }
        [Required]
        public string CenterInchargeName { get; set; }
        [Required]
        public string CenterInchargeEmail { get; set; }
        
        public int SeatAvailable { get; set; }
        [Required]
        public int TotalSeat { get; set; }

    }
}
