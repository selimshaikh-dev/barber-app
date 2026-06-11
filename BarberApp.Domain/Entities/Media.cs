using BarberApp.Domain.Common;
using BarberApp.Domain.Enums;

namespace BarberApp.Domain.Entities
{
    public class Media : BaseEntity
    {
        public string EntityType { get; set; } // Shop / User / Service / Booking
        public int EntityId { get; set; }

        public string MediaUrl { get; set; }

        public MediaType MediaType { get; set; }  // 👈 HERE YOU USE IT
    }
}