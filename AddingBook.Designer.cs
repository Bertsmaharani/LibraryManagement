namespace LibraryManagement
{
    partial class AddingBook
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
            buttonAddNew = new Button();
            labelAdding = new Label();
            NameBook = new Label();
            Author = new Label();
            YearPublishing = new Label();
            Status = new Label();
            Quantity = new Label();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxYear = new TextBox();
            textBoxQuantity = new TextBox();
            comboBoxStatus = new ComboBox();
            textBoxIDBook = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAddNew
            // 
            buttonAddNew.Anchor = AnchorStyles.None;
            buttonAddNew.AutoSize = true;
            buttonAddNew.Location = new Point(340, 388);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(120, 40);
            buttonAddNew.TabIndex = 0;
            buttonAddNew.Text = "Добавить";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // labelAdding
            // 
            labelAdding.Dock = DockStyle.Top;
            labelAdding.Location = new Point(0, 0);
            labelAdding.Name = "labelAdding";
            labelAdding.Size = new Size(800, 25);
            labelAdding.TabIndex = 1;
            labelAdding.Text = "Добавление новой книги";
            labelAdding.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameBook
            // 
            NameBook.Anchor = AnchorStyles.None;
            NameBook.AutoSize = true;
            NameBook.Location = new Point(370, 82);
            NameBook.Name = "NameBook";
            NameBook.Size = new Size(90, 25);
            NameBook.TabIndex = 2;
            NameBook.Text = "Название";
            // 
            // Author
            // 
            Author.Anchor = AnchorStyles.None;
            Author.AutoSize = true;
            Author.Location = new Point(637, 82);
            Author.Name = "Author";
            Author.Size = new Size(63, 25);
            Author.TabIndex = 3;
            Author.Text = "Автор";
            // 
            // YearPublishing
            // 
            YearPublishing.Anchor = AnchorStyles.None;
            YearPublishing.AutoSize = true;
            YearPublishing.Location = new Point(89, 236);
            YearPublishing.Name = "YearPublishing";
            YearPublishing.Size = new Size(112, 25);
            YearPublishing.TabIndex = 4;
            YearPublishing.Text = "Год издания";
            // 
            // Status
            // 
            Status.Anchor = AnchorStyles.None;
            Status.AutoSize = true;
            Status.Location = new Point(376, 236);
            Status.Name = "Status";
            Status.Size = new Size(63, 25);
            Status.TabIndex = 5;
            Status.Text = "Статус";
            // 
            // Quantity
            // 
            Quantity.Anchor = AnchorStyles.None;
            Quantity.AutoSize = true;
            Quantity.Location = new Point(620, 236);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(107, 25);
            Quantity.TabIndex = 6;
            Quantity.Text = "Количество";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = AnchorStyles.None;
            textBoxTitle.Location = new Point(324, 126);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(182, 31);
            textBoxTitle.TabIndex = 7;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Anchor = AnchorStyles.None;
            textBoxAuthor.Location = new Point(586, 126);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(182, 31);
            textBoxAuthor.TabIndex = 8;
            // 
            // textBoxYear
            // 
            textBoxYear.Anchor = AnchorStyles.None;
            textBoxYear.Location = new Point(59, 294);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(182, 31);
            textBoxYear.TabIndex = 9;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Anchor = AnchorStyles.None;
            textBoxQuantity.Location = new Point(586, 294);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(182, 31);
            textBoxQuantity.TabIndex = 11;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.None;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Доступна", "Недоступна" });
            comboBoxStatus.Location = new Point(324, 292);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(182, 33);
            comboBoxStatus.TabIndex = 12;
            // 
            // textBoxIDBook
            // 
            textBoxIDBook.Location = new Point(59, 126);
            textBoxIDBook.Name = "textBoxIDBook";
            textBoxIDBook.Size = new Size(182, 31);
            textBoxIDBook.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 82);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 14;
            label1.Text = "label1";
            // 
            // AddingBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBoxIDBook);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTitle);
            Controls.Add(Quantity);
            Controls.Add(Status);
            Controls.Add(YearPublishing);
            Controls.Add(Author);
            Controls.Add(NameBook);
            Controls.Add(labelAdding);
            Controls.Add(buttonAddNew);
            Name = "AddingBook";
            Text = "AddingBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddNew;
        private Label labelAdding;
        private Label NameBook;
        private Label Author;
        private Label YearPublishing;
        private Label Status;
        private Label Quantity;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxYear;
        private TextBox textBoxQuantity;
        private ComboBox comboBoxStatus;
        private TextBox textBoxIDBook;
        private Label label1;
    }
}