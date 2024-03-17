using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LSTU.Pages
{
    public class Exanple_ItemModel : PageModel
    {
        private readonly ILogger<Exanple_ItemModel> _logger;

        public Exanple_ItemModel(ILogger<Exanple_ItemModel> logger)
        {
            _logger = logger;
        }
        public string? SearchString { get; set; }

        public void OnGet()
        {
        }
    }

}
