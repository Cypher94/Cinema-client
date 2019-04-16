using System.Collections.Generic;

namespace CinemaClient.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MiniatureImageUrl { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string Duration { get; set; }
        public double Rating { get; set; }
        public string CarouselImageUrl { get; set; }
        public bool HeroCarousel { get; set; }
    }
}
