using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dog_Pet.Data;

namespace Dog_Pet.Pages.PetStor
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
            return Page();
        }

        [BindProperty]
        public PetStores PetStores { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PetStores.Add(PetStores);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
