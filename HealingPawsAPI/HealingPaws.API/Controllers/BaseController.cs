using HealingPaws.DataAccess.Entities;

using HealingPaws.Services.Interfaces.Services;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;
using Microsoft.AspNetCore.Mvc;

namespace HealingPaws.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController<TEntity, TRequestModel, TResponseModel> : ControllerBase
    where TEntity : BaseEntity
    where TRequestModel : BaseRequestModel
    where TResponseModel : BaseResponseModel
{
    protected readonly IBaseService<TEntity, TRequestModel, TResponseModel> _service;

    public BaseController(IBaseService<TEntity, TRequestModel, TResponseModel> service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TResponseModel>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(new APIResponseModel<IEnumerable<TResponseModel>>
        {
            Status = "Success",
            Message = "Data retrieved successfully",
            Data = result
        });
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TResponseModel>> GetById(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound(new APIResponseModel<TResponseModel>
            {
                Status = "Error",
                Message = "Data not found",
                Data = default
            });
        }
        return Ok(new APIResponseModel<TResponseModel>
        {
            Status = "Success",
            Message = "Data retrieved successfully",
            Data = result
        });
    }

    [HttpPost]
    public async Task<ActionResult<TResponseModel>> Create(TRequestModel requestModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new APIResponseModel<TResponseModel>
            {
                Status = "Error",
                Message = "Invalid data",
                Data = default
            });
        }
        var result = await _service.CreateAsync(requestModel);
        return CreatedAtAction(nameof(GetById), new { id = requestModel.Id }, new APIResponseModel<TResponseModel>
        {
            Status = "Success",
            Message = "Data created successfully",
            Data = result
        });
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TResponseModel>> Update(int id, TRequestModel requestModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new APIResponseModel<TResponseModel>
            {
                Status = "Error",
                Message = "Invalid data",
                Data = default
            });
        }
        var success = await _service.UpdateAsync(id, requestModel);
        if (!success)
        {
            return NotFound(new APIResponseModel<bool>
            {
                Status = "Error",
                Message = "Update failed",
                Data = false
            });
        }
        return Ok(new APIResponseModel<bool>
        {
            Status = "Success",
            Message = "Data updated successfully",
            Data = true
        });
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        var success = await _service.DeleteAsync(id);
        if (!success)
        {
            return NotFound(new APIResponseModel<bool>
            {
                Status = "Error",
                Message = "Delete failed",
                Data = false
            });
        }
        return Ok(new APIResponseModel<bool>
        {
            Status = "Success",
            Message = "Data deleted successfully",
            Data = true
        });
    }
}
