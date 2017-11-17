using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualAssistant.Models;
using VirtualAssistant.ViewModels;
using System.Data.Entity;

namespace VirtualAssistant.Controllers
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
        // GET: Movies/Random
        public  ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name="Customer 1"},
                new Customer{Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        //movie
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
            //var movies = GetMovies();
            
            //if (!pageIndex.HasValue)
            //    pageIndex = 1;

            //if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            //return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));

        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);
        }
        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie{Id=1,Name="Shrek"},
        //        new Movie{Id=2,Name="Wall-e"},
        //    };
        //}
        public ActionResult Details(int id)
        {
            var customer = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}