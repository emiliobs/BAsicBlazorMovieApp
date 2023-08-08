using BAsicBlazorMovieApp.Models;

namespace BAsicBlazorMovieApp.Services
{
    public interface IMovieReviewService
    {
        Task<List<MovieModel?>> GetMovies();

        Task<MovieModel?> GetMovieById(int id);
    }
}
