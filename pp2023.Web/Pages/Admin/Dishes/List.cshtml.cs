using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pp2023.Web.Data;
using pp2023.Web.Pages.Domain;

namespace pp2023.Web.Pages.Admin.Dishes
{
    public class ListModel : PageModel
    {
        private readonly AppDbContext appDbContext;
        public List<Dish> Dishes { get; set; }

        public ListModel(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void OnGet()
        {
            Dishes = appDbContext.Dishes.ToList();
        }
    }
}
