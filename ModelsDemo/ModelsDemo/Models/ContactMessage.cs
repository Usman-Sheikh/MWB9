using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelsDemo.Models
{
    public class ContactMessage
    {
        [Key]
        public int ContactMessageid { get; set; }
        

        [Required(ErrorMessage ="Enter Your Name")]
        [Display(Name ="Name")]
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerMessage { get; set; }
    }
}