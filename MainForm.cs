using System.Windows.Forms;
using static LibraryManagement.LibraryClass;
using System.Windows.Forms.VisualStyles;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public List<Book> books = [];

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
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
            RefreshBookGrid();
            textBoxIdBook.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            textBoxAuthor.Text = string.Empty;
            textBoxYear.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;
        }

        private void ButtonGiveOutBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdBook.Text);
            var book = books.FirstOrDefault(b => b.ID == id);
            if (book != null && book.IsIssued && book.Quantity == 0)
            {
                book.IsIssued = false;
                RefreshBookGrid();
            }
            else if (book != null && book.IsIssued && book.Quantity > 0)
            {
                book.Quantity--;
                RefreshBookGrid();
            }
            textBoxIdBook.Text = string.Empty;
        }

        private void ButtonDeleteBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdBook.Text);
            books.RemoveAll(b => b.ID == id);
            RefreshBookGrid();
            textBoxIdBook.Text = string.Empty;
        }

        private void ButtonReturnBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdBook.Text);
            var book = books.FirstOrDefault(b => b.ID == id);
            if (book != null && book.Quantity > 0)
            {
                book.Quantity++;
                RefreshBookGrid();
            }
            else if (book != null && !book.IsIssued && book.Quantity == 0)
            {
                book.IsIssued = true;
                RefreshBookGrid();
            }
            textBoxIdBook.Text = string.Empty;
        }
        private void RefreshBookGrid()
        {
            ListBooks.DataSource = null;
            ListBooks.DataSource = books;
            //ListBooks.Columns[0].HeaderText = "Id книги";
            ListBooks.Columns[0].HeaderText = "Название";
            ListBooks.Columns[1].HeaderText = "Автор";
            ListBooks.Columns[2].HeaderText = "Год издания";
            ListBooks.Columns[3].HeaderText = "Статус";
            ListBooks.Columns[4].HeaderText = "Количество";
        }
        private void SaveDataGridViewToFile(string filePath, List<Book> books)
        {
            var json = JsonConvert.SerializeObject(books, Formatting.Indented);
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(json);
            }
        }
        public List<Book> LoadBooks(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<Book>();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (StreamReader reader = new StreamReader(fs))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Book>>(json);
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
    }
}