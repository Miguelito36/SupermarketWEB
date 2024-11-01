using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;

namespace SupermarketWEB.Pages.Pay_Mode
{
    public class EditModel : PageModel
    {
        private readonly SumpermarketContext _context;

        public EditModel(SumpermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pay_Mode PayMode { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            PayMode = await _context.PayModes.FindAsync(id);

            if (PayMode == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PayMode).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }

}
