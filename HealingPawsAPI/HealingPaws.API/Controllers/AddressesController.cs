using HealingPaws.DataAccess.Entities;
using HealingPaws.Services.Interfaces.Services;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;
using Microsoft.AspNetCore.Mvc;

namespace HealingPaws.API.Controllers;

[Route("api/[controller]")]
public class AddressesController : BaseController<AddressEntity, AddressRequestModel, AddressResponseModel>
{
    public AddressesController(IAddressService service) : base(service) { }
}