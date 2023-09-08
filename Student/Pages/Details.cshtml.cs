using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hello_World.Data;
using Hello_World.Models;

namespace Hello_World.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Hello_World.Data.Hello_WorldContext _context;

        public DetailsModel(Hello_World.Data.Hello_WorldContext context)
        {
            _context = context;
        }

        public Students Students { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Students = await _context.Students.FirstOrDefaultAsync(m => m.ID == id);

            if (Students == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
