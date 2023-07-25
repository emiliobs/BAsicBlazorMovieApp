using BAsicBlazorMovieApp.Models;

namespace BAsicBlazorMovieApp.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();

        MovieModel? GetMovieById(int id);
    }
}
