using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(60)]
        public string Img { get; set; }
        [Column(TypeName ="ntext")]
        public string Text { get; set; }
        [ForeignKey("Source")]
        public int SourceId  { get; set; }
        public Source Source { get; set; }
        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        [ForeignKey("Details")]
        public int DetailsId { get; set; }
        public Details Details { get; set; }

    }
}
