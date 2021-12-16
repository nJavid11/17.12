using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string title { get; set; }
        [ForeignKey("Icons")]
        public int IconId { get; set; }
        public Icons Icons { get; set; }

        [MaxLength(70)]
        public string Link1 { get; set; }

        [MaxLength(70)]
        public string Link2 { get; set; }

        [MaxLength(50)]
        public string Ads1 { get; set; }
        [MaxLength(50)]
        public string Ads2 { get; set; }
        [MaxLength(50)]
        public string Ads3 { get; set; }
    }
}
