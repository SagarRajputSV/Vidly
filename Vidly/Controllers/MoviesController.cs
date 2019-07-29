using Vidly.Models;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext db;

        public MoviesController()
        {
            db =new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           db.Dispose();
        }
        public ActionResult Index()
        {
            return View(db.Movies.Include(m=> m.Genre).ToList());
        }

        public ActionResult Details(int id)
        {
            Movie movie = db.Movies.Single(m => m.MovieId == id);
            return View(movie);
        }
    }
}