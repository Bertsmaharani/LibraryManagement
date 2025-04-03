namespace LibraryManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AddBook = new Button();
            DeleteBook = new Button();
            GiveOutBook = new Button();
            ReturnBook = new Button();
            label1 = new Label();
            ListBooks = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnTitle = new DataGridViewTextBoxColumn();
            ColumnAuthor = new DataGridViewTextBoxColumn();
            ColumnYear = new DataGridViewTextBoxColumn();
            ColumnQuantity = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            libraryClassBindingSource = new BindingSource(components);
            textBoxIdBook = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ListBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryClassBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddBook
            // 
            AddBook.Location = new Point(12, 55);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(139, 48);
            AddBook.TabIndex = 0;
            AddBook.Text = "Добавление";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += ButtonAddBook_Click;
            // 
            // DeleteBook
            // 
            DeleteBook.Location = new Point(12, 135);
            DeleteBook.Name = "DeleteBook";
            DeleteBook.Size = new Size(139, 48);
            DeleteBook.TabIndex = 1;
            DeleteBook.Text = "Удалить";
            DeleteBook.UseVisualStyleBackColor = true;
            DeleteBook.Click += ButtonDeleteBook_Click;
            // 
            // GiveOutBook
            // 
            GiveOutBook.Location = new Point(247, 55);
            GiveOutBook.Name = "GiveOutBook";
            GiveOutBook.Size = new Size(139, 48);
            GiveOutBook.TabIndex = 2;
            GiveOutBook.Text = "Выдать";
            GiveOutBook.UseVisualStyleBackColor = true;
            GiveOutBook.Click += ButtonGiveOutBook_Click;
            // 
            // ReturnBook
            // 
            ReturnBook.Location = new Point(247, 135);
            ReturnBook.Name = "ReturnBook";
            ReturnBook.Size = new Size(139, 48);
            ReturnBook.TabIndex = 3;
            ReturnBook.Text = "Вернуть";
            ReturnBook.UseVisualStyleBackColor = true;
            ReturnBook.Click += ButtonReturnBook_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 25);
            label1.TabIndex = 4;
            label1.Text = "Работа с книгами";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListBooks
            // 
            ListBooks.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ListBooks.AutoGenerateColumns = false;
            ListBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListBooks.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnTitle, ColumnAuthor, ColumnYear, ColumnQuantity, ColumnStatus });
            ListBooks.DataSource = libraryClassBindingSource;
            ListBooks.Location = new Point(0, 204);
            ListBooks.Name = "ListBooks";
            ListBooks.RowHeadersWidth = 62;
            ListBooks.Size = new Size(800, 246);
            ListBooks.TabIndex = 5;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "Id книги";
            ColumnID.MinimumWidth = 8;
            ColumnID.Name = "ColumnID";
            // 
            // ColumnTitle
            // 
            ColumnTitle.HeaderText = "Название";
            ColumnTitle.MinimumWidth = 8;
            ColumnTitle.Name = "ColumnTitle";
            // 
            // ColumnAuthor
            // 
            ColumnAuthor.HeaderText = "Автор";
            ColumnAuthor.MinimumWidth = 8;
            ColumnAuthor.Name = "ColumnAuthor";
            // 
            // ColumnYear
            // 
            ColumnYear.HeaderText = "Год издания";
            ColumnYear.MinimumWidth = 8;
            ColumnYear.Name = "ColumnYear";
            // 
            // ColumnQuantity
            // 
            ColumnQuantity.HeaderText = "Количество";
            ColumnQuantity.MinimumWidth = 8;
            ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Статус";
            ColumnStatus.MinimumWidth = 8;
            ColumnStatus.Name = "ColumnStatus";
            // 
            // libraryClassBindingSource
            // 
            libraryClassBindingSource.DataSource = typeof(LibraryClass);
            // 
            // textBoxIdBook
            // 
            textBoxIdBook.Location = new Point(565, 106);
            textBoxIdBook.Name = "textBoxIdBook";
            textBoxIdBook.Size = new Size(150, 31);
            textBoxIdBook.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 109);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBoxIdBook);
            Controls.Add(ListBooks);
            Controls.Add(label1);
            Controls.Add(ReturnBook);
            Controls.Add(GiveOutBook);
            Controls.Add(DeleteBook);
            Controls.Add(AddBook);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Библиотека им. Ф.М. Достоевского";
            ((System.ComponentModel.ISupportInitialize)ListBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)libraryClassBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBook;
        private Button DeleteBook;
        private Button GiveOutBook;
        private Button ReturnBook;
        private Label label1;
        private DataGridView ListBooks;
        private BindingSource libraryClassBindingSource;
        private TextBox textBoxIdBook;
        private Label label2;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnTitle;
        private DataGridViewTextBoxColumn ColumnAuthor;
        private DataGridViewTextBoxColumn ColumnYear;
        private DataGridViewTextBoxColumn ColumnQuantity;
        private DataGridViewTextBoxColumn ColumnStatus;
    }
}
