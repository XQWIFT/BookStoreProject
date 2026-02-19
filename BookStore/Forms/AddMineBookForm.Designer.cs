namespace BookStore
{
    partial class AddMineBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameOfBook = new System.Windows.Forms.TextBox();
            this.AddBookReady = new System.Windows.Forms.Button();
            this.labelOfAuthor = new System.Windows.Forms.Label();
            this.labelOfBookName = new System.Windows.Forms.Label();
            this.labelOfGenre = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.ComboBox();
            this.GenreOfBox = new System.Windows.Forms.ComboBox();
            this.discountYesRadio = new System.Windows.Forms.RadioButton();
            this.discountNoRadio = new System.Windows.Forms.RadioButton();
            this.labelOfDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameOfBook
            // 
            this.NameOfBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameOfBook.Location = new System.Drawing.Point(109, 120);
            this.NameOfBook.Name = "NameOfBook";
            this.NameOfBook.Size = new System.Drawing.Size(668, 26);
            this.NameOfBook.TabIndex = 5;
            // 
            // AddBookReady
            // 
            this.AddBookReady.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBookReady.AutoSize = true;
            this.AddBookReady.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.AddBookReady.Location = new System.Drawing.Point(193, 304);
            this.AddBookReady.Name = "AddBookReady";
            this.AddBookReady.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddBookReady.Size = new System.Drawing.Size(467, 134);
            this.AddBookReady.TabIndex = 8;
            this.AddBookReady.Text = "Добавить";
            this.AddBookReady.UseVisualStyleBackColor = true;
            this.AddBookReady.UseWaitCursor = true;
            // 
            // labelOfAuthor
            // 
            this.labelOfAuthor.AutoSize = true;
            this.labelOfAuthor.Location = new System.Drawing.Point(19, 37);
            this.labelOfAuthor.Name = "labelOfAuthor";
            this.labelOfAuthor.Size = new System.Drawing.Size(56, 20);
            this.labelOfAuthor.TabIndex = 9;
            this.labelOfAuthor.Text = "Автор";
            this.labelOfAuthor.Click += new System.EventHandler(this.labelOfAuthor_Click);
            // 
            // labelOfBookName
            // 
            this.labelOfBookName.AutoSize = true;
            this.labelOfBookName.Location = new System.Drawing.Point(12, 120);
            this.labelOfBookName.Name = "labelOfBookName";
            this.labelOfBookName.Size = new System.Drawing.Size(83, 20);
            this.labelOfBookName.TabIndex = 11;
            this.labelOfBookName.Text = "Название";
            // 
            // labelOfGenre
            // 
            this.labelOfGenre.AutoSize = true;
            this.labelOfGenre.Location = new System.Drawing.Point(19, 202);
            this.labelOfGenre.Name = "labelOfGenre";
            this.labelOfGenre.Size = new System.Drawing.Size(49, 20);
            this.labelOfGenre.TabIndex = 12;
            this.labelOfGenre.Text = "Жанр";
            // 
            // AuthorName
            // 
            this.AuthorName.FormattingEnabled = true;
            this.AuthorName.Location = new System.Drawing.Point(109, 37);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(668, 28);
            this.AuthorName.TabIndex = 13;
            // 
            // GenreOfBox
            // 
            this.GenreOfBox.FormattingEnabled = true;
            this.GenreOfBox.Location = new System.Drawing.Point(109, 202);
            this.GenreOfBox.Name = "GenreOfBox";
            this.GenreOfBox.Size = new System.Drawing.Size(668, 28);
            this.GenreOfBox.TabIndex = 14;
            // 
            // discountYesRadio
            // 
            this.discountYesRadio.AutoSize = true;
            this.discountYesRadio.Location = new System.Drawing.Point(333, 262);
            this.discountYesRadio.Name = "discountYesRadio";
            this.discountYesRadio.Size = new System.Drawing.Size(55, 24);
            this.discountYesRadio.TabIndex = 15;
            this.discountYesRadio.TabStop = true;
            this.discountYesRadio.Text = "Да";
            this.discountYesRadio.UseVisualStyleBackColor = true;
            // 
            // discountNoRadio
            // 
            this.discountNoRadio.AutoSize = true;
            this.discountNoRadio.Location = new System.Drawing.Point(410, 262);
            this.discountNoRadio.Name = "discountNoRadio";
            this.discountNoRadio.Size = new System.Drawing.Size(64, 24);
            this.discountNoRadio.TabIndex = 16;
            this.discountNoRadio.TabStop = true;
            this.discountNoRadio.Text = "Нет";
            this.discountNoRadio.UseVisualStyleBackColor = true;
            // 
            // labelOfDiscount
            // 
            this.labelOfDiscount.AutoSize = true;
            this.labelOfDiscount.Location = new System.Drawing.Point(189, 262);
            this.labelOfDiscount.Name = "labelOfDiscount";
            this.labelOfDiscount.Size = new System.Drawing.Size(112, 20);
            this.labelOfDiscount.TabIndex = 17;
            this.labelOfDiscount.Text = "Есть скидка?";
            // 
            // AddMineBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOfDiscount);
            this.Controls.Add(this.discountNoRadio);
            this.Controls.Add(this.discountYesRadio);
            this.Controls.Add(this.GenreOfBox);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.labelOfGenre);
            this.Controls.Add(this.labelOfBookName);
            this.Controls.Add(this.labelOfAuthor);
            this.Controls.Add(this.AddBookReady);
            this.Controls.Add(this.NameOfBook);
            this.Name = "AddMineBookForm";
            this.Text = "AddMineBookForm";
            this.Load += new System.EventHandler(this.AddMineBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameOfBook;
        private System.Windows.Forms.Button AddBookReady;
        private System.Windows.Forms.Label labelOfAuthor;
        private System.Windows.Forms.Label labelOfBookName;
        private System.Windows.Forms.Label labelOfGenre;
        private System.Windows.Forms.ComboBox AuthorName;
        private System.Windows.Forms.ComboBox GenreOfBox;
        private System.Windows.Forms.RadioButton discountYesRadio;
        private System.Windows.Forms.RadioButton discountNoRadio;
        private System.Windows.Forms.Label labelOfDiscount;
    }
}