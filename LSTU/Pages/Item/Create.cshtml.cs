using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LSTU.Data;
using LSTU.Models;

namespace LSTU.Pages.Item
{
    public class CreateModel : PageModel
    {
        private readonly LSTU.Data.LSTUContext _context;

        public CreateModel(LSTU.Data.LSTUContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Items Items { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Items.Add(Items);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
