using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spring19Test.Models
{
    public class RegisteredUser
    {
        public Guid ID { get; set; }
        [Display(Name ="Last Name")]
        [Required]
        public string lastName { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string firstName { get; set; }
        [Display(Name = "Mobile phone number")]
        public string phone { get; set; }
        [Display(Name = "Email address")]
        public string email { get; set; }

        [Display(Name = "Registration Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode =true)]
        public DateTime registrationDate { get; set; }

        [Display(Name ="User photo")]
        public string photo { get; set; }
        [Display(Name = "User Name")]
        public string fullName { get { return lastName + ", " + firstName; } }

    }
}