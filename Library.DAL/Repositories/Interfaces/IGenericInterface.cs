using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repositories.Interfaces
{
    internal interface IGenericInterface<T> where T : class
    {
        
        T Entity { get; }
        bool Create(T entity);
        T Update(T entity);
        bool Delete(int key);
        IList<T> GetAll();

        T GetById(int id);
    }
}
