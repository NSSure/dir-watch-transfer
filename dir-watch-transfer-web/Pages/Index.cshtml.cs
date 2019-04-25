using System.IO;
using System.Threading.Tasks;
using DirWatchTransfer.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DirWatchTransfer.Pages
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