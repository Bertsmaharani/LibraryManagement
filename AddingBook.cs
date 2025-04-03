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

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            Book book = new()
            {
                ID = Convert.ToInt32(textBoxIDBook.Text),
                Title = textBoxTitle.Text,
                Author = textBoxAuthor.Text,
                Year = Convert.ToInt32(textBoxYear.Text),
                Quantity = Convert.ToInt32(textBoxQuantity.Text),
                IsIssued = (comboBoxStatus.Text == "Доступна") ? (true) : (false),
            };
            books.Add(book);
            Close();
        }
    }
}
