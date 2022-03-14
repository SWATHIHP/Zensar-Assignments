using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAssignment1.Models;

namespace MvcAssignment1.Controllers
{
    public class CustomerOrdersController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: CustomerOrders
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCustomerByCountry()
        {
            List<string> cname = (from c in db.Customers
                                  where c.Country == "Germany"
                                  select c.ContactName).ToList();
            return View(cname);
        }
        public ActionResult GetCustomerByOrderId()
        {
            List<Customer> customer = (from c in db.Customers
                                       join d in db.Orders
                on c.CustomerID equals d.CustomerID
                                       where d.OrderID == 10248
                                       select c).ToList();

            return View(customer);
        }
    }
}