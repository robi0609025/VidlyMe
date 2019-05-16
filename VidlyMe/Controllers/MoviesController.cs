using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMe.Models;
using VidlyMe.ViewModel;

namespace VidlyMe.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var Movies = GetMovies();
            return View(Movies);
        }


        // GET: Movies
        //public ActionResult Random()
        //{
        //    var Movie = new Movie() { Id = 1, Name = "Shrek" };
            

        //    RandomMovieViewModel ViewModel = new RandomMovieViewModel() { Customers = Customers, Movie = Movie };

        //    return View(ViewModel);
        //}



        //[Route("movies/released/{year:range(1930,2019)}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ReleaseByDate(int year, int month)
        //{


        //    //return View();
        //    //return Content("Worked");
        //    return Content(String.Format("Year = {0} and Month = {1}", year, month));
        //}





        private IEnumerable<Movie> GetMovies()
        {
            var Movies = new List<Movie>
            {
                new Movie(){ Name = "Shrek!", Id = 1},
                new Movie(){ Name = "Tomorrow Never Dies", Id = 2}
            };

            return Movies;
        }
    }
}