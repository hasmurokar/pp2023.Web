using pp2023.Web.Pages.Domain;

namespace pp2023.Web.Models.Domain
{
	public class Orders
	{
		public int Id { get; set; }
		public int Count { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime OrderDate { get; set; }
		public List<Dish> Dish { get; set; } = new();
		public int ClientId { get; set; }
		public Users Client { get; set; }
		public int ChefId { get; set; }
		public Users Chef { get; set; }

	}
}
