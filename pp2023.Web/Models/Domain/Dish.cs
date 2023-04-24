using pp2023.Web.Models.Domain;

namespace pp2023.Web.Pages.Domain
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public double Weight { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
    }
}
