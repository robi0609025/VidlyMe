using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMe.Models;
using VidlyMe.ViewModel;
using System.Data.Entity;

namespace VidlyMe.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult Index()
        {
            //var Movies = GetMovies();
            var Movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(Movies);
        }

        public ActionResult Details(int? id)
        {
            var Movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(m => m.Id == id);
            if (Movie == null)
            {
                return HttpNotFound();
            }

            return View(Movie);
        }
    }
}