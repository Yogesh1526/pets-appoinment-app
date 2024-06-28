using AutoMapper;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;


namespace HealingPaws.Services.Services
{

    public class PetTypeService : BaseService<PetTypeEntity, PetTypeRequestModel, PetTypeResponseModel>, IPetTypeService
    {
        public PetTypeService(IRepository<PetTypeEntity> repository, IMapper mapper) : base(repository, mapper,null) { }
    }
}
