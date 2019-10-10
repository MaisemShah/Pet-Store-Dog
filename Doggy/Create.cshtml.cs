using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dog_Pet.Data;

namespace Dog_Pet.Pages.Doggy
{
    public class CreateModel : PageModel
    {
        private readonly Dog_Pet.Data.ApplicationDbContext _context;

        public CreateModel(Dog_Pet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PSID"] = new SelectList(_context.Set<PetStores>(), "PSID", "PSID");
            return Page();
        }

        [BindProperty]
        public Dogs Dogs { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dogs.Add(Dogs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
