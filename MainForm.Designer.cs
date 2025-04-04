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
            libraryClassBindingSource = new BindingSource(components);
            labelID = new Label();
            NameBook = new Label();
            Author = new Label();
            YearPublishing = new Label();
            Status = new Label();
            Quantity = new Label();
            textBoxIdBook = new TextBox();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxYear = new TextBox();
            textBoxQuantity = new TextBox();
            comboBoxStatus = new ComboBox();
            libraryClassBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ListBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryClassBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryClassBindingSource1).BeginInit();
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
            GiveOutBook.Location = new Point(12, 213);
            GiveOutBook.Name = "GiveOutBook";
            GiveOutBook.Size = new Size(139, 48);
            GiveOutBook.TabIndex = 2;
            GiveOutBook.Text = "Выдать";
            GiveOutBook.UseVisualStyleBackColor = true;
            GiveOutBook.Click += ButtonGiveOutBook_Click;
            // 
            // ReturnBook
            // 
            ReturnBook.Location = new Point(12, 288);
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
            label1.Size = new Size(1027, 25);
            label1.TabIndex = 4;
            label1.Text = "Работа с книгами";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListBooks
            // 
            ListBooks.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ListBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListBooks.Location = new Point(0, 363);
            ListBooks.Name = "ListBooks";
            ListBooks.RowHeadersWidth = 62;
            ListBooks.Size = new Size(1027, 246);
            ListBooks.TabIndex = 5;
            // 
            // libraryClassBindingSource
            // 
            libraryClassBindingSource.DataSource = typeof(LibraryClass);
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(298, 55);
            labelID.Name = "labelID";
            labelID.Size = new Size(79, 25);
            labelID.TabIndex = 15;
            labelID.Text = "Id книги";
            // 
            // NameBook
            // 
            NameBook.Anchor = AnchorStyles.None;
            NameBook.AutoSize = true;
            NameBook.Location = new Point(522, 55);
            NameBook.Name = "NameBook";
            NameBook.Size = new Size(90, 25);
            NameBook.TabIndex = 16;
            NameBook.Text = "Название";
            // 
            // Author
            // 
            Author.Anchor = AnchorStyles.None;
            Author.AutoSize = true;
            Author.Location = new Point(833, 55);
            Author.Name = "Author";
            Author.Size = new Size(63, 25);
            Author.TabIndex = 17;
            Author.Text = "Автор";
            // 
            // YearPublishing
            // 
            YearPublishing.Anchor = AnchorStyles.None;
            YearPublishing.AutoSize = true;
            YearPublishing.Location = new Point(276, 186);
            YearPublishing.Name = "YearPublishing";
            YearPublishing.Size = new Size(112, 25);
            YearPublishing.TabIndex = 18;
            YearPublishing.Text = "Год издания";
            // 
            // Status
            // 
            Status.Anchor = AnchorStyles.None;
            Status.AutoSize = true;
            Status.Location = new Point(549, 186);
            Status.Name = "Status";
            Status.Size = new Size(63, 25);
            Status.TabIndex = 19;
            Status.Text = "Статус";
            // 
            // Quantity
            // 
            Quantity.Anchor = AnchorStyles.None;
            Quantity.AutoSize = true;
            Quantity.Location = new Point(821, 186);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(107, 25);
            Quantity.TabIndex = 20;
            Quantity.Text = "Количество";
            // 
            // textBoxIdBook
            // 
            textBoxIdBook.Location = new Point(289, 98);
            textBoxIdBook.Name = "textBoxIdBook";
            textBoxIdBook.Size = new Size(99, 31);
            textBoxIdBook.TabIndex = 21;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(454, 98);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(231, 31);
            textBoxTitle.TabIndex = 22;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(732, 98);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(283, 31);
            textBoxAuthor.TabIndex = 23;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(289, 230);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(99, 31);
            textBoxYear.TabIndex = 24;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(833, 230);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(81, 31);
            textBoxQuantity.TabIndex = 25;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Доступна", "Недоступна" });
            comboBoxStatus.Location = new Point(505, 230);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(150, 33);
            comboBoxStatus.TabIndex = 26;
            // 
            // libraryClassBindingSource1
            // 
            libraryClassBindingSource1.DataSource = typeof(LibraryClass);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 609);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxIdBook);
            Controls.Add(Quantity);
            Controls.Add(Status);
            Controls.Add(YearPublishing);
            Controls.Add(Author);
            Controls.Add(NameBook);
            Controls.Add(labelID);
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
            ((System.ComponentModel.ISupportInitialize)libraryClassBindingSource1).EndInit();
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
        private Label labelID;
        private Label NameBook;
        private Label Author;
        private Label YearPublishing;
        private Label Status;
        private Label Quantity;
        private TextBox textBoxIdBook;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxYear;
        private TextBox textBoxQuantity;
        private ComboBox comboBoxStatus;
        private BindingSource libraryClassBindingSource1;
    }
}
