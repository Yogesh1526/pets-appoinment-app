using HealingPaws.DataAccess.Context;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;

namespace HealingPaws.DataAccess.Repositories;
public class PetOwnerRepository : Repository<PetOwnerEntity>, IPetOwnerRepository
{
    public PetOwnerRepository(ApplicationDbContext context) : base(context) { }

}