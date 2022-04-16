using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Slownik.Entity;
using Slownik.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Slownik.Pages.Slowa
{
    public class IndexModel2 : PageModel
    {     
        ISlowaRepository _slowaRepository;
        public IndexModel2(ISlowaRepository productRepository)
        {           
         
        _slowaRepository = productRepository;
        
        }       

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty]
        public List<Entity.Slowa> productList { get; set; }      

        [BindProperty]
        public Entity.Slowa product { get; set; }

        [BindProperty]
        public int LiczbaSlow { get; set; }

        [TempData]
        public string Message { get; set; }

        public void OnGet()
        {           
                productList = _slowaRepository.GetList();             
        }     

        public void OnPost()
        {
            productList = _slowaRepository.SzukaneGetList(SearchString);
            LiczbaSlow = productList.Count();
        }
        public IActionResult OnPostDelete(int id)
        {
            if (id > 0)
            {
                var count = _slowaRepository.DeleteSlowo(id);
                if (count > 0)
                {
                    Message = "Usunięto słowo!";
                    return RedirectToPage("/Slowa/Index");
                }
            }

            return Page();
        }
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
