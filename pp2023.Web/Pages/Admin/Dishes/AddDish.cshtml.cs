using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pp2023.Web.Data;
using pp2023.Web.Pages.Domain;
using pp2023.Web.Pages.Domain.ViewModels;

namespace pp2023.Web.Pages.Admin.Dishes
{
    public class AddDishModel : PageModel
    {
        private readonly AppDbContext appDbContext;

        [BindProperty]
        public AddDish AddDishRequest { get; set; }
        public AddDishModel(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var dish = new Dish()
            {
                Name = AddDishRequest.Name,
                Price = AddDishRequest.Price,
                Description = AddDishRequest.Description,
                Contents = AddDishRequest.Contents,
                Weight = AddDishRequest.Weight,
                ImageUrl = AddDishRequest.ImageUrl
            };
            appDbContext.Dishes.Add(dish);
            appDbContext.SaveChanges();
            return RedirectToPage("/Admin/Dishes/List");
        }
    }
}
