using Library.BLL.Model;
using Library.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services.Interfaces
{
    public interface IBookService : IGenericService<Book,BookModel>
    {
    }
}
