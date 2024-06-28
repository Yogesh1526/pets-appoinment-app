using HealingPaws.DataAccess.Context;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;

namespace HealingPaws.DataAccess.Repositories;
public class PetBreedRepository : Repository<PetBreedEntity>, IPetBreedRepository
{
    public PetBreedRepository(ApplicationDbContext context) : base(context) { }
}