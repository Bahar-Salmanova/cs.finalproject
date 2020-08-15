using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cs_finalproject.Model
{
    public class Report
    {
        [Required]
        public int Id { get; set; }

       
        public DateTime startDay { get; set; }

        
        public DateTime endDay { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public int ManegerId { get; set; }
        public Customer Customer { get; set; }
        public Books Books { get; set; }
        public Maneger Maneger { get; set; }
        public ICollection<ReportBooks> ReportBooks { get; set; }

    }
}
