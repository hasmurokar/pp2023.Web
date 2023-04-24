namespace pp2023.Web.Models.Domain
{
    public class History
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
