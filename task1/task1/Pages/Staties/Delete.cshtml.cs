using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Staties
{
    public class DeleteModel : PageModel
    {
        private IStatiesRepository __db;
        public DeleteModel(IStatiesRepository db)
        {
            __db = db;
        }

        [BindProperty]
        public Statie Statie { get; set; }

        public IActionResult OnGet(int id)
        {
            Statie = __db.GetStatie(id);
            if (Statie == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Statie = __db.Delete(Statie.StatieId);
            if (Statie == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Staties/Staties");
        }
    }
}
