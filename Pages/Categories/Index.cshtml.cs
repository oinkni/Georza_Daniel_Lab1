using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Georza_Daniel_Lab2.Data;
using Georza_Daniel_Lab2.Models;
using Georza_Daniel_Lab2.Models.ViewModels;

namespace Georza_Daniel_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Georza_Daniel_Lab2.Data.Georza_Daniel_Lab2Context _context;

        public IndexModel(Georza_Daniel_Lab2.Data.Georza_Daniel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;
        public CategoryIndexData CategoryData { get; set; }

        public int CategoryID { get; set; }


        public async Task OnGetAsync(int? id)
        {
            Category = await _context.Category
                        .Include(i => i.BookCategories)
                        .ThenInclude(c => c.Book)
                        .ThenInclude(c => c.Author)
                .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                CategoryData = new CategoryIndexData();
                CategoryData.Category = Category
                        .Where(i => i.ID == id.Value)
                        .Single();
                CategoryData.Books = CategoryData.Category.BookCategories.Select(b => b.Book);
            }
        }
    }
}
