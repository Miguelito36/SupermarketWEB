using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Pay_Mode
{
    public class DeleteModel : PageModel
    {
        private readonly SumpermarketContext _context;

        public DeleteModel(SumpermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PayMode PayMode { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            PayMode = await _context.PayModes.FindAsync(id);

            if (PayMode == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var payMode = await _context.PayModes.FindAsync(id);

            if (payMode != null)
            {
                _context.PayModes.Remove(payMode);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }

}
