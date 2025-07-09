using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCauLong.Pages
{
    public class TournamentScheduleModel : PageModel
    {
        private readonly ILogger<TournamentScheduleModel> _logger;

        public TournamentScheduleModel(ILogger<TournamentScheduleModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}