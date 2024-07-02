using Library.DAL.Entityes;
using Library.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {


        public AuthorRepository(LibraryDbContext _context) : base(_context)
        {
        }


    }
}
