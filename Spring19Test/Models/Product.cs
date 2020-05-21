using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spring19Test.Models
{
    public class Product
    {
        public int productID { get; set; }
        [Display(Name ="Product Description")]
        [Required]
        public string description { get; set; }
        [Display(Name ="List Price")]
        [Required]
        public decimal listPrice { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        [Display(Name ="Product information")]
        public string productInfo { get { return "Product # " + productID + " - " + description; } }
        [Display(Name ="Supplier")]
        public int? supplierID { get; set; }
        public virtual Supplier Supplier  { get; set; }
    }
}