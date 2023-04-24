using pp2023.Web.Pages.Domain;

namespace pp2023.Web.Models.Domain
{
	public class Order
	{
		public int Id { get; set; }
		public int Count { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime OrderDate { get; set; }
		public List<Dish> Dishes { get; set; } = new();
		public int ClientId { get; set; }
		public User Client { get; set; }
		public int ChefId { get; set; }
		public User Chef { get; set; }

	}
}
