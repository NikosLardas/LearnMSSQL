using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LearnMSSQL.ViewModels
{
    public class ResultsViewModel
    {

        public string TestTaken { get; set; }

        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer1 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer2 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer3 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer4 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer5 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer6 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer7 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer8 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer9 { get; set; }
        [Required(ErrorMessage = "Please choose an answer for the following question!")]
        public bool? Answer10 { get; set; }


        public DateTime Time1 { get; set; }
        public int Grade1 { get; set; }

        public DateTime Time2 { get; set; }
        public int Grade2 { get; set; }

        public DateTime Time3 { get; set; }
        public int Grade3 { get; set; }

        public DateTime Time4 { get; set; }
        public int Grade4 { get; set; }

    }
}