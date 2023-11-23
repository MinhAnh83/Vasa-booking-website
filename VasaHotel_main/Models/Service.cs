using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VasaHotel.Models
{
    public class Service
    {
        [Key]
        public int service_id { get; set; }
        public string service_name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal service_price { get; set; }

        public ICollection<Booking> Booking { get; set; }


    }
}
