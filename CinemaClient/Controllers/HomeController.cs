using CinemaClient.Services.MoviesService;
using Microsoft.AspNetCore.Mvc;

namespace CinemaClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMoviesRepository _moviesRepository;

        public HomeController(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        public IActionResult Index()
        {
            var moviesList = _moviesRepository.GetMoviesList();
            return View(moviesList);
        }

        public IActionResult MovieDetails(int id)
        {
            var movie = _moviesRepository.GetMovieDetails(id);
            return View(movie);
        }
    }
}
