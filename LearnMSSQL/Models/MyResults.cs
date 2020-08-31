using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnMSSQL.Models
{
    public class MyResults
    {
        [Key]
        [Column(Order = 1)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        public string TestName { get; set; }

        public string TestSubject { get; set; }

        public string Difficulty { get; set; }

        public DateTime Time { get; set; }

        public int Grade { get; set; }

    }
}



