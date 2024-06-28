using AutoMapper;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;
using HealingPaws.Services.Interfaces.Services;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;


namespace HealingPaws.Services.Services
{
    public class AddressService : BaseService<AddressEntity, AddressRequestModel, AddressResponseModel>, IAddressService
    {
        public AddressService(IRepository<AddressEntity> repository, IMapper mapper) : base(repository, mapper, null) { }
    }
}
