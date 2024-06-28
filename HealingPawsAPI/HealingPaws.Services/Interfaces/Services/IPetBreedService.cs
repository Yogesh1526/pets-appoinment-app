using HealingPaws.DataAccess.Entities;
using HealingPaws.Services.Interfaces.Services;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;

namespace HealingPaws.Services.Services;
public interface IAppointmentService : IBaseService<AppointmentEntity, AppointmentRequestModel, AppointmentResponseModel> { }
