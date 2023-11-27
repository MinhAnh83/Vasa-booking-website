using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace VasaHotel.Models
{ public class Booking
    {
        [Key]
        public int booking_id { get; set; }
        public DateTime checkout_day { get; set; }
        public DateTime checkin_day { get; set; }
        public string method_payment { get; set; }
        public bool is_payment { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int RoomID { get; set; }
        public Room Room { get; set; }
        public ICollection<Service> Service { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal total_price { get; set; }

    }
}
