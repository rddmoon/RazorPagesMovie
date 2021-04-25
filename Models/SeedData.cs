using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Kuroko's Basketball: Last Game",
                        ReleaseDate = DateTime.Parse("2017-3-18"),
                        Genre = "Animation",
                        Price = 7.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Mortal Kombat",
                        ReleaseDate = DateTime.Parse("2021-4-23"),
                        Genre = "Action",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Tenet",
                        ReleaseDate = DateTime.Parse("2020-9-3"),
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Spider-Man: Far from Home",
                        ReleaseDate = DateTime.Parse("2019-7-3"),
                        Genre = "Action",
                        Price = 7.99M,
                        Rating = "PG-13"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}