using AutoMapper;
using Library.BLL.Model;
using Library.BLL.Services.Interfaces;
using Library.DAL.Entityes;
using Library.DAL.Repositories.Interfaces;
using System;

namespace Library.BLL.Services
{
    internal class GenericServices<TEntity, TModel> : IGenericService<TEntity, TModel>
        where TModel : class
        where TEntity : class
    {
        public TModel Model { get; }
        public TEntity Entity { get; }

        private readonly IGenericInterface<TEntity> _repository;
        private readonly IMapper _mapper;

        public GenericServices(IMapper mapper, IGenericInterface<TEntity> repository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public TModel GetById(int key)
        {
            if (key <= 0)
                throw new ArgumentException("The key must be a positive integer.", nameof(key));

            var entity = _repository.GetById(key);
            if (entity == null)
                throw new KeyNotFoundException($"No entity found with key {key}.");

            return _mapper.Map<TModel>(entity);
        }

        public TModel Update(TModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            try
            {
                var entity = _mapper.Map<TEntity>(model);
                var updatedEntity = _repository.Update(entity);

                if (updatedEntity == null)
                    throw new InvalidOperationException("Failed to update the entity.");

                return _mapper.Map<TModel>(updatedEntity);
            }
            catch (Exception ex)
            {
                // Log the exception (assuming a logger is available)
                // _logger.LogError(ex, "An error occurred while updating the entity.");

                throw new ApplicationException("An error occurred while updating the entity.", ex);
            }
        }

        public bool Delete(int key)
        {
            if (key <= 0 )
                throw new ArgumentException("The key must be a positive integer.", nameof(key));

            return _repository.Delete(key);
        }

        public bool Create(TModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            var entity = _mapper.Map<TEntity>(model);
            return _repository.Create(entity);
        }
    }
}
