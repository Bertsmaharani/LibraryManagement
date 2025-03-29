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
            AddingBook dlg1 = new AddingBook(books);
            dlg1.Show();
        }

        private void buttonGiveOutBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {

        }
    }
}
