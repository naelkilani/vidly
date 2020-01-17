using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.Membership).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {

            var customer = _context.Customers.Include(c => c.Membership).FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult New()
        {
            var viewModel = new CustomerFormViewModel
            {
                Memberships = _context.Memberships.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.Include(c => c.Membership).FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                Memberships = _context.Memberships.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.First(c => c.Id == customer.Id);
                MapCustomerData(customerInDb, customer);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        private void MapCustomerData(Customer customerInDb, Customer customer)
        {
            customerInDb.Name = customer.Name;
            customerInDb.Birthdate = customer.Birthdate;
            customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            customerInDb.MembershipId = customer.MembershipId;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}