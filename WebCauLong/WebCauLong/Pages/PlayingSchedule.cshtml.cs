using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCauLong.Pages
{
    public class PlayingScheduleModel : PageModel
    {
        private readonly ILogger<PlayingScheduleModel> _logger;

        public PlayingScheduleModel(ILogger<PlayingScheduleModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}