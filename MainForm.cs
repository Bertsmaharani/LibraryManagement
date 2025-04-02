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
            
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdBook.Text);
            books.RemoveAll(b => b.ID == id);
            //RefreshBookGrid();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {

        }
    }
}
