using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages_Series
{
    public class IndexModel : PageModel
    {
        private readonly RazorCrudSerieContext _context;

        public IndexModel(RazorCrudSerieContext context)
        {
            _context = context;
        }

        public IList<Serie> Serie { get;set; }

        public async Task OnGetAsync()
        {
            Serie = await _context.Serie.ToListAsync();
        }
    }
}
