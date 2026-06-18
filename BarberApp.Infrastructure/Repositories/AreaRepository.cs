using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Infrastructure.Data;

namespace BarberApp.Infrastructure.Repositories
{
    public class AreaRepository : GenericRepository<Area>, IAreaRepository
    {
        public AreaRepository(AppDbContext context) : base(context)
        {

        }
    }
}