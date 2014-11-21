using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FAQ.Models
{
    public class Question
    {
        public int id { get; set; }
        public int categoryid { get; set; }
        public String category { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public String date { get; set; }
        public String question { get; set; }
        public String answer { get; set; }
        public bool isfequant { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email må oppgis")]
        [RegularExpression(@"(^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$)", ErrorMessage = "Ugyldig email")]
        public String email { get; set; }
    }
}