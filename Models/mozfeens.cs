using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jobaffair.Models
{
    public class mozfeens
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string Mozf { get; set; }
        [Required]
        [Display(Name ="Descripation")]
        public string Desc { get; set; }

    }
}