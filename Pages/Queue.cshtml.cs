using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Shared
{
    public class QueueModel : PageModel
    {
        private readonly ILogger<QueueModel> _logger;

        public QueueModel(ILogger<QueueModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}