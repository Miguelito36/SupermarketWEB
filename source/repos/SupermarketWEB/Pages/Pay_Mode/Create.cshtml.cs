using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;

namespace SupermarketWEB.Pages.Pay_Mode
{
    public class CreateModel : PageModel
    {
        private readonly SumpermarketContext _context;

        [BindProperty]
        public Pay_Mode PayMode { get; set; }

        public CreateModel(SumpermarketContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PayModes.Add(PayMode);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }

}
