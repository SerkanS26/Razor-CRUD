using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorCrud.Models
{
    public class SeedDataSeries
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorCrudSerieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudSerieContext>>()))
            {
                // Look for any Series.
                if (context.Serie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Serie.AddRange(
                    new Serie
                    {
                        Title = "Snowpiercer",
                        ReleaseDate = DateTime.Parse("2020-5-17"),
                        Genre = "Drama",
                        Price = 7.99M
                    },

                    new Serie
                    {
                        Title = "Gotham",
                        ReleaseDate = DateTime.Parse("2014-9-22"),
                        Genre = "Action",
                        Price = 8.99M
                    },

                    new Serie
                    {
                        Title = "Black Mirror",
                        ReleaseDate = DateTime.Parse("2011-12-4"),
                        Genre = "Sci-fi",
                        Price = 9.99M
                    }

                   
                );
                context.SaveChanges();
            }
        }


    }
}
