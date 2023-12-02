using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Magazines
{
    public class EditModel : PageModel
    {
        private readonly IMagazinesRepository magazinesRepository;

        public EditModel(IMagazinesRepository magazinesRepository)
        {
            this.magazinesRepository = magazinesRepository;
        }

        [BindProperty]
        public Magazine Magazine { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Magazine = magazinesRepository.GetMagazine(id.Value);
            }
            else
            {
                Magazine = new Magazine();
            }

            if (Magazine == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(Magazine magazine)
        {
            if (Magazine.MagazineId > 0)
            {
                Magazine = magazinesRepository.Update(magazine);
            }
            else
            {
                Magazine = magazinesRepository.Add(magazine);
            }

            return RedirectToPage("/Magazines/Magazines");
        }
    }
}
