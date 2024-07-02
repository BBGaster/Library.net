using AutoMapper;
using Library.BLL.Model;
using Library.BLL.Services.Interfaces;
using Library.DAL.Entityes;
using Library.DAL.Repositories;
using Library.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services
{
    public class CategoryServices : GenericServices<Category, CategoryModel>, ICategoryServices
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoryServices> _logger;

        public CategoryServices(IMapper mapper, ICategoryRepository repository, ILogger<CategoryServices> logger) : base(mapper, repository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
