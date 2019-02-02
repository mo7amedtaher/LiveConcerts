using LiveConcerts.Models;
using LiveConcerts.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace LiveConcerts.Controllers
{
    public class ConcertsController : Controller
    {
        private ApplicationDbContext _context;

        public ConcertsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Concerts
        public ActionResult Create()
        {
            var viewModel = new ConcertFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}