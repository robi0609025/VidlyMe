using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMe.Models;

namespace VidlyMe.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var Customers = GetCustomer();

            return View(Customers);
        }

        public ActionResult Details(int? id)
        {
            var Customer = GetCustomer().SingleOrDefault(c => c.CustomerId == id);

            if (Customer == null)
            {
                return HttpNotFound();
            }

            return View(Customer);
        }


        //Get Customer method to collect customer data
        private IEnumerable<Customer> GetCustomer()
        {
            var Customers = new List<Customer>()
            {
                new Customer(){Name = "John Smith", CustomerId = 1 },
                new Customer(){Name = "Mary William", CustomerId = 2 }
            };
            return Customers;
        }

    }
}