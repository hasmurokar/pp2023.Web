namespace pp2023.Web.Models.Domain
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Users> Users { get; set; } = new();
    }
}
