using HealingPaws.DataAccess.Context;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;

namespace HealingPaws.DataAccess.Repositories;
public class AppointmentRepository : Repository<AppointmentEntity>, IAppointmentRepository
{
    public AppointmentRepository(ApplicationDbContext context) : base(context) { }
}