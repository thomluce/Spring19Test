using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spring19Test.Models
{
    public class Email
    {
        public int ID { get; set; }
        [Display(Name ="Email subject")]
        public string subject { get; set; }
        [Display(Name ="Body of message")]
        public string body { get; set; }
    }
}