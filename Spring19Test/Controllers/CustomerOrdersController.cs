using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Spring19Test.Context;
using Spring19Test.Models;

namespace Spring19Test.Controllers
{
    public class CustomerOrdersController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: CustomerOrders
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var order = db.Orders.Where(o=>o.customerID==id).Include(d=>d.OrderDetails).ToList();
            if (order == null)
            {
                return HttpNotFound();
            }

            return View(order);
        }

        //// GET: CustomerOrders/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Order order = db.Orders.Find(id);
        //    if (order == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(order);
        //}




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
