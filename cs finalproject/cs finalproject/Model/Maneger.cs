using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cs_finalproject.Model
{
    public class Maneger
    {
       [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string Name { get; set; }
        [Required]

        public string Password { get; set; }

        public ICollection<Report> Reports{ get; set; }
    }
}
