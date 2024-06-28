using HealingPaws.DataAccess.Context;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;

namespace HealingPaws.DataAccess.Repositories;
public class PetRepository : Repository<PetEntity>, IPetRepository
{
    public PetRepository(ApplicationDbContext context) : base(context)
    {
    }
}