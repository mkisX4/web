using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationContext context;

        public List<DataBase> Tickets { get; set; }
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            Tickets = context.Tickets.AsNoTracking().ToList();
        }
    }
}
