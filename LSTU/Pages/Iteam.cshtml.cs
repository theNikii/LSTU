using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LSTU.Pages
{
    public class IteamModel : PageModel
    {
        private readonly ILogger<IteamModel> _logger;

        public IteamModel(ILogger<IteamModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
