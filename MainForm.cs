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
        Library.LibContext context;

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
            var f = new BookFilter();
            f.viewBooks = viewBooks;
            f.Show(); 
        }

        private void button_Readers_Click(object sender, EventArgs e)
        {
            Form f = new Readers();
            f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form f = new BookFilter();
            f.Show();
        }

        private void viewBooks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                viewBooks.ClearSelection();
                int currentMouseOverRow = viewBooks.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0 )
                {
                    viewBooks.Rows[currentMouseOverRow].Selected = true;
                }
                bookMenu.Show(viewBooks, new Point(e.X, e.Y));

            }
        }

        private void bookMenuView_Click(object sender, EventArgs e)
        {
            var f = new BookForm(1);
           
            foreach (Control c in f.tabControl.Controls)
            {
                c.Enabled = false;
            }

            using (context = new LibContext(LibConnection.GetConnString()))
            {
                DataGridViewRow selectedRow = viewBooks.SelectedRows[0];
                int value = (int)selectedRow.Cells[3].Value;
                var book = context.books.Where(b => b.bID == value).First();
                
                f.book = book;

                f.authors = from a in context.authors
                            where a.bID == (int)selectedRow.Cells[3].Value
                            select a;
                //f.authors = authors;
                f.fillForm();
            }

            f.Show();
        }

        private void bookMenuProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
