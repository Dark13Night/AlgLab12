using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Authors
{
    public class EditModel : PageModel
    {
        private readonly IAuthorsRepository authorsRepository;

        public EditModel(IAuthorsRepository authorsRepository)
        {
            this.authorsRepository = authorsRepository;
        }

        [BindProperty]
        public Author Author { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Author = authorsRepository.GetAuthor(id.Value);
            } else
            {
                Author = new Author();
            }

            if (Author == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(Author author)
        {
            if (Author.AuthorId > 0)
            {
                Author = authorsRepository.Update(author);
            } else
            {
                Author = authorsRepository.Add(author);
            }

            return RedirectToPage("/Clients/Clients");
        }
    }
}
