using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VasaHotel.Models
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }

        public string email { get; set; }

        public string fullname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }

        public string gender { get; set; }
        public ICollection<Booking> Booking { get; set; }
    }
}
