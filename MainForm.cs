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
            BookForm form = new BookForm(0);
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
                f.book = context.books.Where(b => b.bID == value).First();
                
                f.authors = from a in context.authors
                            where a.bID == (int)selectedRow.Cells[3].Value
                            select a;
                f.fillForm();
            }
            f.FormClosed += new FormClosedEventHandler(BookForm_Closed);
            f.Show();
            
        }

        private void BookForm_Closed(object sender, FormClosedEventArgs e)
        {
            var f = new BookFilter();
            f.viewBooks = viewBooks;
            f.btnSearch_Click(sender, e);
        }

        private void bookMenuProcess_Click(object sender, EventArgs e)
        {

        }

        private void lbRefresh_Click(object sender, EventArgs e)
        {
            var f = new BookFilter();
            f.viewBooks = viewBooks;
            f.btnSearch_Click(sender, e);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            pFirst.Visible = false;
            pBook.Visible = true;
            // 
            // bookMenu
            // 
            this.bookMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.bookMenuView,
            this.bookMenuProcess});
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            pFirst.Visible = false;
            pReader.Visible = true;
            // 
            // bookMenu
            // 
            this.bookMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemReaderView,
            this.menuItemReaderProcess});
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            pFirst.Visible = false;
            pLang.Visible = true;
            // 
            // bookMenu
            // 
            this.bookMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeleteLang});
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            pFirst.Visible = false;
            pCategory.Visible = true;
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            var f = new BookFilter();
            f.viewBooks = viewBooks;
            f.btnSearch_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pBook.Visible = false;
            pFirst.Visible = true;
            viewBooks.DataSource = null;
            
            this.bookMenu.MenuItems.Clear();
        }

        private void btnAllReaders_Click(object sender, EventArgs e)
        {
            using (context = new LibContext(LibConnection.GetConnString()))
            {
                var tabe = context.readers_.Select(c => new
                {
                    Name = c.name,
                    Middle_Name = c.middleName,
                    Surname = c.surname,
                    PassportSeria = c.passport,
                    OpenDate = c.openDate,
                    CloseDate = c.closeDate
                }).Distinct();
                viewBooks.DataSource = tabe;
                viewBooks.RowHeadersVisible = false;
            }
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            AddReaders aa = new AddReaders();
            aa.ShowDialog();
        }

        private void btnBackR_Click(object sender, EventArgs e)
        {
            pReader.Visible = false;
            pFirst.Visible = true;
            viewBooks.DataSource = null;
            // 
            // bookMenu
            // 
            this.bookMenu.MenuItems.Clear();
        }

        private void btnAddLang_Click(object sender, EventArgs e)
        {
            categoryPanel = new CategoryPanel(0);
            pCategory.Controls.Add(categoryPanel);
            categoryPanel.Location = new System.Drawing.Point(1, 126);
            categoryPanel.Name = "panel1";
            categoryPanel.Size = new System.Drawing.Size(211, 257);
            categoryPanel.TabIndex = 12;
            categoryPanel.Visible = true;
        }

        private void btnBackC_Click(object sender, EventArgs e)
        {
            pCategory.Visible = false;
            pFirst.Visible = true;
            viewBooks.DataSource = null;
        }

        private void btnAllLang_Click(object sender, EventArgs e)
        {
            using(context = new LibContext(LibConnection.GetConnString()))
            {
                var langs = context.langs.Select(l => new { Code = l.code, Name = l.name});
                viewBooks.DataSource = langs;
            }
        }

        private void btnPanelAddLang_Click(object sender, EventArgs e)
        {
            langPanel = new LangPanel(0);
            pLang.Controls.Add(langPanel);
            langPanel.Location = new System.Drawing.Point(1, 126);
            langPanel.Name = "panel1";
            langPanel.Size = new System.Drawing.Size(211, 257);
            langPanel.TabIndex = 12;
            langPanel.Visible = true;
        }

        private void btnCategorys_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBackLang_Click(object sender, EventArgs e)
        {
            pLang.Visible = false;
            pFirst.Visible = true;
            viewBooks.DataSource = null;
            this.bookMenu.MenuItems.Clear();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void menuItemReaderView_Click(object sender, EventArgs e)
        {

        }

        private void menuItemReaderProcess_Click(object sender, EventArgs e)
        {

        }

        private void menuItemDeleteLang_Click(object sender, EventArgs e)
        {
            using(context = new LibContext(LibConnection.GetConnString()))
            {
                var lang = context.langs.Where(l => l.code == viewBooks.SelectedRows[0].Cells[0].Value.ToString().Trim()).First();
                
                context.langs.DeleteOnSubmit(lang);
                context.SubmitChanges();
            }
            btnAllLang_Click(sender, e);
        }

        
    }
}
