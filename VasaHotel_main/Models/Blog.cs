using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VasaHotel.Models
{
    public class Blog
    {
        [Key]
        public int blog_id { get; set; }
        [Required]

        public string author_name { get; set; }

        public DateTime day_published { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Images { get; set; }
    }
}
