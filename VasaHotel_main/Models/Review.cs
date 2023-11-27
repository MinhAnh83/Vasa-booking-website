using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VasaHotel.Models
{
    public class Review
    {
        [Key]
        public int review_id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Day { get; set; }
        public int Rating { get; set; }
       // public string Name { get; set; }
        public string Review_content { get; set; }

        public int RoomID { get; set; }
        public Room Room { get; set; }
    }
}
