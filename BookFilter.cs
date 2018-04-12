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
    public partial class BookFilter : Form
    {
        public BookFilter()
        {
            InitializeComponent();
        }

        private void cbLang_DropDown(object sender, EventArgs e)
        {
            cbLang.Items.Clear();
            using (var contex = new LibContext(LibConnection.GetConnString()))
            {
                try
                {
                    var langs = contex.langs.Select(l => l.code).ToArray();
                    cbLang.Items.AddRange(langs);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(this, "Error: Could not load language\n" +
                    "Original error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbCategory_DropDown(object sender, EventArgs e)
        {
            cbCategory.Items.Clear();
            using (var contex = new LibContext(LibConnection.GetConnString()))
            {
                try
                {
                    var category = contex.categories.Select(l => l.name).ToArray();
                    cbCategory.Items.AddRange(category);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(this, "Error: Could not load categories\n" +
                    "Original error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            using (context = new LibContext(LibConnection.GetConnString()))
            {
                var authors = from a in context.authors
                              where a.name.ToLower().Contains(tbAuthorName.Text.ToLower()) &&
                                    a.surname.ToLower().Contains(tbAuthorSur.Text.ToLower())
                              select a;
                var books = from b in context.books
                            join c in authors on b.bID equals c.bID into a1
                            from a in a1.DefaultIfEmpty()
                            where b.name.ToLower().StartsWith(cbName.Text.ToLower()) &&
                                b.ISBN10.ToLower().Contains(tbISBN10.Text.ToLower()) &&
                                b.ISBN13.ToLower().Contains(tbISBN13.Text.ToLower()) &&
                                b.language.ToLower().Contains(cbLang.Text.ToLower()) &&
                                b.genre.ToLower().Contains(tbGenre.Text.ToLower()) &&
                                b.publish.ToLower().Contains(tbPub.Text.ToLower()) &&
                                b.publish.ToLower().Contains(tbPub.Text.ToLower()) &&
                                b.pubDate.ToLower().Contains(tbPubDate.Text.ToLower()) &&
                                b.pubCountry.ToLower().Contains(tbPubCntry.Text.ToLower()) &&
                                b.coverType.ToLower().Contains(cbCover.Text.ToLower()) &&
                                b.state == 0
                            select new {Name = b.name, Author = a.name.Trim() + " " + a.surname.Trim(), Genre = b.genre, ID = b.bID,
                                Language = b.language, Date = b.pubDate };
                viewBooks.RowHeadersVisible = false;
                viewBooks.DataSource = books;
                viewBooks.Columns["ID"].Visible = false;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void cbName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbName.DroppedDown = false;
        }

        private void cbName_TextUpdate(object sender, EventArgs e)
        {
            cbName.Items.Clear();

            cbName.SelectionStart = cbName.Text.Length;
            cbName.SelectionLength = 0;
            
            using (context = new LibContext(LibConnection.GetConnString()))
            {
                var books = from b in context.books
                            where b.name.ToLower().StartsWith(cbName.Text.ToLower())
                            group b by b.name into g
                            select g.Key;
                cbName.Items.AddRange(books.ToArray());
                cbName.DroppedDown = true;
            }
        }
        
    }
}
