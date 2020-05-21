using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spring19Test.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public int customerID { get; set; }
        [Display(Name = "Order Description")]
        public string description { get; set; }
        [Display(Name = "Order Date")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime orderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        [Display(Name = "Order details")]
        //public string orderInfo { get { return  Customer.fullName + " order # " + orderID; } }


        public string orderInfo
        {
            get
            {
                return orderID.ToString();
            }
        }

    }
}