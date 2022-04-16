using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Slownik.Entity;
using Slownik.Models;

namespace Slownik.Pages.Slowa
{
    public class DetailsModel : PageModel
    {
        private readonly Slownik.Models.SlownikContext _context;

        public DetailsModel(Slownik.Models.SlownikContext context)
        {
            _context = context;
        }

        public Entity.Slowa Slowa { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Slowa = await _context.Slowa.FirstOrDefaultAsync(m => m.Id == id);

            if (Slowa == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
