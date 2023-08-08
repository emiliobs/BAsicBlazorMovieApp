using BAsicBlazorMovieApp;
using BAsicBlazorMovieApp.Data;
using BAsicBlazorMovieApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddServerComponents();

builder.Services.AddDbContextPool<MovieReviewDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieReviewDbConnection"));
});

builder.Services.AddScoped<IMovieReviewService, MovieReviewService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.MapRazorComponents<App>();

app.Run();
