using CinemaClient.Models;
using System.Collections.Generic;
using System.Linq;

namespace CinemaClient.Services.MoviesService
{
    public class MoviesRepository : IMoviesRepository
    {
        private IEnumerable<Movie> _moviesList;

        public MoviesRepository()
        {
            Initialize();
        }

        private void Initialize()
        {
            _moviesList = new List<Movie>
            {
                new Movie
                {
                    Id = 0,
                    Name = "Avengers: Endgame",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus urna duis convallis convallis tellus id interdum. In mollis nunc sed id semper risus. Eu lobortis elementum nibh tellus. Pulvinar neque laoreet suspendisse interdum consectetur libero id. Volutpat ac tincidunt vitae semper quis lectus nulla at volutpat. Morbi quis commodo odio aenean sed adipiscing. Turpis massa sed elementum tempus egestas sed. Orci porta non pulvinar neque laoreet suspendisse interdum consectetur libero. Condimentum lacinia quis vel eros donec. Proin sed libero enim sed faucibus turpis in.",
                    MiniatureImageUrl = @"/assets/nature-h-c-200-280-2.jpg",
                    Tags = new List<string>
                    {
                        "Fantasy",
                        "Science Fiction"
                    },
                    Duration = "182 min",
                    Rating = 8.2,
                    CarouselImageUrl = @"/assets/nature-q-c-1920-650-7.jpg",
                    HeroCarousel = true
                },
                new Movie
                {
                    Id = 1,
                    Name = "Shazam!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus urna duis convallis convallis tellus id interdum. In mollis nunc sed id semper risus. Eu lobortis elementum nibh tellus. Pulvinar neque laoreet suspendisse interdum consectetur libero id. Volutpat ac tincidunt vitae semper quis lectus nulla at volutpat. Morbi quis commodo odio aenean sed adipiscing. Turpis massa sed elementum tempus egestas sed. Orci porta non pulvinar neque laoreet suspendisse interdum consectetur libero. Condimentum lacinia quis vel eros donec. Proin sed libero enim sed faucibus turpis in.",
                    MiniatureImageUrl = @"/assets/nature-h-c-200-280-10.jpg",
                    Tags = new List<string>
                    {
                        "Fantasy",
                        "Action"
                    },
                    Duration = "132 min",
                    Rating = 8.5,
                    CarouselImageUrl = @"/assets/nature-q-c-1920-650-8.jpg",
                    HeroCarousel = true
        },
                new Movie
                {
                    Id = 2,
                    Name = "Dumbo",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus urna duis convallis convallis tellus id interdum. In mollis nunc sed id semper risus. Eu lobortis elementum nibh tellus. Pulvinar neque laoreet suspendisse interdum consectetur libero id. Volutpat ac tincidunt vitae semper quis lectus nulla at volutpat. Morbi quis commodo odio aenean sed adipiscing. Turpis massa sed elementum tempus egestas sed. Orci porta non pulvinar neque laoreet suspendisse interdum consectetur libero. Condimentum lacinia quis vel eros donec. Proin sed libero enim sed faucibus turpis in.",
                    MiniatureImageUrl = @"/assets/nature-h-c-200-280-8.jpg",
                    Tags = new List<string>
                    {
                        "Animated",
                        "For kids"
                    },
                    Duration = "106 min",
                    Rating = 7.5,
                    CarouselImageUrl = @"/assets/nature-q-c-1920-650-5.jpg",
                    HeroCarousel = true
        },
                new Movie
                {
                    Id = 3,
                    Name = "Lorem ipsum dolor",
                    MiniatureImageUrl = @"/assets/nature-h-c-200-280-2.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus urna duis convallis convallis tellus id interdum. In mollis nunc sed id semper risus. Eu lobortis elementum nibh tellus. Pulvinar neque laoreet suspendisse interdum consectetur libero id. Volutpat ac tincidunt vitae semper quis lectus nulla at volutpat. Morbi quis commodo odio aenean sed adipiscing. Turpis massa sed elementum tempus egestas sed. Orci porta non pulvinar neque laoreet suspendisse interdum consectetur libero. Condimentum lacinia quis vel eros donec. Proin sed libero enim sed faucibus turpis in.",
                    Tags = new List<string>
                    {
                        "Fantasy",
                        "Science Fiction"
                    },
                    Duration = "182 min",
                    Rating = 8.2,
                    HeroCarousel = false
        },
                new Movie
                {
                    Id = 4,
                    Name = "Lorem ipsum dolor1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus urna duis convallis convallis tellus id interdum. In mollis nunc sed id semper risus. Eu lobortis elementum nibh tellus. Pulvinar neque laoreet suspendisse interdum consectetur libero id. Volutpat ac tincidunt vitae semper quis lectus nulla at volutpat. Morbi quis commodo odio aenean sed adipiscing. Turpis massa sed elementum tempus egestas sed. Orci porta non pulvinar neque laoreet suspendisse interdum consectetur libero. Condimentum lacinia quis vel eros donec. Proin sed libero enim sed faucibus turpis in.",
                    MiniatureImageUrl = @"/assets/nature-h-c-200-280-10.jpg",
                    Tags = new List<string>
                    {
                        "Fantasy",
                        "Action"
                    },
                    Duration = "132 min",
                    Rating = 8.5,
                    HeroCarousel = false
                },
                new Movie
                {
                    Id = 5,
                    Name = "Lorem ipsum dolor2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus urna duis convallis convallis tellus id interdum. In mollis nunc sed id semper risus. Eu lobortis elementum nibh tellus. Pulvinar neque laoreet suspendisse interdum consectetur libero id. Volutpat ac tincidunt vitae semper quis lectus nulla at volutpat. Morbi quis commodo odio aenean sed adipiscing. Turpis massa sed elementum tempus egestas sed. Orci porta non pulvinar neque laoreet suspendisse interdum consectetur libero. Condimentum lacinia quis vel eros donec. Proin sed libero enim sed faucibus turpis in.",
                    MiniatureImageUrl = @"/assets/nature-h-c-200-280-8.jpg",
                    Tags = new List<string>
                    {
                        "Animated",
                        "For kids"
                    },
                    Duration = "106 min",
                    Rating = 7.5,
                    HeroCarousel = false
                }
            };
        }

        public Movie GetMovieDetails(int id)
        {
            return _moviesList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Movie> GetMoviesList()
        {
            return _moviesList;
        }
    }
}
