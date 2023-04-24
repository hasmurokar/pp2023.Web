namespace pp2023.Web.Models.Domain
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? FathersName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public int Phone { get; set; }
        public string ImageUrl { get; set; }
        public List<UserRole> UserRoles { get; set; } = new();
        public List<Orders> ClientOrders { get; set; } = new();
        public List<Orders> ChefOrders { get; set; } = new();

    }
}
