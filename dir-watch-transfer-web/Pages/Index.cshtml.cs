using System.IO;
using System.Threading.Tasks;
using dir_watch_transfer_web.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dir_watch_transfer_web.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public SymbolicLink SymbolicLink { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return Redirect("/Index");
        }
    }
}