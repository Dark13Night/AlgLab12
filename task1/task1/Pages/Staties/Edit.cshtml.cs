using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Staties
{
    public class EditModel : PageModel
    {
        private readonly IStatiesRepository statiesRepository;

        public EditModel(IStatiesRepository statiesRepository)
        {
            this.statiesRepository = statiesRepository;
        }

        [BindProperty]
        public Statie Statie { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Statie = statiesRepository.GetStatie(id.Value);
            }
            else
            {
                Statie = new Statie();
            }

            if (Statie == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(Statie statie)
        {
            if (Statie.StatieId > 0)
            {
                Statie = statiesRepository.Update(statie);
            }
            else
            {
                Statie = statiesRepository.Add(statie);
            }

            return RedirectToPage("/Staties/Staties");
        }
    }
}
