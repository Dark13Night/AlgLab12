using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Authors
{
    public class DeleteModel : PageModel
    {
        private IAuthorsRepository __db;
        public DeleteModel(IAuthorsRepository db)
        {
            __db = db;
        }

        [BindProperty]
        public Author Author { get; set; }

        public IActionResult OnGet(int id)
        {
            Author = __db.GetAuthor(id);
            if (Author == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Author = __db.Delete(Author.AuthorId);
            if (Author == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Authors/Authors");
        }
    }
}
