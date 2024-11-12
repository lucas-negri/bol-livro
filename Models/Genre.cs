namespace bolte.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

       // public ICollection<Book> Book { get; set; } = new List<Book>();

        public Genre()
        {
        
        
        }

        public Genre(int id, string name)
        {
            Id=id;
            Name=name;
        }


    }
}
