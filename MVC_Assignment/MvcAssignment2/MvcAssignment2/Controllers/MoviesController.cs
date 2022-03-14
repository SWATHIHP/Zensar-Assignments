using MvcAssignment2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignment2.Controllers
{
    public class MoviesController : Controller
    {
        MoviesEntities1 mv = new MoviesEntities1();
        // GET: Movies
        public ActionResult Index()
        {
            return RedirectToAction("GetMoviesScaffolded");
        }
        public ActionResult GetMoviesScaffolded()
        {
            List<Moviestable> moviesdb = mv.Moviestables.ToList();
            return View(moviesdb);
        }
        // Crud Operations to create and post of create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Moviestable cat)
        {
            mv.Moviestables.Add(cat);
            mv.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }

        public ActionResult Details(int id)
        {
            Moviestable c = mv.Moviestables.Find(id);
            return View(c);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Moviestable cat = mv.Moviestables.Find(id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult Edit(Moviestable movie)
        {
            Moviestable mvs = mv.Moviestables.Find(movie.movie_id); 
            mvs.movie_name = movie.movie_name;
            mvs.movie_dor = movie.movie_dor;
            mv.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
  
        public ActionResult Delete(int id)
        {
            Moviestable cat = mv.Moviestables.Find(id);
            mv.Moviestables.Remove(cat);
            mv.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");

        }

        public ActionResult GetMoviesByYear(string search)
        {
            List<Moviestable> movies = (from m in mv.Moviestables
                                        where m.movie_dor.ToString().Contains(search) || search == null
                                        select m).ToList();
            return View(movies);
        }


    }
}