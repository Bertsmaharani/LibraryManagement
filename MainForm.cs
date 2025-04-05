using System.Windows.Forms;
using static LibraryManagement.LibraryClass;
using System.Windows.Forms.VisualStyles;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;

namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public List<LibraryClass.Book> books = [];

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
            SaveDataGridViewToFile(@"TxtFile");
        }
        private void SaveDataGridViewToFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(content))
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        for (int i = 0; i < ListBooks.Columns.Count; i++)
                        {
                            writer.Write(ListBooks.Columns[i].HeaderText);
                            if (i < ListBooks.Columns.Count - 1)
                                writer.Write(", ");
                        }
                        writer.WriteLine();
                        foreach (DataGridViewRow row in ListBooks.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < ListBooks.Columns.Count; i++)
                                {
                                    writer.Write(row.Cells[i].Value?.ToString());
                                    if (i < ListBooks.Columns.Count - 1)
                                        writer.Write(", ");
                                }
                                writer.WriteLine();
                            }
                        }
                    }
                }
            }
        }
        public class BookLoader
        {
            public List<Book> LoadBooks(string filePath)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                if (!fileInfo.IsReadOnly)
                {
                    fileInfo.IsReadOnly = true;
                }
                List<Book> booksGrid = new List<Book>();

                try
                {
                    var lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');

                        if (parts.Length == 5)
                        {
                            Book book = new Book
                            {
                                //ID = int.Parse(parts[0]),
                                Title = parts[0],
                                Author = parts[1],
                                Year = int.Parse(parts[2]),
                                IsIssued = Boolean.Parse(parts[3]),
                                Quantity = int.Parse(parts[4])
                            };
                            booksGrid.Add(book);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при загрузке книг: {ex.Message}");
                }
                return booksGrid;
            }
        }
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            BookLoader bookLoader = new BookLoader();
            string FilePath = "TxtFile";
            books = bookLoader.LoadBooks(FilePath);
            RefreshBookGrid();
        }
    }
}