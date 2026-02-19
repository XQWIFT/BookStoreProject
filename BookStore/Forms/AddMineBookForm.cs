using BookStore.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AddMineBookForm : Form
    {
        List<Book> books;
        List<Author> authors;
        List<Genre> genres;

        public AddMineBookForm(List<Book> b, List<Author> a, List<Genre> g)
        {
            InitializeComponent();
            books = b;
            authors = a;
            genres = g;


            foreach (var author in authors)
            {
                AuthorName.Items.Add(author.Name);
            }

            foreach (var genre in genres)
            {
                GenreOfBox.Items.Add(genre.Name);
            }

            if (AuthorName.Items.Count > 0)
                AuthorName.SelectedIndex = 0;
            if (GenreOfBox.Items.Count > 0)
                GenreOfBox.SelectedIndex = 0;

            discountYesRadio.Checked = true;

            AddBookReady.Click += saveButton_Click;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameOfBook.Text))
            {
                MessageBox.Show("Введите название книги");
                return;
            }

            int newId = 1;
            foreach (var book in books)
            {
                if (book.BookId >= newId)
                    newId = book.BookId + 1;
            }

            int authorId = 1;
            string selectedAuthor = AuthorName.SelectedItem.ToString();
            foreach (var a in authors)
            {
                if (a.Name == selectedAuthor)
                    authorId = a.Id;
            }

            int genreId = 1;
            string selectedGenre = GenreOfBox.SelectedItem.ToString();
            foreach (var g in genres)
            {
                if (g.Name == selectedGenre)
                    genreId = g.Id;
            }

            Book newBook = new Book(
                newId,
                NameOfBook.Text,
                authorId,
                genreId,
                discountYesRadio.Checked
            );

            books.Add(newBook);
            MessageBox.Show("Книга добавлена!");
            this.Close();
        }

        private void AddMineBookForm_Load(object sender, EventArgs e)
        {

        }

        private void GenresOfBook(object sender, EventArgs e)
        {

        }

        private void labelOfAuthor_Click(object sender, EventArgs e)
        {
            // AddBookReady.Click += GiveInformationAboutBook;
        }

        private void GiveInformationAboutBook(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}