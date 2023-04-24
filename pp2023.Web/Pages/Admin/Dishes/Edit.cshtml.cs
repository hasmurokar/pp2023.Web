using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using pp2023.Web.Data;
using pp2023.Web.Pages.Domain;
using System.Xml.Linq;

namespace pp2023.Web.Pages.Admin.Dishes
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext appDbContext;
        [BindProperty]
        public Dish Dish { get; set; }

        public EditModel(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void OnGet(Guid id)
        {
           Dish = appDbContext.Dishes.Find(id);
        }
        public IActionResult OnPostEdit()
        {
            var exsDish = appDbContext.Dishes.Find(Dish.Id);
            if (exsDish is null)
            {
                return BadRequest();
            }
            exsDish.Name = Dish.Name;
            exsDish.Price = Dish.Price;
            exsDish.Description = Dish.Description;
            exsDish.Contents = Dish.Contents;
            exsDish.Weight = Dish.Weight;
            exsDish.ImageUrl = Dish.ImageUrl;
            appDbContext.SaveChangesAsync();
            return RedirectToPage("/Admin/Dishes/List");
        }
        public IActionResult OnPostDelete()
        {
            var exsDish = appDbContext.Dishes.Find(Dish.Id);
            if (exsDish != null)
            {
                appDbContext.Dishes.Remove(exsDish);
                appDbContext.SaveChangesAsync();
                return RedirectToPage("/Admin/Dishes/List");
            }
            return Page();
        }
    }
}
