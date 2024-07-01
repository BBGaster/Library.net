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
    public class BookRepositori :GenericRepository<Book>,IBookInterface
    {
        private LibraryDbContext _context;
        public DbSet<Book> _table;

        public BookRepositori(LibraryDbContext _context) : base(_context)
        {
        }

        public Book Entity { get; }

        

        public bool Create(Book entity)
        {
            if (entity.Equals(null))
            {
                Console.WriteLine("la classe è nulla o vuota");
                return false;
            }
            _table.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int key)
        {
            var entity = _table.Find(key);
            if (entity == null)
            {
                Console.WriteLine("L'entità con la chiave specificata non esiste");
                return false;
            }
            _table.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public IList<Book> GetAll()
        {
            return _table.ToList();
        }

        public Book Update(Book entity)
        {
            if (entity == null)
            {
                Console.WriteLine("L'entità è nulla o vuota");
                return null;
            }
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public Book GetById(int key)
        {
            return _table.Find(key);
        }
    }
}
