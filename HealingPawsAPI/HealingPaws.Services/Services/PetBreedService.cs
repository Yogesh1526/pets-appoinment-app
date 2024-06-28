using AutoMapper;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;
using HealingPaws.Services.Interfaces.Services;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;
using System.Linq.Expressions;

namespace HealingPaws.Services.Services
{

    public class PetBreedService : BaseService<PetBreedEntity, PetBreedRequestModel, PetBreedResponseModel>, IPetBreedService
    {
        private static readonly Expression<Func<PetBreedEntity, object>>[] includeProperties = { e => e.PetType };
        public PetBreedService(IRepository<PetBreedEntity> repository, IMapper mapper) : base(repository, mapper, includeProperties) { }
    }
}
