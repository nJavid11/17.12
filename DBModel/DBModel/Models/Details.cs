using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Models
{
    public class Details
    {
        [Key]
        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }

        public List<News> News { get; set; }
    }
}
