using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Slownik.Entity;
using Slownik.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Slownik.Repository;
using System.ComponentModel.DataAnnotations;

namespace Slownik.Pages.Slowa
{
    public class Ulubione2Model : PageModel
    {
        private readonly Slownik.Models.SlownikContext _context;

        public string Message { get; set; }      

        public Ulubione2Model(Slownik.Models.SlownikContext context, ISlowaRepository productRepository)
        {
            _context = context;
            _slowaRepository = productRepository;
        }

        ISlowaRepository _slowaRepository;
        public string PolskiSort { get; set; }
        public string AngielskiSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        [BindProperty]
        public int liczbaSlow { get; set; }

        [BindProperty(SupportsGet =true)]       
        public string SearchString { get; set; }

        public PaginatedList<Ulubione> Ulubione { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } = 1;

        [BindProperty(SupportsGet = true)]
        public int Count { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 10;

        [BindProperty(SupportsGet = true)]
        public int TotalPages { get; set; }

        public string CurrentFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;

        public async Task OnGetAsync(string sortOrder,
string currentFilter, string searchString, int? pageIndex)
        {
            PolskiSort = String.IsNullOrEmpty(sortOrder) ? "Polski" : "";
            AngielskiSort = sortOrder == "Angielski" ? "Angielski" : "Angielski";
            string user = User.Identity.Name;
            searchString = SearchString;
            var take = PageSize;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Ulubione> slowa = from s in _context.Ulubione
                                         where (s.user_id==user)
                                             select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                slowa = slowa.Where(s => s.Polski.Contains(searchString)
                                       || s.Angielski.Contains(searchString));

            }
            switch (sortOrder)
            {
                case "Polski":
                    slowa = slowa.OrderBy(s => s.Polski);
                    break;
                case "Angielski":
                    slowa = slowa.OrderBy(s => s.Angielski);
                    break;
                default:
                    slowa = slowa.OrderBy(s => s.Polski);
                    break;
            }
            Count = await slowa.CountAsync();
            TotalPages = (int)Math.Ceiling(Decimal.Divide(Count, PageSize));
            Ulubione = await PaginatedList<Ulubione>.CreateAsync(
                slowa.AsNoTracking(), pageIndex ?? 1, PageSize);
            CurrentPage = pageIndex ?? CurrentPage;
            searchString = SearchString;
            currentFilter = SearchString;
        }
        public IActionResult OnPostDelete(int id)
        {
            if (id > 0)
            {
                var count = _slowaRepository.DeleteUlubioneSlowo(id);
                if (count > 0)
                {
                    Message = "Ulubione słowo usunięte!";
                    return RedirectToPage("/Slowa/Ulubione");
                }
            }

            return Page();

        }
    }
}
