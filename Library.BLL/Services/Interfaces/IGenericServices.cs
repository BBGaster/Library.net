using AutoMapper;
using Library.BLL.Model;
using Library.DAL.Entityes;
using Library.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services.Interfaces
{
    public interface IGenericService<TEntity,TModel> 
        where TModel : class
        where TEntity : class
    {
        public TModel GetById(int key);


        public TModel Update(TModel entity);


        public bool Delete(int key);

        public bool Create(TModel entity);

        public IList<TModel> GetAll();
       

    }
}
