using BookStore.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BookStore
{
    public partial class BookStoreMainForm : Form
    {
        List<Book> books = new List<Book>();
        List<Author> authors = new List<Author>();
        List<Genre> genres = new List<Genre>();
        public BookStoreMainForm()
        {
            InitializeComponent();

            MainGridOfBooks.CellClick += booksGrid_CellClick;
            UploadFromFiles.Click += UploadFromFiles_Click;
            AddMineBook.Click += AddBookColumn;
            ItemOfChange.Click += ItemOfChange_Click;
            ItemOfDelete.Click += ItemOfDelete_Click;
            AddMineBook.Click += AddBookColumn;
        }

        private void LoadDataFromFiles()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var filesDir = Path.Combine(baseDir, "Files");
            string[] authorLines = File.ReadAllLines(Path.Combine(baseDir, "Files/Authors.txt"));
            foreach (string line in authorLines)
            {
                string[] parts = line.Split('.');
                if (parts.Length == 2)
                {
                    authors.Add(new Author(int.Parse(parts[0]), parts[1].Trim()));
                }
            }

            string[] genreLines = File.ReadAllLines(Path.Combine(baseDir, "Files/Genres.txt"));
            foreach (string line in genreLines)
            {
                string[] parts = line.Split('.');
                if (parts.Length == 2)
                {
                    genres.Add(new Genre(int.Parse(parts[0]), parts[1].Trim()));
                }
            }

            string[] bookLines = File.ReadAllLines(Path.Combine(baseDir, "Files/Books.txt"));
            foreach (string line in bookLines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    string[] idAndName = parts[0].Trim().Split('.');
                    books.Add(new Book(
                        int.Parse(idAndName[0]),
                        idAndName[1].Trim(),
                        int.Parse(parts[1].Trim()),
                        int.Parse(parts[2].Trim()),
                        bool.Parse(parts[3].Trim())
                    ));
                }
            }
        }

        private void UploadFromFiles_Click(object sender, EventArgs e)
        {
            LoadDataFromFiles();
            ShowBooksInGrid();
            FillComboBoxes();
            MessageBox.Show("Данные загружены из файлов!");
        }

        private void AddBookColumn(object sender, EventArgs e)
        {
            AddMineBookForm addForm = new AddMineBookForm(books, authors, genres);
            addForm.FormClosed += (s, args) =>
            {
                ShowBooksInGrid();
            };
            addForm.ShowDialog();
        }

        private void ItemOfChange_Click(object sender, EventArgs e)
        {
            if (MainGridOfBooks.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу для изменения");
                return;
            }

            string bookName = MainGridOfBooks.CurrentRow.Cells[1].Value.ToString();
            Book bookToEdit = null;

            foreach (var book in books)
            {
                if (book.Name == bookName)
                {
                    bookToEdit = book;
                    break;
                }
            }

            if (bookToEdit != null)
            {
                MessageBox.Show("Здесь будет редактирование книги: " + bookToEdit.Name);
            }
        }

        private void ItemOfDelete_Click(object sender, EventArgs e)
        {
            if (MainGridOfBooks.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу для удаления");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить книгу?", "Подтверждение",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string bookName = MainGridOfBooks.CurrentRow.Cells[1].Value.ToString();

                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Name == bookName)
                    {
                        books.RemoveAt(i);
                        break;
                    }
                }

                ShowBooksInGrid();
                MessageBox.Show("Книга удалена!");
            }
        }

        private void ShowBooksInGrid()
        {
            MainGridOfBooks.Rows.Clear();

            foreach (var book in books)
            {
                string authorName = "Неизвестно";
                foreach (var a in authors)
                {
                    if (a.Id == book.AuthorId)
                        authorName = a.Name;
                }

                string genreName = "Неизвестно";
                foreach (var g in genres)
                {
                    if (g.Id == book.GenreId)
                        genreName = g.Name;
                }

                MainGridOfBooks.Rows.Add(
                    book.BookId,
                    book.Name,
                    authorName,
                    genreName
                );
            }
        }

        private void FillComboBoxes()
        {
            AuthorName.Items.Clear();
            foreach (var author in authors)
            {
                AuthorName.Items.Add(author.Name);
            }

            GenreOfBooks.Items.Clear();
            foreach (var genre in genres)
            {
                GenreOfBooks.Items.Add(genre.Name);
            }

            NameOfBooks.Items.Clear();
            foreach (var book in books)
            {
                NameOfBooks.Items.Add(book.Name);
            }
        }

        private void booksGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MainGridOfBooks.Rows[e.RowIndex];
                int bookId = Convert.ToInt32(row.Cells[0].Value);

                foreach (var book in books)
                {
                    if (book.BookId == bookId)
                    {
                        NameOfBooks.Text = book.Name;

                        foreach (var a in authors)
                        {
                            if (a.Id == book.AuthorId)
                                AuthorName.Text = a.Name;
                        }

                        foreach (var g in genres)
                        {
                            if (g.Id == book.GenreId)
                                GenreOfBooks.Text = g.Name;
                        }

                        if (book.isDiscount)
                            discountYesRadio.Checked = true;
                        else
                            discountNoRadio.Checked = true;

                        break;
                    }
                }
            }
        }

        private void BookStore_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainGridsOfBooks(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}