using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace LSTU.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ILogger<ProfileModel> _logger;

        public ProfileModel(ILogger<ProfileModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
