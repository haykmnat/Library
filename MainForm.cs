using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookForm form = new BookForm(0); //for add
            form.Show();
        }

        private void bntViewBook_Click(object sender, EventArgs e)
        {
            using(var context = new LibContext(LibConnection.GetConnString()))
            {
                var tabe = context.books.Select(c => new {Name = c.name, Lang = c.language, Date = c.pubDate }).Distinct();
                viewBooks.DataSource = tabe;
                viewBooks.RowHeadersVisible = false;
                
            }
        }
    }
}
