using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		//
		// GET: /Customers/
		public ActionResult Index()
		{

			var customers = new List<Customer>
			{
                new Customer{ Name = "John Constantine", Id = 1 },
                new Customer{ Name = "Mary Jane" , Id = 2}
			};

			var viewModel = new RandomMovieViewModel();
			viewModel.Customers = customers;
			return View(viewModel);
		}

		public ActionResult Details(int id)
		{
            var customers = new List<Customer>
            {
                new Customer{ Name = "John Constantine", Id = 1 },
                new Customer{ Name = "Mary Jane" , Id = 2}
            };

			var selectedCustomer = customers.Find(c => c.Id == id);

            if (selectedCustomer == null)
            {
                return HttpNotFound();
            }

			return View(selectedCustomer);
		}
	}
}