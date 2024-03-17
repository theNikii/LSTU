using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LSTU.Data;
using LSTU.Models;

namespace LSTU.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly LSTU.Data.LSTUContext _context;

        public IndexModel(LSTU.Data.LSTUContext context)
        {
            _context = context;
        }

        public IList<Users> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
