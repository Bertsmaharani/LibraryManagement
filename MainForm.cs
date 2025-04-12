using System.Windows.Forms;
using static LibraryManagement.LibraryClass;
using System.Windows.Forms.VisualStyles;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Microsoft.VisualBasic.ApplicationServices;

namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public BindingList<Book> books = [];

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIdBook.Text) || string.IsNullOrEmpty(textBoxTitle.Text)
                    || string.IsNullOrEmpty(textBoxYear.Text) || string.IsNullOrEmpty(textBoxQuantity.Text)
                    || string.IsNullOrEmpty(textBoxAuthor.Text) || string.IsNullOrEmpty(comboBoxStatus.Text))
                {
                    throw new Exception("Все поля должны быть заполнены!");
                }
                Book book = new()
                {
                    ID = Convert.ToInt32(textBoxIdBook.Text),
                    Title = textBoxTitle.Text,
                    Author = textBoxAuthor.Text,
                    Year = Convert.ToInt32(textBoxYear.Text),
                    Quantity = Convert.ToInt32(textBoxQuantity.Text),
                    IsIssued = (comboBoxStatus.Text == "Доступна") ? (true) : (false),
                };
                books.Add(book);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RefreshBookGrid();
                comboBoxStatus.Text = string.Empty;
                textBoxIdBook.Text = string.Empty;
                textBoxTitle.Text = string.Empty;
                textBoxAuthor.Text = string.Empty;
                textBoxYear.Text = string.Empty;
                textBoxQuantity.Text = string.Empty;
            }
        }

        private void ButtonGiveOutBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIdBook.Text))
                {
                    throw new Exception("Поле Id книги обязательно для заполнения!");
                }
                int id = Convert.ToInt32(textBoxIdBook.Text);
                var book = books.FirstOrDefault(b => b.ID == id);
                if (book != null && book.IsIssued && book.Quantity == 1)
                {
                    book.IsIssued = false;
                    book.Quantity--;
                    RefreshBookGrid();
                }
                else if (book != null && book.IsIssued && book.Quantity > 1)
                {
                    book.Quantity--;
                    RefreshBookGrid();
                }
                textBoxIdBook.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIdBook.Text))
                {
                    throw new Exception("Поле Id книги обязательно для заполнения!");
                }
                int id = Convert.ToInt32(textBoxIdBook.Text);
                IReadOnlyList<Book> bookToRemove = books.Where(b => (b.ID == id)).ToList();
                foreach (Book book in bookToRemove)
                {
                    books.Remove(book);
                }
                RefreshBookGrid();
                textBoxIdBook.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIdBook.Text))
                {
                    throw new Exception("Поле Id книги обязательно для заполнения!");
                }
                int id = Convert.ToInt32(textBoxIdBook.Text);
                var book = books.FirstOrDefault(b => b.ID == id);
                if (book != null && book.IsIssued && book.Quantity > 0)
                {
                    book.Quantity++;
                    RefreshBookGrid();
                }
                else if (book != null && !book.IsIssued && book.Quantity == 0)
                {
                    book.IsIssued = true;
                    book.Quantity++;
                    RefreshBookGrid();
                }
                textBoxIdBook.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshBookGrid()
        {
            ListBooks.DataSource = null;
            ListBooks.DataSource = books;
            ListBooks.ReadOnly = false;
            //ListBooks.Columns[0].HeaderText = "Id книги";
            ListBooks.Columns[0].HeaderText = "Название";
            ListBooks.Columns[1].HeaderText = "Автор";
            ListBooks.Columns[2].HeaderText = "Год издания";
            ListBooks.Columns[3].HeaderText = "Статус";
            ListBooks.Columns[4].HeaderText = "Количество";
        }
        private static void SaveDataGridViewToFile(string filePath, BindingList<Book> books)
        {
            var json = JsonConvert.SerializeObject(books, Formatting.Indented);
            using (FileStream fs = new(filePath, FileMode.Create))
            using (StreamWriter writer = new(fs))
            {
                writer.Write(json);
            }
        }
        public static BindingList<Book> LoadBooks(string filePath)
        {
            if (!File.Exists(filePath))
                return new BindingList<Book>();
            using (FileStream fs = new(filePath, FileMode.Open))
            using (StreamReader reader = new(fs))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Book>>(json);
            }
        }
        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            books = LoadBooks("BooksDataFile");
            RefreshBookGrid();
        }

        private void ButtonSaveData_Click(object sender, EventArgs e)
        {
            SaveDataGridViewToFile("BooksDataFile", books);
        }

        private void ButtonUpdateData_Click(object sender, EventArgs e)
        {

        }
    }
}