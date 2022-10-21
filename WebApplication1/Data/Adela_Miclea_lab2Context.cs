using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Adela_Miclea_lab2.Models;

namespace Adela_Miclea_lab2.Data
{
    public class Adela_Miclea_lab2Context : DbContext
    {
        public Adela_Miclea_lab2Context (DbContextOptions<Adela_Miclea_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Adela_Miclea_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Adela_Miclea_lab2.Models.Publisher> Publisher { get; set; }
    }
}
