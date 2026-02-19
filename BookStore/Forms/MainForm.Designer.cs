namespace BookStore
{
    partial class BookStoreMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ItemOfADD = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMineBook = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemOfChange = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemOfDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGridOfBooks = new System.Windows.Forms.DataGridView();
            this.CardsOfBooks = new System.Windows.Forms.Label();
            this.labelOfNameAuthor = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.ComboBox();
            this.labelNameOfBook = new System.Windows.Forms.Label();
            this.NameOfBooks = new System.Windows.Forms.ComboBox();
            this.GenreOfBooks = new System.Windows.Forms.ComboBox();
            this.labelOfGenre = new System.Windows.Forms.Label();
            this.InfoAboutDiscount = new System.Windows.Forms.Label();
            this.discountYesRadio = new System.Windows.Forms.RadioButton();
            this.discountNoRadio = new System.Windows.Forms.RadioButton();
            this.UploadFromFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnOfID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridOfBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemOfADD,
            this.ItemOfChange,
            this.ItemOfDelete});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1103, 36);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip);
            // 
            // ItemOfADD
            // 
            this.ItemOfADD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadFromFiles,
            this.AddMineBook});
            this.ItemOfADD.Name = "ItemOfADD";
            this.ItemOfADD.Size = new System.Drawing.Size(106, 30);
            this.ItemOfADD.Text = "Добавить";
            // 
            // AddMineBook
            // 
            this.AddMineBook.Name = "AddMineBook";
            this.AddMineBook.Size = new System.Drawing.Size(273, 34);
            this.AddMineBook.Text = "Добавить своё";
            // 
            // ItemOfChange
            // 
            this.ItemOfChange.Name = "ItemOfChange";
            this.ItemOfChange.Size = new System.Drawing.Size(107, 30);
            this.ItemOfChange.Text = "Изменить";
            // 
            // ItemOfDelete
            // 
            this.ItemOfDelete.Name = "ItemOfDelete";
            this.ItemOfDelete.Size = new System.Drawing.Size(92, 30);
            this.ItemOfDelete.Text = "Удалить";
            // 
            // MainGridOfBooks
            // 
            this.MainGridOfBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainGridOfBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGridOfBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainGridOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridOfBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOfID,
            this.ColumnOfBookName,
            this.ColumnOfAuthor,
            this.ColumnOfGenre});
            this.MainGridOfBooks.Location = new System.Drawing.Point(12, 36);
            this.MainGridOfBooks.Name = "MainGridOfBooks";
            this.MainGridOfBooks.RowHeadersWidth = 62;
            this.MainGridOfBooks.RowTemplate.Height = 28;
            this.MainGridOfBooks.Size = new System.Drawing.Size(701, 659);
            this.MainGridOfBooks.TabIndex = 1;
            this.MainGridOfBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridsOfBooks);
            // 
            // CardsOfBooks
            // 
            this.CardsOfBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CardsOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsOfBooks.Location = new System.Drawing.Point(719, 36);
            this.CardsOfBooks.Name = "CardsOfBooks";
            this.CardsOfBooks.Size = new System.Drawing.Size(384, 95);
            this.CardsOfBooks.TabIndex = 2;
            this.CardsOfBooks.Text = "Карточка";
            this.CardsOfBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOfNameAuthor
            // 
            this.labelOfNameAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOfNameAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOfNameAuthor.Location = new System.Drawing.Point(719, 161);
            this.labelOfNameAuthor.Name = "labelOfNameAuthor";
            this.labelOfNameAuthor.Size = new System.Drawing.Size(108, 31);
            this.labelOfNameAuthor.TabIndex = 3;
            this.labelOfNameAuthor.Text = "Автор";
            this.labelOfNameAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorName
            // 
            this.AuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorName.FormattingEnabled = true;
            this.AuthorName.Location = new System.Drawing.Point(833, 166);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(241, 28);
            this.AuthorName.TabIndex = 4;
            // 
            // labelNameOfBook
            // 
            this.labelNameOfBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfBook.Location = new System.Drawing.Point(719, 234);
            this.labelNameOfBook.Name = "labelNameOfBook";
            this.labelNameOfBook.Size = new System.Drawing.Size(108, 31);
            this.labelNameOfBook.TabIndex = 6;
            this.labelNameOfBook.Text = "Название";
            this.labelNameOfBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameOfBooks
            // 
            this.NameOfBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameOfBooks.FormattingEnabled = true;
            this.NameOfBooks.Location = new System.Drawing.Point(833, 238);
            this.NameOfBooks.Name = "NameOfBooks";
            this.NameOfBooks.Size = new System.Drawing.Size(241, 28);
            this.NameOfBooks.TabIndex = 7;
            // 
            // GenreOfBooks
            // 
            this.GenreOfBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreOfBooks.FormattingEnabled = true;
            this.GenreOfBooks.Location = new System.Drawing.Point(833, 301);
            this.GenreOfBooks.Name = "GenreOfBooks";
            this.GenreOfBooks.Size = new System.Drawing.Size(241, 28);
            this.GenreOfBooks.TabIndex = 8;
            // 
            // labelOfGenre
            // 
            this.labelOfGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOfGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOfGenre.Location = new System.Drawing.Point(719, 301);
            this.labelOfGenre.Name = "labelOfGenre";
            this.labelOfGenre.Size = new System.Drawing.Size(108, 31);
            this.labelOfGenre.TabIndex = 9;
            this.labelOfGenre.Text = "Жанр";
            this.labelOfGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoAboutDiscount
            // 
            this.InfoAboutDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoAboutDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoAboutDiscount.Location = new System.Drawing.Point(742, 375);
            this.InfoAboutDiscount.Name = "InfoAboutDiscount";
            this.InfoAboutDiscount.Size = new System.Drawing.Size(332, 31);
            this.InfoAboutDiscount.TabIndex = 10;
            this.InfoAboutDiscount.Text = "Информация о скидках";
            this.InfoAboutDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discountYesRadio
            // 
            this.discountYesRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountYesRadio.AutoSize = true;
            this.discountYesRadio.Location = new System.Drawing.Point(747, 418);
            this.discountYesRadio.Name = "discountYesRadio";
            this.discountYesRadio.Size = new System.Drawing.Size(129, 24);
            this.discountYesRadio.TabIndex = 11;
            this.discountYesRadio.TabStop = true;
            this.discountYesRadio.Text = "Скидка есть";
            this.discountYesRadio.UseVisualStyleBackColor = true;
            // 
            // discountNoRadio
            // 
            this.discountNoRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountNoRadio.AutoSize = true;
            this.discountNoRadio.Location = new System.Drawing.Point(747, 464);
            this.discountNoRadio.Name = "discountNoRadio";
            this.discountNoRadio.Size = new System.Drawing.Size(121, 24);
            this.discountNoRadio.TabIndex = 12;
            this.discountNoRadio.TabStop = true;
            this.discountNoRadio.Text = "Скидки нет";
            this.discountNoRadio.UseVisualStyleBackColor = true;
            // 
            // UploadFromFiles
            // 
            this.UploadFromFiles.Name = "UploadFromFiles";
            this.UploadFromFiles.Size = new System.Drawing.Size(273, 34);
            this.UploadFromFiles.Text = "Загрузить с файлов";
            // 
            // ColumnOfID
            // 
            this.ColumnOfID.HeaderText = "ID";
            this.ColumnOfID.MinimumWidth = 8;
            this.ColumnOfID.Name = "ColumnOfID";
            this.ColumnOfID.ReadOnly = true;
            // 
            // ColumnOfBookName
            // 
            this.ColumnOfBookName.HeaderText = "Name";
            this.ColumnOfBookName.MinimumWidth = 8;
            this.ColumnOfBookName.Name = "ColumnOfBookName";
            // 
            // ColumnOfAuthor
            // 
            this.ColumnOfAuthor.HeaderText = "Author";
            this.ColumnOfAuthor.MinimumWidth = 8;
            this.ColumnOfAuthor.Name = "ColumnOfAuthor";
            // 
            // ColumnOfGenre
            // 
            this.ColumnOfGenre.HeaderText = "Genre";
            this.ColumnOfGenre.MinimumWidth = 8;
            this.ColumnOfGenre.Name = "ColumnOfGenre";
            // 
            // BookStoreMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 742);
            this.Controls.Add(this.discountNoRadio);
            this.Controls.Add(this.discountYesRadio);
            this.Controls.Add(this.InfoAboutDiscount);
            this.Controls.Add(this.labelOfGenre);
            this.Controls.Add(this.GenreOfBooks);
            this.Controls.Add(this.NameOfBooks);
            this.Controls.Add(this.labelNameOfBook);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.labelOfNameAuthor);
            this.Controls.Add(this.CardsOfBooks);
            this.Controls.Add(this.MainGridOfBooks);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "BookStoreMainForm";
            this.Text = "Книжный магазин";
            this.Load += new System.EventHandler(this.BookStore_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridOfBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ItemOfADD;
        private System.Windows.Forms.ToolStripMenuItem ItemOfChange;
        private System.Windows.Forms.ToolStripMenuItem ItemOfDelete;
        private System.Windows.Forms.DataGridView MainGridOfBooks;
        private System.Windows.Forms.ToolStripMenuItem AddMineBook;
        private System.Windows.Forms.Label CardsOfBooks;
        private System.Windows.Forms.Label labelOfNameAuthor;
        private System.Windows.Forms.ComboBox AuthorName;
        private System.Windows.Forms.Label labelNameOfBook;
        private System.Windows.Forms.ComboBox NameOfBooks;
        private System.Windows.Forms.ComboBox GenreOfBooks;
        private System.Windows.Forms.Label labelOfGenre;
        private System.Windows.Forms.Label InfoAboutDiscount;
        private System.Windows.Forms.RadioButton discountYesRadio;
        private System.Windows.Forms.RadioButton discountNoRadio;
        private System.Windows.Forms.ToolStripMenuItem UploadFromFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfGenre;
    }
}

