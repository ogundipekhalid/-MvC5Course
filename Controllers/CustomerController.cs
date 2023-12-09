using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvC5Course.Models;
// using Microsoft.EntityFrameworkCore;


// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading.Tasks;

namespace MvC5Course.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           var customer = GetAllCustomer();
           return  View(customer);
        }

        public IActionResult Edith(int id)
        {
            return Content("Id=" + id);
        }

        public ActionResult Detials(int? Id)
        {
            var Customer =  GetAllCustomer().SingleOrDefault(c => c.Id);
            if (Customer == null)
            return HttpNotFound();

            return View(Customer);
        }

        private IActionResult GetAllCustomer()
        {
            var customers = new List<Customer>()
            {
              new Customer { Id = 1 , Name = "Lola"},
              new Customer { Id = 2, Name = "Tola"},
            };
            return View(customers);
        }

    }
}