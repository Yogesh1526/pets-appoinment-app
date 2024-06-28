using HealingPaws.DataAccess.Entities;
using HealingPaws.Services.Interfaces.Services;
using HealingPaws.Services.Services;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;
using Microsoft.AspNetCore.Mvc;

namespace HealingPaws.API.Controllers;

[Route("api/[controller]")]
public class PetsController : BaseController<PetEntity, PetRequestModel, PetResponseModel>
{
    private readonly IPetService _petService;
    public PetsController(IPetService service) : base(service) {
        _petService = service;
    }

    [HttpGet("by-owner/{petOwnerId}")]
    public async Task<ActionResult<IEnumerable<PetResponseModel>>> GetAllByOwnerIdAsync([FromRoute]int petOwnerId)
    {
        var result = await _petService.GetAllByOwnerIdAsync(petOwnerId);
        return Ok(new APIResponseModel<IEnumerable<PetResponseModel>>
        {
            Status = "Success",
            Message = "Data retrieved successfully",
            Data = result
        });
    }
}