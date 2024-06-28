using HealingPaws.DataAccess.Entities;
using HealingPaws.Services.Interfaces.Services;
using HealingPaws.Services.Services;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;
using Microsoft.AspNetCore.Mvc;

namespace HealingPaws.API.Controllers;
[Route("api/[controller]")]
public class AppointmentsController : BaseController<AppointmentEntity, AppointmentRequestModel, AppointmentResponseModel>
{
    public AppointmentsController(IAppointmentService service) : base(service) { }
}
