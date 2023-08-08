using BAsicBlazorMovieApp.Data;
using BAsicBlazorMovieApp.Models;

namespace BAsicBlazorMovieApp.Services
{
    public class MovieReviewService : IMovieReviewService
    {
        private readonly MovieReviewDBContext _context;

        public MovieReviewService(MovieReviewDBContext context)
        {
            this._context = context;
        }

        public MovieModel? GetMovieById(int id) => _context.MovieModels.SingleOrDefault(m => m.Id == id);

        public List<MovieModel>? GetMovies() => _context.MovieModels.ToList();
    }
}
