using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagement.LibraryClass;

namespace LibraryManagement
{
    public partial class AddingBook : Form
    {
        private List<Book> books;
        public AddingBook(List<Book> books)
        {
            InitializeComponent();
            this.books = books;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                ID = Convert.ToInt32(textBoxIDBook.Text),
                Title = textBoxTitle.Text,
                Author = textBoxAuthor.Text,
                isIssued = Convert.ToBoolean(comboBoxStatus.Text),
                Quantity = Convert.ToInt32(textBoxQuantity.Text)
            };
            books.Add(book);
            Close();
        }
    }
}
