using Library.DAL.Entityes;
using Library.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repositories
{
    public class GenericRepository<T> : IGenericInterface<T> where T : class
    {
        private LibraryDbContext _context;
        public DbSet<T> _table;
        

        public T Entity { get; }

        public GenericRepository(LibraryDbContext _context)
        {
            this._context = _context;
            _table = _context.Set<T>();
        }

        public bool Create(T entity)
        {
            if ( entity.Equals(null)) {
                Console.WriteLine("la classe è nulla o vuota");
                return false;
            }
           _table.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public bool Delete( int key)
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

        public IList<T> GetAll()
        {
            return _table.ToList();
        }

        public T Update(T entity)
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

        public T GetById(int key)
        {
            return _table.Find(key);
        }
    }
}
