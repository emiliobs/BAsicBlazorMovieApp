using BAsicBlazorMovieApp.Data;
using BAsicBlazorMovieApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BAsicBlazorMovieApp.Services
{
    public class MovieReviewService : IMovieReviewService
    {
        private readonly MovieReviewDBContext _context;

        public MovieReviewService(MovieReviewDBContext context)
        {
            this._context = context;
        }

        //public Task  MovieModel? GetMovieById(int id) => _context.MovieModels.SingleOrDefault(m => m.Id == id);

        //public List<MovieModel>? GetMovies() => _context.MovieModels.ToList();

        public async  Task<List<MovieModel>> GetMovies()
        {
            return await _context.MovieModels.ToListAsync<MovieModel>();
        }

        public async Task<MovieModel?> GetMovieById(int id)
        {
            return await _context.MovieModels.SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}
