using BarberApp.Domain.Common;

namespace BarberApp.Domain.Entities
{
    public class Message : BaseEntity
    {
        public int ChatId { get; set; }
        public int SenderId { get; set; }

        public string MessageText { get; set; }

        public Chat Chat { get; set; }
        public User Sender { get; set; }
    }
}