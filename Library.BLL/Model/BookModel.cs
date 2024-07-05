using Library.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.BLL.Model
{
    public class BookModel
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CraetedDate { get; set; }
        [ForeignKey("AuthorID")]

        public required int AuthorID { get; set; }
        
        public List<CategoryModel> Categories { get; } = new List<CategoryModel>();
    }
}
