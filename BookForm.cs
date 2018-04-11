using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BookForm : Form
    {
        public BookForm(int i) //0 - for add, 1 - for view
        {
            InitializeComponent();
            if (i == 0)
            {
                this.btnEdit.Visible = false;
                this.btnDelete.Visible = false;
                this.btnDone.Visible = false;
            }
            if(i == 1)
            {
                this.btnAdd.Visible = false;
                this.nadCount.Visible = false;
                this.lbCount.Visible = false;
                this.btnDelete.Visible = false;
                this.btnDone.Visible = false;
            }
        }

       

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "BMP file|*.BMP|PNG file|*.PNG|jpeg file|*.jpg; *.jpeg|All files|*.*";
            fileDialog.FilterIndex = 3;
            fileDialog.Multiselect = false;
            try
            {
                if (fileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    pbCover.Image = (Image)new Bitmap(Image.FromStream(fileDialog.OpenFile()), pbCover.Size);
                    imageBytes = File.ReadAllBytes(fileDialog.FileName);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(this, "Error: Could not open the file\n" +
                    "Original error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void tbPubDate_Click(object sender, EventArgs e)
        {
            tbPubDate.Select(tbPubDate.Text.Length, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = true;
            if (tbName.Text.Trim().Equals(""))
            {
                tbName.BackColor = Color.Tomato;
                return;
            }
            using (context = new LibContext(LibConnection.GetConnString()))
            {
                context.Connection.Open();
                for (int j = 0; j < nadCount.Value; j ++)
                {
                    Book newBook;
                    fillBook(out newBook);
                    try
                    {
                       
                        context.Transaction = context.Connection.BeginTransaction();
                        
                            try
                            {
                                context.books.InsertOnSubmit(newBook);
                                context.SubmitChanges();
                            }
                            catch (System.Exception ex)
                            {
                                throw new Exception($"Error: Could not add book\n", ex); ;
                            }

                            if (viewAuthors.RowCount != 1)
                            {
                                for (int i = 0; i < viewAuthors.RowCount - 1; i++)
                                {
                                    Author newAuthor;
                                    fillAuthor(out newAuthor, i, newBook.bID);
                                    try
                                    {
                                        context.authors.InsertOnSubmit(newAuthor);
                                        context.SubmitChanges();
                                    }
                                    catch (System.Exception ex)
                                    {
                                        throw new Exception($"Error: Could not add author N{i}", ex);
                                    }
                                }
                            }
                            context.Transaction.Commit();
                    }
                    catch (System.Exception ex)
                    {
                        context.Transaction.Rollback();
                        //context.Connection.Close();
                        success = false;
                        MessageBox.Show(this, ex.Message + "\n" + "Original Error: " +
                            ex.InnerException?.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    //context.Connection.Close();
                }
            }
            if (success)
                this.Close();
        }

        private void fillAuthor(out Author author, int i, int bID)
        {
            author = new Author
            {
                name = viewAuthors.Rows[i].Cells[0].Value?.ToString(),
                surname = viewAuthors.Rows[i].Cells[1].Value?.ToString(),
                middleName = viewAuthors.Rows[i].Cells[2].Value?.ToString(),
                bID = bID
            };
        }

        private void fillBook(out Book book)
        {
            book = new Book
            {
                name = tbName.Text,
                ISBN10 = tbISBN10.Text,
                ISBN13 = tbISBN13.Text,
                language = cbLang.Text,
                genre = tbGenre.Text,
                department = cbCategory.Text,
                publish = tbPub.Text,
                pubDate = tbPubDate.Text,
                pubCountry = tbPubCntry.Text,
                restriction = cbRest.Text,
                coverType = cbCover.Text,
                cover = imageBytes,
                description = tbAbout.Text,
                state = 0
            };
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            tbName.BackColor = this.BackColor;
        }

        private void cbLang_DropDown(object sender, EventArgs e)
        {
            cbLang.Items.Clear();
            using(context = new LibContext(LibConnection.GetConnString()))
            {
                try
                {
                	var langs = context.langs.Select(l => l.code).ToArray();
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

        private void cbLang_SelectedValueChanged(object sender, EventArgs e)
        {
            using (context = new LibContext(LibConnection.GetConnString()))
            {
                try
                {
                    var langs = context.langs.Where(c=>c.code == cbLang.Text).Select(l => l.name);
                    lbLangName.Text = langs.First();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(this, "Error: Could not load language\n" +
                    "Original error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void fillForm()
        {
            tbName.Text = book.name;
            tbISBN10.Text = book.ISBN10;
            tbISBN13.Text = book.ISBN13;
            cbLang.Text = book.language;
            tbGenre.Text = book.genre;
            cbCategory.Text = book.department;
            tbPub.Text = book.publish;
            tbPubDate.Text = book.pubDate;
            tbPubCntry.Text = book.pubCountry;
            cbRest.Text = book.restriction;
            cbCover.Text = book.coverType;
            tbAbout.Text = book.description;
            if(book.cover != null)
            {
                var ms = new MemoryStream(book?.cover);
                pbCover.Image = (Image)new Bitmap(Image.FromStream(ms), pbCover.Size);
            }
            
            var auth = from a in authors
                       select new {Name = a.name, Surname = a.surname, MiddleName = a.middleName };
            //viewAuthors.Rows.AddRange();
            foreach (var a in auth)
            {
                viewAuthors.Rows.Add(new object[] { a.Name.Trim(), a.Surname.Trim(), a.MiddleName.Trim() });
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control c in tabControl.Controls)
            {
                c.Enabled = true;
            }
            btnDelete.Visible = true;
            btnDone.Visible = true;
            btnEdit.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(context = new LibContext(LibConnection.GetConnString()))
            {
                
            }
        }
    }
}
