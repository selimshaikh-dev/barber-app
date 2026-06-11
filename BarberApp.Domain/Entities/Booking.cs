using BarberApp.Domain.Common;
using BarberApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberApp.Domain.Entities
{
    public class Booking : BaseEntity
    {
        public int ClientId { get; set; }
        public int ShopId { get; set; }
        public int? StaffId { get; set; }

        public DateTime BookingDate { get; set; }
        public TimeSpan BookingTime { get; set; }

        public BookingStatus Status { get; set; }
        // Pending / Accepted / Rejected / Completed / Cancelled

        public int EstimatedDurationMinutes { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public decimal TotalAmount { get; set; }
        public string? Notes { get; set; }

        public User Client { get; set; }
        public Shop Shop { get; set; }
    }
}