using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VasaHotel.Models
{
    public class Room
    {
        [Key]
        public int room_id { get; set; }
        [Required]

      

        public int TyperoomID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string Description { get; set; }
        
        public ICollection<Review> Review { get; set; }
    
        public Typeroom Typeroom { get; set; }

      


    }
  

}
