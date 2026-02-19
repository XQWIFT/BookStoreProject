namespace BookStore.Classes
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Genre(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}