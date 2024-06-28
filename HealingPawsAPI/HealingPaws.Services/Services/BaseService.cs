using AutoMapper;
using HealingPaws.DataAccess.Entities;
using HealingPaws.DataAccess.IRepositories;
using HealingPaws.Services.Interfaces.Services;
using HealingPaws.Shared.RequestModel;
using System.Linq.Expressions;

namespace HealingPaws.Services.Services
{
    public class BaseService<TEntity, TRequestModel, TResponseModel> : IBaseService<TEntity, TRequestModel, TResponseModel>
    where TEntity : BaseEntity
    where TRequestModel : BaseRequestModel
    where TResponseModel : BaseResponseModel
    {
        public readonly IRepository<TEntity> _repository;
        public readonly IMapper _mapper;
        private readonly Expression<Func<TEntity, object>>[] _includeProperties;
        public BaseService(IRepository<TEntity> repository, IMapper mapper, Expression<Func<TEntity, object>>[] includeProperties)
        {
            _repository = repository;
            _mapper = mapper;
            _includeProperties = includeProperties;
        }

        public async Task<TResponseModel> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id, _includeProperties);
            return _mapper.Map<TResponseModel>(entity);
        }

        public async Task<IEnumerable<TResponseModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync(_includeProperties);
            return _mapper.Map<IEnumerable<TResponseModel>>(entities);
        }

        public async Task<IEnumerable<TResponseModel>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entities = await _repository.FindAsync(predicate);
            return _mapper.Map<IEnumerable<TResponseModel>>(entities);
        }

        public async Task<TResponseModel> CreateAsync(TRequestModel requestModel)
        {
            var entity = _mapper.Map<TEntity>(requestModel);
            await _repository.CreateAsync(entity);
            return _mapper.Map<TResponseModel>(entity);
        }

        public async Task<bool> UpdateAsync(int id, TRequestModel requestModel)
        {
            var entity = await _repository.GetByIdWithNoIncludeAsync(id) ?? throw new KeyNotFoundException("Entity not found");
            _mapper.Map(requestModel, entity);
            return await _repository.UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdWithNoIncludeAsync(id);
            return entity == null ? throw new KeyNotFoundException("Entity not found") : await _repository.RemoveAsync(entity);
        }
    }
}
