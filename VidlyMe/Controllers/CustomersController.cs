using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMe.Models;

namespace VidlyMe.Controllers
{
    public class CustomersController : Controller
    {
        //start - context class is used for accessing database. It needs to be disposed.
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //end - context class is used for accessing database. It needs to be disposed.

        
        public ActionResult Index()
        {
            //var Customers = GetCustomer();
            var Customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(Customers);
        }


        public ActionResult Details(int? id)
        {
            var Customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.CustomerId == id);

            if (Customer == null)
            {
                return HttpNotFound();
            }

            return View(Customer);
        }

    }
}