using CinemaClient.Models;
using System.Collections.Generic;

namespace CinemaClient.Services.MoviesService
{
    public interface IMoviesRepository
    {
        Movie GetMovieDetails(int id);
        IEnumerable<Movie> GetMoviesList();
    }
}
