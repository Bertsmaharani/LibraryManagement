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
            AddingBook newForm = new(books);
            newForm.Show();
            RefreshBookGrid();
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
            else if(book != null && book.IsIssued && book.Quantity > 0)
            {
                book.Quantity--;
                RefreshBookGrid();
            }
        }

        private void ButtonDeleteBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdBook.Text);
            books.RemoveAll(b => b.ID == id);
            RefreshBookGrid();
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
        }
        private void RefreshBookGrid()
        {
            ListBooks.DataSource = null;
            ListBooks.DataSource = books;
            FileStream fs = new(@"D:\1.txt", FileMode.Create);
            StreamWriter streamWriter = new(fs);
            try
            {
                for (int j = 0; j < ListBooks.Rows.Count; j++)
                {
                    for (int i = 0; i < ListBooks.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(ListBooks.Rows[j].Cells[i].Value + "     ");
                    }

                    streamWriter.WriteLine();
                }

                streamWriter.Close();
                fs.Close();

                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }
    }
}
