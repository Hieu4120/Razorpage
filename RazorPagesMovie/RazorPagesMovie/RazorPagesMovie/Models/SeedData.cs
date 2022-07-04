using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentException("Null RazorPagesMovieContext");
                }

                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Badman",
                        ReleaseDate = DateTime.Parse("3-21-2022"),
                        Genre = "Romantic Comedy",
                        Price = 100M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Endgame",
                        ReleaseDate = DateTime.Parse("10-4-2019"),
                        Genre = "Action",
                        Price = 500M,
                        Rating = "G"
                    },
                    new Movie
                    {
                        Title = "Captain Marvel",
                        ReleaseDate = DateTime.Parse("1-5-2020"),
                        Genre = "Action",
                        Price = 400M,
                        Rating = "NA"
                    },
                    new Movie
                    {
                        Title = "Moon Knight",
                        ReleaseDate = DateTime.Parse("1-3-2022"),
                        Genre = "Comedy",
                        Price = 200M,
                        Rating = "R"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
