using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dog_Pet.Data;

namespace Dog_Pet.Pages.Doggy
{
    public class DeleteModel : PageModel
    {
        private readonly Dog_Pet.Data.ApplicationDbContext _context;

        public DeleteModel(Dog_Pet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dogs Dogs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dogs = await _context.Dogs
                .Include(d => d.PetSID).FirstOrDefaultAsync(m => m.DID == id);

            if (Dogs == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dogs = await _context.Dogs.FindAsync(id);

            if (Dogs != null)
            {
                _context.Dogs.Remove(Dogs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
