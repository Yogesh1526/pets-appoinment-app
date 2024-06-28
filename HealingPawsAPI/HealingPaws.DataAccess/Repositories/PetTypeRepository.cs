using HealingPaws.DataAccess.Context;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;

namespace HealingPaws.DataAccess.Repositories;
public class PetTypeRepository : Repository<PetTypeEntity>, IPetTypeRepository
{
    public PetTypeRepository(ApplicationDbContext context) : base(context) { }
}