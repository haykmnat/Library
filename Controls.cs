using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    class LangPanel: Panel
    {
        public Button btnDelete;
        public Button btnAdd;
        public TextBox tbCode;
        public TextBox tbName;
        public Label lbName;
        public Label lbCode;
        public Button btnEdit;
        public Button btnDone;
        public Label lbRName;
        public Label lbRCode;

        public LangPanel(int i)
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lbRCode = new System.Windows.Forms.Label();
            this.lbRName = new System.Windows.Forms.Label();
            this.SuspendLayout();

            if(i == 0)
            {
                btnDelete.Visible = false;
                btnDone.Visible = true;
                btnEdit.Visible = false;
            }

            if (i == 1)
            {
                btnDelete.Visible = false;
                btnDone.Visible = false;
                btnEdit.Visible = true;
            }

            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(75, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(16, 39);
            this.tbCode.MaxLength = 3;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(53, 23);
            this.tbCode.TabIndex = 0;
            this.tbCode.Enter += new System.EventHandler(this.tbCode_Enter);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(16, 94);
            this.tbName.MaxLength = 25;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(122, 23);
            this.tbName.TabIndex = 1;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(16, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(16, 19);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(41, 17);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Code";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(16, 141);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 31);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(75, 141);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(53, 31);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lbRCode
            // 
            this.lbRCode.AutoSize = true;
            this.lbRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRCode.ForeColor = System.Drawing.Color.Red;
            this.lbRCode.Location = new System.Drawing.Point(56, 19);
            this.lbRCode.Name = "lbRCode";
            this.lbRCode.Size = new System.Drawing.Size(13, 17);
            this.lbRCode.TabIndex = 9;
            this.lbRCode.Text = "*";
            // 
            // lbRName
            // 
            this.lbRName.AutoSize = true;
            this.lbRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRName.ForeColor = System.Drawing.Color.Red;
            this.lbRName.Location = new System.Drawing.Point(60, 74);
            this.lbRName.Name = "lbRName";
            this.lbRName.Size = new System.Drawing.Size(13, 17);
            this.lbRName.TabIndex = 10;
            this.lbRName.Text = "*";

            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.lbRName);
            this.Controls.Add(this.lbRCode);
            this.Name = "LangPanel";
            this.Size = new System.Drawing.Size(156, 199);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool succsse = true;
            if (tbCode.Text.Trim().Equals("") || tbName.Text.Trim().Equals(""))
            {
                if(tbCode.Text.Trim().Equals(""))
                    tbCode.BackColor = Color.Tomato;
                if (tbName.Text.Trim().Equals(""))
                    tbName.BackColor = Color.Tomato;
                return;
            }
            using (LibContext context = new LibContext(LibConnection.GetConnString()))
            {
                Language newLang;
                fillLang(out newLang);
                try
                {
                    context.langs.InsertOnSubmit(newLang);
                    context.SubmitChanges();
                }
                catch (System.Exception ex)
                {
                    succsse = false;
                    MessageBox.Show(this, "Error: Could not add language\n" +
                        "Original error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (succsse)
            {
                tbName.Clear();
                tbCode.Clear();
            }
        }

        private void fillLang(out Language newLang)
        {
            newLang = new Language
            {
                code = tbCode.Text,
                name = tbName.Text
            };
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void tbCode_Enter(object sender, EventArgs e)
        {
            tbCode.BackColor = Color.White;
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            tbName.BackColor = Color.White;
        }
    }

    class CategoryPanel : Panel
    {
        public Button btnDelete;
        public Button btnAdd;
        public TextBox tbCode;
        public TextBox tbName;
        public Label lbName;
        public Label lbCode;
        public Button btnEdit;
        public Button btnDone;
        public Label lbRName;
        public Label lbRCode;

        public CategoryPanel(int i)
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lbRCode = new System.Windows.Forms.Label();
            this.lbRName = new System.Windows.Forms.Label();
            this.SuspendLayout();

            if (i == 0)
            {
                btnDelete.Visible = false;
                btnDone.Visible = true;
                btnEdit.Visible = false;
            }

            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(75, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(16, 39);
            this.tbCode.MaxLength = 10;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(122, 23);
            this.tbCode.TabIndex = 0;
            this.tbCode.Enter += new System.EventHandler(this.tbCode_Enter);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(16, 94);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(122, 23);
            this.tbName.TabIndex = 1;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(16, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(16, 19);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(41, 17);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Code";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(16, 141);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 31);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(75, 141);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(53, 31);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lbRCode
            // 
            this.lbRCode.AutoSize = true;
            this.lbRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRCode.ForeColor = System.Drawing.Color.Red;
            this.lbRCode.Location = new System.Drawing.Point(56, 19);
            this.lbRCode.Name = "lbRCode";
            this.lbRCode.Size = new System.Drawing.Size(13, 17);
            this.lbRCode.TabIndex = 9;
            this.lbRCode.Text = "*";
            // 
            // lbRName
            // 
            this.lbRName.AutoSize = true;
            this.lbRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRName.ForeColor = System.Drawing.Color.Red;
            this.lbRName.Location = new System.Drawing.Point(60, 74);
            this.lbRName.Name = "lbRName";
            this.lbRName.Size = new System.Drawing.Size(13, 17);
            this.lbRName.TabIndex = 10;
            this.lbRName.Text = "*";

            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.lbRName);
            this.Controls.Add(this.lbRCode);
            this.Name = "CategoryPanel";
            this.Size = new System.Drawing.Size(156, 199);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool succsse = true;
            if (tbCode.Text.Trim().Equals("") || tbName.Text.Trim().Equals(""))
            {
                if (tbCode.Text.Trim().Equals(""))
                    tbCode.BackColor = Color.Tomato;
                if (tbName.Text.Trim().Equals(""))
                    tbName.BackColor = Color.Tomato;
                return;
            }
            using (LibContext context = new LibContext(LibConnection.GetConnString()))
            {
                Category newCategory;
                fillCategory(out newCategory);
                try
                {
                    context.categories.InsertOnSubmit(newCategory);
                    context.SubmitChanges();
                }
                catch (System.Exception ex)
                {
                    succsse = false;
                    MessageBox.Show(this, "Error: Could not add category\n" +
                        "Original error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (succsse)
            {
                tbName.Clear();
                tbCode.Clear();
            }
        }

        private void fillCategory(out Category newCategory)
        {
            newCategory = new Category
            {
                code = tbCode.Text,
                name = tbName.Text
            };
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void tbCode_Enter(object sender, EventArgs e)
        {
            tbCode.BackColor = Color.White;
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            tbName.BackColor = Color.White;
        }
    }
}
