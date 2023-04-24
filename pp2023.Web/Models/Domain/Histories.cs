namespace pp2023.Web.Models.Domain
{
    public class Histories
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public List<Orders> Orders { get; set; } = new();
    }
}
