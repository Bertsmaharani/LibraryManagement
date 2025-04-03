namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public List<LibraryClass.Book> books = new List<LibraryClass.Book>();

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddingBook newForm = new AddingBook(books);
            newForm.Show();
            RefreshBookGrid();
        }

        private void buttonGiveOutBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdBook.Text);
            var book = books.FirstOrDefault(b => b.ID == id);
            if (book != null && book.isIssued && book.Quantity == 0)
            {
                book.isIssued = false;
                RefreshBookGrid();
            }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdBook.Text);
            books.RemoveAll(b => b.ID == id);
            RefreshBookGrid();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdBook.Text);
            var book = books.FirstOrDefault(b => b.ID == id);
            if (book != null && book.Quantity > 0)
            {
                RefreshBookGrid();
            }
            else if (book != null && !book.isIssued && book.Quantity == 0)
            {
                book.isIssued = true;
                RefreshBookGrid();
            }
        }
        private void RefreshBookGrid()
        {
            ListBooks.DataSource = null;
            ListBooks.DataSource = books;
        }
    }
}
