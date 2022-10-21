using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Adela_Miclea_lab2.Data;
using Adela_Miclea_lab2.Models;

namespace Adela_Miclea_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Adela_Miclea_lab2.Data.Adela_Miclea_lab2Context _context;

        public IndexModel(Adela_Miclea_lab2.Data.Adela_Miclea_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b=>b.Publisher).ToListAsync();
            }
        }
    }
}
