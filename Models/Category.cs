using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jobaffair.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [Display(Name ="نوع الوظيفة")]
        public string CategoryType { get; set; }
        [Required]
        [Display(Name = "وصف الوظيفة")]
        public string CategoryDesc { get; set; }


        public  virtual ICollection <Job> jobs { get; set; }



    }
}