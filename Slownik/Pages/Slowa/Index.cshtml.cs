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
using System.IO;
using Newtonsoft.Json;

namespace Slownik.Pages.Slowa
{
    public class IndexModel : PageModel
    {
        public string PolskiSort { get; set; }
        public string AngielskiSort { get; set; }        

        [BindProperty]
        public int liczbaSlow { get; set; }

        [BindProperty(SupportsGet =true)]        
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        private readonly Slownik.Models.SlownikContext _context;

        public IndexModel(Slownik.Models.SlownikContext context, ISlowaRepository productRepository)
        {
            _context = context;
            _slowaRepository = productRepository;
        }
        public PaginatedList<Entity.Slowa> Slowa { get; set; }

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

        //public async Task OnGetAsync(int? pageIndex, string SearchString)
        //{           
        //    //currentFilter = SearchString;
        //    //var skip = (PageIndex - 1) * PageSize;
        //    //var take = PageSize;         

        //    if (!string.IsNullOrEmpty(SearchString))
        //    {
        //        pageIndex = 1;
        //        IQueryable<Entity.Slowa> slowa = from m in _context.Slowa
        //                                         where (m.Polski.Contains(SearchString) || m.Angielski.Contains(SearchString))
        //                                         select m;
        //        liczbaSlow = SearchString.Length;
        //        if (liczbaSlow >= 1)
        //        {
        //            Count = await slowa.CountAsync();
        //            TotalPages = (int)Math.Ceiling(Decimal.Divide(Count, PageSize));
        //            //int pageSize = 2;
        //            Slowa = await PaginatedList<Entity.Slowa>.CreateAsync(
        //            slowa.AsNoTracking(), pageIndex ?? 1, PageSize);
        //        }
        //    }
        //    if (SearchString == null)
        //    {
        //        IQueryable<Entity.Slowa> slowa = from m in _context.Slowa
        //                                         select m;
        //        Count = await slowa.CountAsync();
        //        TotalPages = (int)Math.Ceiling(Decimal.Divide(Count, PageSize));
        //        //int pageSize = 2;
        //        Slowa = await PaginatedList<Entity.Slowa>.CreateAsync(
        //        slowa.AsNoTracking(), pageIndex ?? 1, PageSize);
        //    }
        //}

        public async Task OnGetAsync(string sortOrder,
string currentFilter, string searchString, int? pageIndex)
        {
            PolskiSort = String.IsNullOrEmpty(sortOrder) ? "Polski" : "";
            AngielskiSort = sortOrder == "Angielski" ? "Angielski" : "Angielski";
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
            SortOrder = sortOrder;

            IQueryable<Entity.Slowa> slowa = from s in _context.Slowa
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
            Slowa = await PaginatedList<Entity.Slowa>.CreateAsync(
                slowa.AsNoTracking(), pageIndex ?? 1, PageSize);
            CurrentPage = pageIndex ?? CurrentPage;
            searchString = SearchString;
            SortOrder = sortOrder;
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        ISlowaRepository _slowaRepository;      

        [TempData]
        public string Message { get; set; }          

        public IActionResult OnPostSave(int id, string user_id)
        {          
            user_id = User.Identity.Name;
            var count = _slowaRepository.SaveSlowo(id, user_id);
            if (count > 0)
            {
                Message = "Zapisano";
                return RedirectToPage("/Slowa/Ulubione");
            }
            return Page();
        }    
        

    }
}
