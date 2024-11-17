using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Georza_Daniel_Lab2.Models;

namespace Georza_Daniel_Lab2.Data
{
    public class Georza_Daniel_Lab2Context : DbContext
    {
        public Georza_Daniel_Lab2Context (DbContextOptions<Georza_Daniel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Georza_Daniel_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Georza_Daniel_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Georza_Daniel_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Georza_Daniel_Lab2.Models.BookCategory> BookCategory { get; set; } = default!;
        public DbSet<Georza_Daniel_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
