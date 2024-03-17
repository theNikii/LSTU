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
    public class DeleteModel : PageModel
    {
        private readonly LSTU.Data.LSTUContext _context;

        public DeleteModel(LSTU.Data.LSTUContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Items.FindAsync(id);
            if (items != null)
            {
                Items = items;
                _context.Items.Remove(Items);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
