﻿using BAsicBlazorMovieApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BAsicBlazorMovieApp.Data
{
    public class MovieReviewDBContext : DbContext
    {

        public MovieReviewDBContext(DbContextOptions<MovieReviewDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           SeedData.AddMovies(modelBuilder);


        }

        public DbSet<MovieModel> MovieModels { get; set; }
    }
}
