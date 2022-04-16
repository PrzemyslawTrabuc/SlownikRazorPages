using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Slownik.Entity;
using Slownik.Models;

namespace Slownik.Pages.Slowa
{
    public class Edit2Model : PageModel
    {
        private readonly Slownik.Models.SlownikContext _context;

        public Edit2Model(Slownik.Models.SlownikContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Slowa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlowaExists(Slowa.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SlowaExists(int id)
        {
            return _context.Slowa.Any(e => e.Id == id);
        }
    }
}
