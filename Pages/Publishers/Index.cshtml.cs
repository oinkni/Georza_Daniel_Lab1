using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Georza_Daniel_Lab2.Data;
using Georza_Daniel_Lab2.Models;

namespace Georza_Daniel_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Georza_Daniel_Lab2.Data.Georza_Daniel_Lab2Context _context;

        public IndexModel(Georza_Daniel_Lab2.Data.Georza_Daniel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
