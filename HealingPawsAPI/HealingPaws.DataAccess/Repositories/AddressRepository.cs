using HealingPaws.DataAccess.Context;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;

namespace HealingPaws.DataAccess.Repositories;

public class AddressRepository : Repository<AddressEntity>, IAddressRepository
{
    public AddressRepository(ApplicationDbContext context) : base(context) { }
}