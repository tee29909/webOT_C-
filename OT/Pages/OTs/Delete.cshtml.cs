using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace OT.Models
{
    public class DeleteModel : PageModel
    {
        private readonly OT.Models.OTContext _context;

        public DeleteModel(OT.Models.OTContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Emp Emp { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Emp = await _context.Emp.FirstOrDefaultAsync(m => m.EmpID == id);

            if (Emp == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Emp = await _context.Emp.FindAsync(id);

            if (Emp != null)
            {
                _context.Emp.Remove(Emp);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
