using AutoMapper;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;
using System.Linq.Expressions;

namespace HealingPaws.Services.Services
{
    public class PetOwnerService : BaseService<PetOwnerEntity, PetOwnerRequestModel, PetOwnerResponseModel>, IPetOwnerService
    {
        private static readonly Expression<Func<PetOwnerEntity, object>>[] includeProperties = { e => e.Address, e => e.Pets };
        public PetOwnerService(IRepository<PetOwnerEntity> repository, IMapper mapper) : base(repository, mapper, includeProperties) { }
    }
}
