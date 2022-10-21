﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Adela_Miclea_lab2.Data;
using Adela_Miclea_lab2.Models;

namespace Adela_Miclea_lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Adela_Miclea_lab2.Data.Adela_Miclea_lab2Context _context;

        public DetailsModel(Adela_Miclea_lab2.Data.Adela_Miclea_lab2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
