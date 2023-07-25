namespace BAsicBlazorMovieApp.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImagenUrl { get; set; } = null!;

        public string Review { get; set; } = null!;
        public string ImageUrl { get; internal set; }
    }
}
