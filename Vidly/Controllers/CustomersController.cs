using System.Web.Mvc;
using Vidly.Models;
using System.Linq;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db;

        public CustomersController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        public ActionResult Index()
        {
            return View(db.Customers.Include(c=> c.membershipType).ToList());
        }

       public ActionResult Details(int id)
        {
            Customer customer = db.Customers.Include(c=> c.membershipType).Single(c => c.CustomerId == id);
            return View(customer);
        }

    }
}