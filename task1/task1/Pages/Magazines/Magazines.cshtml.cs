using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace WebServer.Pages.Magazines
{
    public class MagazinesModel : PageModel
    {
        private IMagazinesRepository __db;

        public MagazinesModel(IMagazinesRepository db)
        {
            __db = db;
        }

        public IEnumerable<Magazine> Magazines { get; set; }

        public void OnGet()
        {
            Magazines = __db.GetAllMagazines();
        }
    }
}
