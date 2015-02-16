using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PalinkaAppDemo.Models
{
    public class DilutionViewModel
    {
        [Required]
        [Display(Name = "Eredeti mennyiség")]
        public decimal OriginalAmount { get; set; }

        [Required]
        [Display(Name = "Eredeti szeszfok")]
        public decimal OriginalConcentration { get; set; }
        
        [Required]
        [Display(Name = "Elvárt szeszfok")]
        public decimal RequiredConcentration { get; set; }

        [Display(Name = "Hozzáadandó mennyiség")]
        public decimal? AdditionalAmount { get; set; }

    }
}