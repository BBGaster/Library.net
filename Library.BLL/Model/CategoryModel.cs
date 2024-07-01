using Library.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Model
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<BookModel> Books { get; } = new List<BookModel>();
    }
}
