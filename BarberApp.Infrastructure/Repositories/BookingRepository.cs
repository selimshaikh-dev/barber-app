using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Domain.Entities;
using BarberApp.Infrastructure.Data;

namespace BarberApp.Infrastructure.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(AppDbContext context) : base(context)
        {

        }
    }
}