namespace Library.DAL.Entityes
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; } = new List<Book>();
    }
}
