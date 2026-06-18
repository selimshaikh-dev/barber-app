using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Infrastructure.Data;

namespace BarberApp.Infrastructure.Repositories
{
    public class ThanaRepository : GenericRepository<Thana>, IThanaRepository
    {
        public ThanaRepository(AppDbContext context) : base(context)
        {

        }
    }
}