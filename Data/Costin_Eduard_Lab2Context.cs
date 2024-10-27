using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Costin_Eduard_Lab2.Models;

namespace Costin_Eduard_Lab2.Data
{
    public class Costin_Eduard_Lab2Context : DbContext
    {
        public Costin_Eduard_Lab2Context (DbContextOptions<Costin_Eduard_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Costin_Eduard_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Costin_Eduard_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
