using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jobaffair.Models
{
    public class Job
    {
        public int ID { get; set; }


        [Required]
        [Display(Name = "اسم الوظيفة")]
        public string JobTitle { get; set; }
        [Required]
        [AllowHtml]
        [Display(Name = "وصف الوظيفة")]
        public string JobContent { get; set; }

        public string UserID { get; set; }
        [Display(Name = "صورة الوظيفة")]
        public string JobImage { get; set; }

        [Display(Name = "نوع الوظيفة")]
        public int CategoryID { get; set; }



        public virtual Category Category { get; set; }

        public virtual ApplicationUser User { get; set; }



    }



}