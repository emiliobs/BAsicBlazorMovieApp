using System.ComponentModel.DataAnnotations;

namespace BAsicBlazorMovieApp.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Review { get; set; } = null!;

    }
}
