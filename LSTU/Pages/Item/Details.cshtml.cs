using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LSTU.Data;
using LSTU.Models;

namespace LSTU.Pages.Item
{
    public class DetailsModel : PageModel
    {
        private readonly LSTU.Data.LSTUContext _context;

        public DetailsModel(LSTU.Data.LSTUContext context)
        {
            _context = context;
        }

        public Items Items { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Items.FirstOrDefaultAsync(m => m.Id == id);
            if (items == null)
            {
                return NotFound();
            }
            else
            {
                Items = items;
            }
            return Page();
        }
    }
}
