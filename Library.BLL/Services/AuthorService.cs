﻿using AutoMapper;
using Library.BLL.Model;
using Library.BLL.Services.Interfaces;
using Library.DAL.Entityes;
using Library.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services
{
    public class AuthorService :GenericServices<Author,AuthorModel>, IAuthorService
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthorService> _logger;

        public AuthorService(IMapper mapper, IAuthorRepository repository, ILogger<AuthorService> logger) : base(mapper, repository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


    }
}
