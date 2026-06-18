using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Infrastructure.Data;

namespace BarberApp.Infrastructure.Repositories
{
    public class DistrictRepository : GenericRepository<District>, IDistrictRepository
    {
        public DistrictRepository(AppDbContext context): base(context)
        {

        }
    }
}