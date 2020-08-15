using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cs_finalproject.Model
{
   public class Books
    {
        [Required]   
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name  { get; set; }

        [Required]
        [StringLength(50)]
        public string Price { get; set; }

        public ICollection<ReportBooks> ReportBooks { get; set; }

    }
}
