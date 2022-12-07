using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
            DataBase Init = new DataBase();
            Init.Number = "0-000";
            Init.Room = "Out of here";
            Init.Window = "0";
            Init.Time = new TimeOnly(4, 44);
            Init.Id = 0;
            Tickets.Add(Init);
        }
    }
}
