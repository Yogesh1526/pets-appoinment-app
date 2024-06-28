using AutoMapper;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;
using System.Linq.Expressions;

namespace HealingPaws.Services.Services;

public class PetService : BaseService<PetEntity, PetRequestModel, PetResponseModel>, IPetService
{
    private static readonly Expression<Func<PetEntity, object>>[] includeProperties = { e => e.PetBreed, e => e.PetOwner, e => e.PetType };
    public PetService(IRepository<PetEntity> repository, IMapper mapper) : base(repository, mapper, includeProperties) { 
    }

    public async Task<IEnumerable<PetResponseModel>> GetAllByOwnerIdAsync(int petOwnerId)
    {
        var entities = await _repository.FindAsync(f=>f.PetOwnerId == petOwnerId);
        return _mapper.Map<IEnumerable<PetResponseModel>>(entities);
    }
}
