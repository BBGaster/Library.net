using AutoMapper;
using Library.BLL.Model;
using Library.DAL.Entityes;
using Library.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace Library.BLL.Services
{
    internal class BookService
    {
        private readonly IBookInterface _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<BookService> _logger;

        public BookService(IMapper mapper, IBookInterface repository, ILogger<BookService> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public BookModel GetById(int key)
        {
            if (key <= 0)
                throw new ArgumentException("The key must be a positive integer.", nameof(key));

            try
            {
                var entity = _repository.GetById(key);
                if (entity == null)
                    throw new KeyNotFoundException($"No book found with key {key}.");

                return _mapper.Map<BookModel>(entity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while getting the book by ID.");
                throw new ApplicationException("An error occurred while getting the book by ID.", ex);
            }
        }

        public BookModel Update(BookModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            try
            {
                var entity = _mapper.Map<Book>(model);
                var updatedEntity = _repository.Update(entity);

                if (updatedEntity == null)
                    throw new InvalidOperationException("Failed to update the book.");

                return _mapper.Map<BookModel>(updatedEntity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the book.");
                throw new ApplicationException("An error occurred while updating the book.", ex);
            }
        }

        public bool Delete(int key)
        {
            if (key <= 0)
                throw new ArgumentException("The key must be a positive integer.", nameof(key));

            try
            {
                return _repository.Delete(key);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the book.");
                throw new ApplicationException("An error occurred while deleting the book.", ex);
            }
        }

        public bool Create(BookModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            try
            {
                var entity = _mapper.Map<Book>(model);
                return _repository.Create(entity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the book.");
                throw new ApplicationException("An error occurred while creating the book.", ex);
            }
        }
    }
}
