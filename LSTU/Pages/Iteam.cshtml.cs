using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LSTU.Pages
{
    public class IteamModel : PageModel
    {
        private readonly ILogger<IteamModel> _logger;

        public IteamModel(ILogger<IteamModel> logger)
        {
            _logger = logger;
        }

        public string? SearchString { get; set; }

        public void OnGet()
        {
           

        }
    }

}
