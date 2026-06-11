using BarberApp.Domain.Common;
using BarberApp.Domain.Enums;

namespace BarberApp.Domain.Entities
{
    public class PaymentLog : BaseEntity
    {
        public int PaymentId { get; set; }

        public PaymentStatus Status { get; set; }

        public string Message { get; set; }

        public Payment Payment { get; set; }
    }
}