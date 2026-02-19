namespace BookStore.Classes
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Author(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}