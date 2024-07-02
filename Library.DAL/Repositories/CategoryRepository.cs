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
    public class CategoryRepository : GenericRepository<Category>,ICategoryRepository
    {
       
        public CategoryRepository(LibraryDbContext _context) : base(_context)
        {
        }
    }
}
