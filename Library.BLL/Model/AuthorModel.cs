using Library.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Model
{
    public class AuthorModel
    {
        [Key]
        public int ID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public ICollection<BookModel>? Books { get; set; } = new List<BookModel>();
    }

}
