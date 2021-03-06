﻿using System;
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
                    Book newBook = new Book();
                    fillBook(newBook);
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

                            if (viewAuthors.Rows[0].Cells[0].Value != null)
                            {
                                for (int i = 0; i < viewAuthors.RowCount - 1; i++)
                                {
                                    Author newAuthor = new Author();
                                    fillAuthor(newAuthor, i, newBook.bID);
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

        private void fillAuthor(Author author, int i, int bID)
        {

            author.name = viewAuthors.Rows[i].Cells[0].Value?.ToString();
            author.surname = viewAuthors.Rows[i].Cells[1].Value?.ToString();
            author.middleName = viewAuthors.Rows[i].Cells[2].Value?.ToString();
            author.bID = bID;
            
        }

        private void fillBook(Book book)
        {
            book.name = tbName.Text;
            book.ISBN10 = tbISBN10.Text;
            book.ISBN13 = tbISBN13.Text;
            book.language = cbLang.Text;
            book.genre = tbGenre.Text;
            book.department = cbCategory.Text;
            book.publish = tbPub.Text;
            book.pubDate = tbPubDate.Text;
            book.pubCountry = tbPubCntry.Text;
            book.restriction = cbRest.Text;
            book.coverType = cbCover.Text;
            book.cover = imageBytes;
            book.description = tbAbout.Text;
            book.state = 0;
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
                var ms = new MemoryStream(book.cover);
                pbCover.Image = (Image)new Bitmap(Image.FromStream(ms), pbCover.Size);
            }
            
            var auth = from a in authors
                       select a;
            //viewAuthors.Rows.AddRange();
            foreach (var a in auth)
            {
                viewAuthors.Rows.Add(new object[] { a.name?.Trim(), a.surname?.Trim(), a.middleName?.Trim() });
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
                var bookDel = context.books.Where(b => b.bID == book.bID).First();
                context.books.DeleteOnSubmit(bookDel);
                var auths = context.authors.Where(a => a.bID == book.bID);
                foreach (var a in auths)
                {
                    context.authors.DeleteOnSubmit(a);
                }
                context.SubmitChanges();
            }
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            using(context = new LibContext(LibConnection.GetConnString()))
            {
                var book1 = context.books.Where(b => b.bID == book.bID).First();
                fillBook(book1);
                var author1 = context.authors.Where(a => a.bID == book.bID);
                if (viewAuthors.RowCount - 1 >= author1.Count())
                {
                    int i = 0;
                    foreach (var a in author1)
                    {
                        fillAuthor(a, i, book.bID);
                        i++;
                    }
                    if (viewAuthors.RowCount > author1.Count())
                    {
                        for (int j = i; j < viewAuthors.RowCount -1; j++)
                        {
                            Author a = new Author();
                            fillAuthor(a, j, book.bID);
                            context.authors.InsertOnSubmit(a);
                        }
                    }

                }
                else
                {
                    int i = 0;
                    foreach (var a in author1)
                    {
                        if (i < viewAuthors.RowCount - 1)
                        {
                            fillAuthor(a, i, book.bID);
                        }
                        else
                        {
                            context.authors.DeleteOnSubmit(a);
                        }
                        i++;
                    }
                }
                
                context.SubmitChanges();
            }
            btnDone.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = true;
            foreach (Control c in tabControl.Controls)
            {
                c.Enabled = false;
            }
        }

    }
}
