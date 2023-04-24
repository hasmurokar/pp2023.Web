using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace pp2023.Web.Models.Domain
{
    public class User
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? FathersName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string? ImageUrl { get; set; }
        public RoleEnum Role { get; set; }
        public List<Order> ClientOrders { get; set; } = new();
        public List<Order> ChefOrders { get; set; } = new();

    }
}
