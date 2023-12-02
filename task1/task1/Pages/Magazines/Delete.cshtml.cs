using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Magazines
{
    public class DeleteModel : PageModel
    {
        private IMagazinesRepository __db;
        public DeleteModel(IMagazinesRepository db)
        {
            __db = db;
        }

        [BindProperty]
        public Magazine Magazine { get; set; }

        public IActionResult OnGet(int id)
        {
            Magazine = __db.GetMagazine(id);
            if (Magazine == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Magazine = __db.Delete(Magazine.MagazineId);
            if (Magazine == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Magazines/Magazines");
        }
    }
}
