using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudMusicContext : DbContext
    {
        public RazorCrudMusicContext (DbContextOptions<RazorCrudMusicContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Music> Music { get; set; }
    }
