using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spring19Test.Models
{
    public class Customer
    {
        public int customerID { get; set; }

        [Display(Name="Customer first name")]
        [Required]
        public string firstName { get; set; }

        [Display(Name = "Customer name name")]
        [Required]
        public string lastName { get; set; }

        [Display(Name = "Email address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Mobile Phone")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        [Display(Name = "CRM Notes")]
        public string notes { get; set; }

        [Display(Name = "Customer Since")]
        [Required]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        public DateTime customerSince { get; set; }

        public ICollection<Order> Orders  { get; set; }
        [Display(Name = "Customer name")]
        public string fullName { get { return lastName + ", " + firstName; } }

    }
}