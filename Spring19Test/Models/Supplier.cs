using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spring19Test.Models
{
    public class Supplier
    {
        public int supplierID { get; set; }
        [Display(Name = "Supplier Name")]
        [Required]
        public string name { get; set; }
        [Display (Name ="Supplier location")]
        public string location { get; set; }
        [Display(Name ="Phone number")]
        [Required]
        public string phone { get; set; }
        [Display(Name="Email address")]
        [Required]
        public string email { get; set; }
        public ICollection<Product>  Product{ get; set; }

    }
}