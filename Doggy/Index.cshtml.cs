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
    public class IndexModel : PageModel
    {
        private readonly Dog_Pet.Data.ApplicationDbContext _context;

        public IndexModel(Dog_Pet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dogs> Dogs { get;set; }

        public async Task OnGetAsync()
        {
            Dogs = await _context.Dogs
                .Include(d => d.PetSID).ToListAsync();
        }
    }
}
