using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.DAL.Entityes
{
    public class Book
    {
        
        public int ID { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CraetedDate { get; set; }
        [ForeignKey("AuthorID")]
        public required int AuthorID { get; set; }
        public virtual Author? Author { get; set; }
        public List<Category> Categories { get;  }= new List<Category>();
    }


}
