using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Licenta.Models;
using System.Data.Entity;
using Licenta.ViewModels;
using System.Runtime.Caching;


namespace Licenta.Controllers
{    
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [Authorize(Roles = RoleName.CanManageCustomer)]
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer= new Customer(),
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }
        [HttpPost]

        public ActionResult Save(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
            return View("CustomerForm",viewModel);
            }
            if(customer.Id==0)
            _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c=>c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipType = customer.MembershipType;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");

        }

        public ViewResult Index()
        {
            if (MemoryCache.Default["Genres"] == null)
                    {
                MemoryCache.Default["Genres"] = _context.Genres.ToList();
            }
            var genres = MemoryCache.Default["Genres"] as IEnumerable<Genre>;
            
            if(User.IsInRole(RoleName.CanManageCustomer))
            return View("Index");
            else
            return View("ReadOnlyList");
            
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);

        }
    }
}
