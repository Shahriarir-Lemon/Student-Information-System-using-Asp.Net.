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
    public class IndexModel : PageModel
    {
        private readonly Hello_World.Data.Hello_WorldContext _context;

        public IndexModel(Hello_World.Data.Hello_WorldContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
