using HealingPaws.DataAccess.Entities;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;

namespace HealingPaws.Services.Interfaces.Services;

public interface IAddressService : IBaseService<AddressEntity, AddressRequestModel, AddressResponseModel> {

}
