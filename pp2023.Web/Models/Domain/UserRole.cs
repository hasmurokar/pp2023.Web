namespace pp2023.Web.Models.Domain
{
    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
    }
}
