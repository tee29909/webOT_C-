using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace OT.Models
{
    public class IndexModel : PageModel
    {
        private readonly OT.Models.OTContext _context;

        public IndexModel(OT.Models.OTContext context)
        {
            _context = context;
        }

        public IList<Emp> Emp { get;set; }

        public async Task OnGetAsync()
        {
            Emp = await _context.Emp.ToListAsync();
        }
    }
}
