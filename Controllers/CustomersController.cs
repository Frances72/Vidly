using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly MvcMovieContext _context;

        public CustomersController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.iD == id);

            if (customer == null)
                return Content("There are no customers in the list");

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { iD = 1, Name = "John Smith" },
                new Customer { iD = 2, Name = "Mary Williams" }
            };
        }
    }
}
