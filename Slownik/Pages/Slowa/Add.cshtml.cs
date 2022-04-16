using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Slownik.Entity;
using Slownik.Models;

namespace Slownik.Pages.Slowa
{
    public class Add2Model : PageModel
    {
        private readonly Slownik.Models.SlownikContext _context;

        public Add2Model(Slownik.Models.SlownikContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Entity.Slowa Slowa { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Slowa.Add(Slowa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}