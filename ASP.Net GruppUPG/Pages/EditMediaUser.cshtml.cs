using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.Net_GruppUPG.Objects;

namespace ASP.Net_GruppUPG.Pages
{
    public class EditMediaUserModel : PageModel
    {
        private readonly ASP.Net_GruppUPG.Objects.DatabaseContext _context;

        public EditMediaUserModel(ASP.Net_GruppUPG.Objects.DatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MediaUser MediaUser { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mediauser =  await _context.MediaUser.FirstOrDefaultAsync(m => m.Id == id);
            if (mediauser == null)
            {
                return NotFound();
            }
            MediaUser = mediauser;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MediaUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MediaUserExists(MediaUser.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("MediaUser");
        }

        private bool MediaUserExists(int id)
        {
            return _context.MediaUser.Any(e => e.Id == id);
        }
    }
}
