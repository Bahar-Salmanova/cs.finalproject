using System;
using System.Collections.Generic;
using System.Text;

namespace cs_finalproject.Model
{
     public class ReportBooks
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Books Book { get; set; }
        public Report Report { get; set; }
        public int ReportId { get; set; }
    }
}
