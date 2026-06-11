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

        // Payment Gateway Information
        public PaymentGateway? Gateway { get; set; }   // bKash, Nagad, SSLCommerz, Stripe

        public string? GatewayTransactionId { get; set; } // Gateway's transaction/reference id

        public DateTime? PaidAt { get; set; }

        public string? Remarks { get; set; }

        // Navigation Properties
        public Booking Booking { get; set; }

        public User User { get; set; }
    }
}