using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dog_Pet.Data;

namespace Dog_Pet.Pages.PetStor
{
    public class DetailsModel : PageModel
    {
        private readonly Dog_Pet.Data.ApplicationDbContext _context;

        public DetailsModel(Dog_Pet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public PetStores PetStores { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PetStores = await _context.PetStores.FirstOrDefaultAsync(m => m.PSID == id);

            if (PetStores == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
