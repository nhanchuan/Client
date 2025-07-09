using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCauLong.Pages
{
    public class CourtsModel : PageModel
    {
        private readonly ILogger<CourtsModel> _logger;

        public CourtsModel(ILogger<CourtsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}