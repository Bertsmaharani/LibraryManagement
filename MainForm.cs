namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public List<LibraryClass.Book> books = new List<LibraryClass.Book>();

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddingBook newForm = new AddingBook(books);
            newForm.Show();
        }

        private void buttonGiveOutBook_Click(object sender, EventArgs e)
        {
            GiveOutBook newForm = new GiveOutBook(books);
            newForm.Show();
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook newForm = new DeleteBook(books);
            newForm.Show();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBook newForm = new ReturnBook(books);
            newForm.Show();
        }
    }
}
