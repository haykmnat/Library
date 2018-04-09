namespace Library
{
    partial class BookFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookFilter));
            this.lbLangName = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbISBN10 = new System.Windows.Forms.Label();
            this.lbISBN13 = new System.Windows.Forms.Label();
            this.lbLang = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.tbISBN10 = new System.Windows.Forms.TextBox();
            this.tbISBN13 = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbPubDate = new System.Windows.Forms.MaskedTextBox();
            this.lbPub = new System.Windows.Forms.Label();
            this.lbPubDate = new System.Windows.Forms.Label();
            this.lbPubCntry = new System.Windows.Forms.Label();
            this.tbPub = new System.Windows.Forms.TextBox();
            this.tbPubCntry = new System.Windows.Forms.TextBox();
            this.cbCover = new System.Windows.Forms.ComboBox();
            this.lbCoverType = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbAuthorName = new System.Windows.Forms.Label();
            this.lbAuthorSur = new System.Windows.Forms.Label();
            this.tbAuthorName = new System.Windows.Forms.TextBox();
            this.tbAuthorSur = new System.Windows.Forms.TextBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbLangName
            // 
            this.lbLangName.AutoSize = true;
            this.lbLangName.Location = new System.Drawing.Point(242, 152);
            this.lbLangName.Name = "lbLangName";
            this.lbLangName.Size = new System.Drawing.Size(0, 13);
            this.lbLangName.TabIndex = 36;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(146, 226);
            this.cbCategory.MaxDropDownItems = 30;
            this.cbCategory.MaxLength = 25;
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(299, 21);
            this.cbCategory.TabIndex = 28;
            this.cbCategory.DropDown += new System.EventHandler(this.cbCategory_DropDown);
            // 
            // cbLang
            // 
            this.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(146, 149);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(81, 21);
            this.cbLang.TabIndex = 26;
            this.cbLang.DropDown += new System.EventHandler(this.cbLang_DropDown);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(89, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 34;
            this.lbName.Text = "Name";
            // 
            // lbISBN10
            // 
            this.lbISBN10.AutoSize = true;
            this.lbISBN10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISBN10.Location = new System.Drawing.Point(79, 70);
            this.lbISBN10.Name = "lbISBN10";
            this.lbISBN10.Size = new System.Drawing.Size(55, 17);
            this.lbISBN10.TabIndex = 33;
            this.lbISBN10.Text = "ISBN10";
            // 
            // lbISBN13
            // 
            this.lbISBN13.AutoSize = true;
            this.lbISBN13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISBN13.Location = new System.Drawing.Point(79, 110);
            this.lbISBN13.Name = "lbISBN13";
            this.lbISBN13.Size = new System.Drawing.Size(55, 17);
            this.lbISBN13.TabIndex = 32;
            this.lbISBN13.Text = "ISBN13";
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLang.Location = new System.Drawing.Point(62, 150);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(72, 17);
            this.lbLang.TabIndex = 31;
            this.lbLang.Text = "Language";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(86, 190);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(48, 17);
            this.lbGenre.TabIndex = 30;
            this.lbGenre.Text = "Genre";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(69, 228);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(65, 17);
            this.lbCategory.TabIndex = 29;
            this.lbCategory.Text = "Category";
            // 
            // tbISBN10
            // 
            this.tbISBN10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN10.Location = new System.Drawing.Point(146, 66);
            this.tbISBN10.MaxLength = 10;
            this.tbISBN10.Name = "tbISBN10";
            this.tbISBN10.Size = new System.Drawing.Size(299, 23);
            this.tbISBN10.TabIndex = 24;
            // 
            // tbISBN13
            // 
            this.tbISBN13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN13.Location = new System.Drawing.Point(146, 106);
            this.tbISBN13.MaxLength = 13;
            this.tbISBN13.Name = "tbISBN13";
            this.tbISBN13.Size = new System.Drawing.Size(299, 23);
            this.tbISBN13.TabIndex = 25;
            this.tbISBN13.Tag = "";
            // 
            // tbGenre
            // 
            this.tbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.Location = new System.Drawing.Point(146, 186);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(299, 23);
            this.tbGenre.TabIndex = 27;
            // 
            // tbPubDate
            // 
            this.tbPubDate.Location = new System.Drawing.Point(146, 308);
            this.tbPubDate.Mask = "0000";
            this.tbPubDate.Name = "tbPubDate";
            this.tbPubDate.PromptChar = ' ';
            this.tbPubDate.Size = new System.Drawing.Size(37, 20);
            this.tbPubDate.TabIndex = 38;
            this.tbPubDate.ValidatingType = typeof(int);
            // 
            // lbPub
            // 
            this.lbPub.AutoSize = true;
            this.lbPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPub.Location = new System.Drawing.Point(62, 268);
            this.lbPub.Name = "lbPub";
            this.lbPub.Size = new System.Drawing.Size(73, 17);
            this.lbPub.TabIndex = 42;
            this.lbPub.Text = "Publishing";
            // 
            // lbPubDate
            // 
            this.lbPubDate.AutoSize = true;
            this.lbPubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPubDate.Location = new System.Drawing.Point(28, 308);
            this.lbPubDate.Name = "lbPubDate";
            this.lbPubDate.Size = new System.Drawing.Size(107, 17);
            this.lbPubDate.TabIndex = 41;
            this.lbPubDate.Text = "Publishing Date";
            // 
            // lbPubCntry
            // 
            this.lbPubCntry.AutoSize = true;
            this.lbPubCntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPubCntry.Location = new System.Drawing.Point(9, 348);
            this.lbPubCntry.Name = "lbPubCntry";
            this.lbPubCntry.Size = new System.Drawing.Size(126, 17);
            this.lbPubCntry.TabIndex = 40;
            this.lbPubCntry.Text = "Publishing Country";
            // 
            // tbPub
            // 
            this.tbPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPub.Location = new System.Drawing.Point(146, 265);
            this.tbPub.Name = "tbPub";
            this.tbPub.Size = new System.Drawing.Size(299, 23);
            this.tbPub.TabIndex = 37;
            // 
            // tbPubCntry
            // 
            this.tbPubCntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPubCntry.Location = new System.Drawing.Point(146, 345);
            this.tbPubCntry.MaxLength = 13;
            this.tbPubCntry.Name = "tbPubCntry";
            this.tbPubCntry.Size = new System.Drawing.Size(299, 23);
            this.tbPubCntry.TabIndex = 39;
            this.tbPubCntry.Tag = "";
            // 
            // cbCover
            // 
            this.cbCover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCover.FormattingEnabled = true;
            this.cbCover.Items.AddRange(new object[] {
            "Hard",
            "Paper"});
            this.cbCover.Location = new System.Drawing.Point(146, 384);
            this.cbCover.Name = "cbCover";
            this.cbCover.Size = new System.Drawing.Size(99, 21);
            this.cbCover.TabIndex = 43;
            // 
            // lbCoverType
            // 
            this.lbCoverType.AutoSize = true;
            this.lbCoverType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoverType.Location = new System.Drawing.Point(54, 384);
            this.lbCoverType.Name = "lbCoverType";
            this.lbCoverType.Size = new System.Drawing.Size(81, 17);
            this.lbCoverType.TabIndex = 44;
            this.lbCoverType.Text = "Cover Type";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(166, 504);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 36);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(273, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 36);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthorName.Location = new System.Drawing.Point(43, 423);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(91, 17);
            this.lbAuthorName.TabIndex = 50;
            this.lbAuthorName.Text = "Author Name";
            // 
            // lbAuthorSur
            // 
            this.lbAuthorSur.AutoSize = true;
            this.lbAuthorSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthorSur.Location = new System.Drawing.Point(23, 463);
            this.lbAuthorSur.Name = "lbAuthorSur";
            this.lbAuthorSur.Size = new System.Drawing.Size(111, 17);
            this.lbAuthorSur.TabIndex = 49;
            this.lbAuthorSur.Text = "Author Surname";
            // 
            // tbAuthorName
            // 
            this.tbAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthorName.Location = new System.Drawing.Point(146, 420);
            this.tbAuthorName.Name = "tbAuthorName";
            this.tbAuthorName.Size = new System.Drawing.Size(299, 23);
            this.tbAuthorName.TabIndex = 47;
            // 
            // tbAuthorSur
            // 
            this.tbAuthorSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthorSur.Location = new System.Drawing.Point(146, 460);
            this.tbAuthorSur.MaxLength = 10;
            this.tbAuthorSur.Name = "tbAuthorSur";
            this.tbAuthorSur.Size = new System.Drawing.Size(299, 23);
            this.tbAuthorSur.TabIndex = 48;
            // 
            // cbName
            // 
            this.cbName.AllowDrop = true;
            this.cbName.FormattingEnabled = true;
            this.cbName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbName.Location = new System.Drawing.Point(146, 30);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(299, 21);
            this.cbName.TabIndex = 0;
            this.cbName.SelectionChangeCommitted += new System.EventHandler(this.cbName_SelectionChangeCommitted);
            this.cbName.TextUpdate += new System.EventHandler(this.cbName_TextUpdate);
            // 
            // BookFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 561);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.lbAuthorName);
            this.Controls.Add(this.lbAuthorSur);
            this.Controls.Add(this.tbAuthorName);
            this.Controls.Add(this.tbAuthorSur);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbCover);
            this.Controls.Add(this.lbCoverType);
            this.Controls.Add(this.tbPubDate);
            this.Controls.Add(this.lbPub);
            this.Controls.Add(this.lbPubDate);
            this.Controls.Add(this.lbPubCntry);
            this.Controls.Add(this.tbPub);
            this.Controls.Add(this.tbPubCntry);
            this.Controls.Add(this.lbLangName);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbLang);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbISBN10);
            this.Controls.Add(this.lbISBN13);
            this.Controls.Add(this.lbLang);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.tbISBN10);
            this.Controls.Add(this.tbISBN13);
            this.Controls.Add(this.tbGenre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(533, 600);
            this.MinimumSize = new System.Drawing.Size(533, 600);
            this.Name = "BookFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLangName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbISBN10;
        private System.Windows.Forms.Label lbISBN13;
        private System.Windows.Forms.Label lbLang;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox tbISBN10;
        private System.Windows.Forms.TextBox tbISBN13;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.MaskedTextBox tbPubDate;
        private System.Windows.Forms.Label lbPub;
        private System.Windows.Forms.Label lbPubDate;
        private System.Windows.Forms.Label lbPubCntry;
        private System.Windows.Forms.TextBox tbPub;
        private System.Windows.Forms.TextBox tbPubCntry;
        private System.Windows.Forms.ComboBox cbCover;
        private System.Windows.Forms.Label lbCoverType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.Label lbAuthorSur;
        private System.Windows.Forms.TextBox tbAuthorName;
        private System.Windows.Forms.TextBox tbAuthorSur;
        public System.Windows.Forms.DataGridView viewBooks;
        private System.Windows.Forms.ComboBox cbName;
        private LibContext context;
    }
}