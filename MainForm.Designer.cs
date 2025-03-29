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
            AddBook = new Button();
            DeleteBook = new Button();
            GiveOutBook = new Button();
            ReturnBook = new Button();
            SuspendLayout();
            // 
            // AddBook
            // 
            AddBook.Location = new Point(224, 115);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(139, 48);
            AddBook.TabIndex = 0;
            AddBook.Text = "Добавление";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += buttonAddBook_Click;
            // 
            // DeleteBook
            // 
            DeleteBook.Location = new Point(442, 146);
            DeleteBook.Name = "DeleteBook";
            DeleteBook.Size = new Size(112, 34);
            DeleteBook.TabIndex = 1;
            DeleteBook.Text = "Удаление";
            DeleteBook.UseVisualStyleBackColor = true;
            DeleteBook.Click += buttonDeleteBook_Click;
            // 
            // GiveOutBook
            // 
            GiveOutBook.Location = new Point(134, 272);
            GiveOutBook.Name = "GiveOutBook";
            GiveOutBook.Size = new Size(112, 34);
            GiveOutBook.TabIndex = 2;
            GiveOutBook.Text = "Выдача";
            GiveOutBook.UseVisualStyleBackColor = true;
            GiveOutBook.Click += buttonGiveOutBook_Click;
            // 
            // ReturnBook
            // 
            ReturnBook.Location = new Point(408, 269);
            ReturnBook.Name = "ReturnBook";
            ReturnBook.Size = new Size(112, 34);
            ReturnBook.TabIndex = 3;
            ReturnBook.Text = "Вовзрат";
            ReturnBook.UseVisualStyleBackColor = true;
            ReturnBook.Click += buttonReturnBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReturnBook);
            Controls.Add(GiveOutBook);
            Controls.Add(DeleteBook);
            Controls.Add(AddBook);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button AddBook;
        private Button DeleteBook;
        private Button GiveOutBook;
        private Button ReturnBook;
    }
}
