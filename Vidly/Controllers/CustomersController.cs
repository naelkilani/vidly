using AutoMapper;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ModelsDtos;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

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
                CustomerDto = Mapper.Map<Customer, CustomerDto>(customer),
                Memberships = _context.Memberships.ToList()
            };

            return View("CustomerForm", viewModel);
        }


        [HttpPost]
        public ActionResult Save(CustomerDto customerDto)
        {
            //ToDo: Add Validation and handle the !ModelState.IsValid on creating. 
            if (customerDto.Id == 0)
                AddCustomer(customerDto);
            else
                UpdateCustomer(customerDto);

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        private void AddCustomer(CustomerDto customerDto)
        {
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
        }

        private void UpdateCustomer(CustomerDto customerDto)
        {
            var customerInDb = _context.Customers.First(c => c.Id == customerDto.Id);
            Mapper.Map(customerDto, customerInDb);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}