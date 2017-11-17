﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualAssistant.Models;
using System.Data.Entity;
using VirtualAssistant.ViewModels;

namespace VirtualAssistant.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c =>c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipType = membershipTypes
            };
            
            return View(viewModel);
        }
        //private Ienumerable<customer> getcustomers()
        //{
        //    return new list<customer>
        //    {
        //        new customer { id = 1, name = "john smith" },
        //        new customer { id = 2, name = "mary williams" }
        //    };
        //}
    }
}