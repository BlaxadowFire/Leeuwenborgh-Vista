namespace CinemaApp.Models
{
    public class PlayOrderModel
    {
        public int OrderId { get; set; }
        public int PlayId { get; set; }
        public int CustomerId { get; set; }
        public bool Paid { get; set; }
    }
}
