using AutoMapper;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;
using System.Linq.Expressions;

namespace HealingPaws.Services.Services
{
    public class AppointmentService : BaseService<AppointmentEntity, AppointmentRequestModel, AppointmentResponseModel>, IAppointmentService
    {
        private static readonly Expression<Func<AppointmentEntity, object>>[] includeProperties = { e => e.PetOwner, e => e.Pet };
        public AppointmentService(IRepository<AppointmentEntity> repository, IMapper mapper) : base(repository, mapper, includeProperties) { }
    }
}
