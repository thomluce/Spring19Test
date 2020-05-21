using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spring19Test.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }

        [Display(Name ="Qty ordered")]
        [Required]
        public int qtyOrdered { get; set; }

        [Display(Name ="Selling price")]
        [Required]
        [DisplayFormat(DataFormatString =("{0:c}"))]
        public decimal price { get; set; }
        public int orderID { get; set; }
        public virtual Order Order { get; set; }
        public int productID { get; set; }
        public virtual Product Product { get; set; }

        [Display(Name="Extended Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        public decimal extPrice { get { return qtyOrdered * price; } }

    }
}