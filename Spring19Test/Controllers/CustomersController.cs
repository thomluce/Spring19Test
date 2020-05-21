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
    public class CustomersController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Customers
        public ActionResult Index(string searchString)
        {

            //var testusers = from u in db.Customers select u;
            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    testusers = testusers.Where(u => u.lastName.Contains(searchString)
            //  || u.firstName.Contains(searchString));
            //    // if here, users were found so view them
            //    return View(testusers.ToList());
            //}
            //return View(db.Customers.ToList());
            var custSearch = from c in db.Customers select c;
            string[] customerNames;  // declare the array to hold pieces of the string
            if (!String.IsNullOrEmpty(searchString))
            {
                customerNames = searchString.Split(' '); // split the string on spaces
                if (customerNames.Count() == 1) // there is only one string so it could be 
                                                // either the first or last name 
                {
                    custSearch = custSearch.Where(c => c.lastName.Contains(searchString) || c.firstName.Contains(searchString)).OrderBy(c => c.lastName);
                }
                else //if you get here there were at least two strings so extract them and test
                {
                    string s1 = customerNames[0];
                    string s2 = customerNames[1];
                    custSearch = custSearch.Where(c => c.lastName.Contains(s2) && c.firstName.Contains(s1)).OrderBy(c => c.lastName);  // note that this uses &&, not ||
                }
            }
                return View(custSearch.ToList());

        }





        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput (false)]
        public ActionResult Create([Bind(Include = "customerID,firstName,lastName,email,phone,customerSince, notes")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "customerID,firstName,lastName,email,phone,customerSince, notes")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
