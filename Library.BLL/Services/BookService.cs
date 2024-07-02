using AutoMapper;
using Library.BLL.Model;
using Library.BLL.Services.Interfaces;
using Library.DAL.Entityes;
using Library.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace Library.BLL.Services
{
    public class BookService : GenericServices<Book,BookModel>, IBookService
    {
        private readonly IBookInterface _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<BookService> _logger;

        public BookService(IMapper mapper, IBookInterface repository, ILogger<BookService> logger) : base(mapper, repository) 
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        
    }
}
