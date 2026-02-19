namespace BookStore.Classes
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public bool isDiscount;
        public int IdCount = 1;

        public Book(int BookId, string Name, int AuthorId, int GenreId, bool isDiscount)
        {
            this.BookId = BookId;
            this.Name = Name;
            this.AuthorId = AuthorId;
            this.GenreId = GenreId;
            this.isDiscount = isDiscount;
            IdCount += 1;
        }

        public Book(string Name, int AuthorId, int GenreId, bool isDiscount)
        {
            this.Name = Name;
            this.AuthorId = AuthorId;
            this.GenreId = GenreId;
            this.isDiscount = isDiscount;
            BookId = IdCount;
            IdCount += 1;
        }

        public string GetInfo()
        {
            return $"{Name}: {AuthorId}";
        }
    }
}
