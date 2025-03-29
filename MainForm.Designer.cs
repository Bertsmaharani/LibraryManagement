﻿namespace LibraryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AddBook = new Button();
            DeleteBook = new Button();
            GiveOutBook = new Button();
            ReturnBook = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddBook
            // 
            AddBook.Location = new Point(134, 146);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(139, 48);
            AddBook.TabIndex = 0;
            AddBook.Text = "Добавление";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += buttonAddBook_Click;
            // 
            // DeleteBook
            // 
            DeleteBook.Location = new Point(134, 234);
            DeleteBook.Name = "DeleteBook";
            DeleteBook.Size = new Size(139, 48);
            DeleteBook.TabIndex = 1;
            DeleteBook.Text = "Удаление";
            DeleteBook.UseVisualStyleBackColor = true;
            DeleteBook.Click += buttonDeleteBook_Click;
            // 
            // GiveOutBook
            // 
            GiveOutBook.Location = new Point(517, 146);
            GiveOutBook.Name = "GiveOutBook";
            GiveOutBook.Size = new Size(139, 48);
            GiveOutBook.TabIndex = 2;
            GiveOutBook.Text = "Выдача";
            GiveOutBook.UseVisualStyleBackColor = true;
            GiveOutBook.Click += buttonGiveOutBook_Click;
            // 
            // ReturnBook
            // 
            ReturnBook.Location = new Point(517, 234);
            ReturnBook.Name = "ReturnBook";
            ReturnBook.Size = new Size(139, 48);
            ReturnBook.TabIndex = 3;
            ReturnBook.Text = "Вовзрат";
            ReturnBook.UseVisualStyleBackColor = true;
            ReturnBook.Click += buttonReturnBook_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ReturnBook);
            Controls.Add(GiveOutBook);
            Controls.Add(DeleteBook);
            Controls.Add(AddBook);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Библиотека им. Ф.М. Достоевского";
            ResumeLayout(false);
        }

        #endregion

        private Button AddBook;
        private Button DeleteBook;
        private Button GiveOutBook;
        private Button ReturnBook;
        private Label label1;
    }
}
