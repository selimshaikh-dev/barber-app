using BarberApp.Domain.Common;
using BarberApp.Domain.Enums;

namespace BarberApp.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int BookingId { get; set; }

        public int UserId { get; set; }

        public decimal Amount { get; set; }

        public CurrencyType Currency { get; set; } = CurrencyType.BDT;

        public PaymentMethod PaymentMethod { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        public string? TransactionId { get; set; }

        public PaymentGateway? Gateway { get; set; }   

        public string? GatewayTransactionId { get; set; } 

        public DateTime? PaidAt { get; set; }

        public string? Remarks { get; set; }

        public Booking Booking { get; set; }

        public User User { get; set; }
    }
}