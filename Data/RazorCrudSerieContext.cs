using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudSerieContext : DbContext
    {
        public RazorCrudSerieContext (DbContextOptions<RazorCrudSerieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Serie> Serie { get; set; }
    }
