using System.Collections.Generic;
using System.Data.Linq;

namespace Library
{
    partial class BookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.lbLangName = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbISBN10 = new System.Windows.Forms.Label();
            this.lbISBN13 = new System.Windows.Forms.Label();
            this.lbLang = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.viewAuthors = new System.Windows.Forms.DataGridView();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMiddName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbISBN10 = new System.Windows.Forms.TextBox();
            this.tbISBN13 = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.cbRest = new System.Windows.Forms.ComboBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lbCover = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.cbCover = new System.Windows.Forms.ComboBox();
            this.lbRest = new System.Windows.Forms.Label();
            this.lbCoverType = new System.Windows.Forms.Label();
            this.tbPubDate = new System.Windows.Forms.MaskedTextBox();
            this.lbPub = new System.Windows.Forms.Label();
            this.lbPubDate = new System.Windows.Forms.Label();
            this.lbPubCntry = new System.Windows.Forms.Label();
            this.tbPub = new System.Windows.Forms.TextBox();
            this.tbPubCntry = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nadCount = new System.Windows.Forms.NumericUpDown();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAuthors)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-4, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(521, 446);
            this.tabControl.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.lbLangName);
            this.tab1.Controls.Add(this.lbR);
            this.tab1.Controls.Add(this.cbCategory);
            this.tab1.Controls.Add(this.cbLang);
            this.tab1.Controls.Add(this.lbName);
            this.tab1.Controls.Add(this.lbISBN10);
            this.tab1.Controls.Add(this.lbISBN13);
            this.tab1.Controls.Add(this.lbLang);
            this.tab1.Controls.Add(this.lbGenre);
            this.tab1.Controls.Add(this.lbCategory);
            this.tab1.Controls.Add(this.viewAuthors);
            this.tab1.Controls.Add(this.lblAuthors);
            this.tab1.Controls.Add(this.tbName);
            this.tab1.Controls.Add(this.tbISBN10);
            this.tab1.Controls.Add(this.tbISBN13);
            this.tab1.Controls.Add(this.tbGenre);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(513, 417);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Main";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // lbLangName
            // 
            this.lbLangName.AutoSize = true;
            this.lbLangName.Location = new System.Drawing.Point(237, 148);
            this.lbLangName.Name = "lbLangName";
            this.lbLangName.Size = new System.Drawing.Size(0, 17);
            this.lbLangName.TabIndex = 22;
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.ForeColor = System.Drawing.Color.Red;
            this.lbR.Location = new System.Drawing.Point(110, 25);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(13, 17);
            this.lbR.TabIndex = 21;
            this.lbR.Text = "*";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(141, 222);
            this.cbCategory.MaxDropDownItems = 30;
            this.cbCategory.MaxLength = 25;
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(299, 24);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.DropDown += new System.EventHandler(this.cbCategory_DropDown);
            // 
            // cbLang
            // 
            this.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(141, 145);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(81, 24);
            this.cbLang.TabIndex = 3;
            this.cbLang.DropDown += new System.EventHandler(this.cbLang_DropDown);
            this.cbLang.SelectedValueChanged += new System.EventHandler(this.cbLang_SelectedValueChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(69, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "Name";
            // 
            // lbISBN10
            // 
            this.lbISBN10.AutoSize = true;
            this.lbISBN10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISBN10.Location = new System.Drawing.Point(59, 65);
            this.lbISBN10.Name = "lbISBN10";
            this.lbISBN10.Size = new System.Drawing.Size(55, 17);
            this.lbISBN10.TabIndex = 19;
            this.lbISBN10.Text = "ISBN10";
            // 
            // lbISBN13
            // 
            this.lbISBN13.AutoSize = true;
            this.lbISBN13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISBN13.Location = new System.Drawing.Point(59, 105);
            this.lbISBN13.Name = "lbISBN13";
            this.lbISBN13.Size = new System.Drawing.Size(55, 17);
            this.lbISBN13.TabIndex = 18;
            this.lbISBN13.Text = "ISBN13";
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLang.Location = new System.Drawing.Point(42, 145);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(72, 17);
            this.lbLang.TabIndex = 17;
            this.lbLang.Text = "Language";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(66, 185);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(48, 17);
            this.lbGenre.TabIndex = 16;
            this.lbGenre.Text = "Genre";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(49, 225);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(65, 17);
            this.lbCategory.TabIndex = 15;
            this.lbCategory.Text = "Category";
            // 
            // viewAuthors
            // 
            this.viewAuthors.BackgroundColor = System.Drawing.Color.Silver;
            this.viewAuthors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewAuthors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.viewAuthors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnName,
            this.clnSurname,
            this.clnMiddName});
            this.viewAuthors.Location = new System.Drawing.Point(41, 292);
            this.viewAuthors.Name = "viewAuthors";
            this.viewAuthors.RowHeadersVisible = false;
            this.viewAuthors.Size = new System.Drawing.Size(428, 98);
            this.viewAuthors.TabIndex = 6;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnName.HeaderText = "Name";
            this.clnName.Name = "clnName";
            this.clnName.Width = 130;
            // 
            // clnSurname
            // 
            this.clnSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnSurname.HeaderText = "Surname";
            this.clnSurname.Name = "clnSurname";
            this.clnSurname.Width = 180;
            // 
            // clnMiddName
            // 
            this.clnMiddName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnMiddName.HeaderText = "Middle Name";
            this.clnMiddName.Name = "clnMiddName";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.Location = new System.Drawing.Point(48, 266);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(57, 17);
            this.lblAuthors.TabIndex = 10;
            this.lblAuthors.Text = "Authors";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(141, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(299, 23);
            this.tbName.TabIndex = 0;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            // 
            // tbISBN10
            // 
            this.tbISBN10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN10.Location = new System.Drawing.Point(141, 62);
            this.tbISBN10.MaxLength = 10;
            this.tbISBN10.Name = "tbISBN10";
            this.tbISBN10.Size = new System.Drawing.Size(299, 23);
            this.tbISBN10.TabIndex = 1;
            // 
            // tbISBN13
            // 
            this.tbISBN13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN13.Location = new System.Drawing.Point(141, 102);
            this.tbISBN13.MaxLength = 13;
            this.tbISBN13.Name = "tbISBN13";
            this.tbISBN13.Size = new System.Drawing.Size(299, 23);
            this.tbISBN13.TabIndex = 2;
            this.tbISBN13.Tag = "";
            // 
            // tbGenre
            // 
            this.tbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.Location = new System.Drawing.Point(141, 182);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(299, 23);
            this.tbGenre.TabIndex = 4;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.cbRest);
            this.tab2.Controls.Add(this.btnAddImage);
            this.tab2.Controls.Add(this.lbCover);
            this.tab2.Controls.Add(this.pbCover);
            this.tab2.Controls.Add(this.cbCover);
            this.tab2.Controls.Add(this.lbRest);
            this.tab2.Controls.Add(this.lbCoverType);
            this.tab2.Controls.Add(this.tbPubDate);
            this.tab2.Controls.Add(this.lbPub);
            this.tab2.Controls.Add(this.lbPubDate);
            this.tab2.Controls.Add(this.lbPubCntry);
            this.tab2.Controls.Add(this.tbPub);
            this.tab2.Controls.Add(this.tbPubCntry);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(513, 417);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Other";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // cbRest
            // 
            this.cbRest.FormattingEnabled = true;
            this.cbRest.Location = new System.Drawing.Point(151, 190);
            this.cbRest.Name = "cbRest";
            this.cbRest.Size = new System.Drawing.Size(299, 24);
            this.cbRest.TabIndex = 3;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(292, 271);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(96, 27);
            this.btnAddImage.TabIndex = 5;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lbCover
            // 
            this.lbCover.AutoSize = true;
            this.lbCover.Location = new System.Drawing.Point(95, 271);
            this.lbCover.Name = "lbCover";
            this.lbCover.Size = new System.Drawing.Size(45, 17);
            this.lbCover.TabIndex = 34;
            this.lbCover.Text = "Cover";
            // 
            // pbCover
            // 
            this.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCover.Location = new System.Drawing.Point(151, 271);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(126, 140);
            this.pbCover.TabIndex = 33;
            this.pbCover.TabStop = false;
            // 
            // cbCover
            // 
            this.cbCover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCover.FormattingEnabled = true;
            this.cbCover.Items.AddRange(new object[] {
            "Hard",
            "Paper"});
            this.cbCover.Location = new System.Drawing.Point(151, 230);
            this.cbCover.Name = "cbCover";
            this.cbCover.Size = new System.Drawing.Size(99, 24);
            this.cbCover.TabIndex = 4;
            // 
            // lbRest
            // 
            this.lbRest.AutoSize = true;
            this.lbRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRest.Location = new System.Drawing.Point(65, 190);
            this.lbRest.Name = "lbRest";
            this.lbRest.Size = new System.Drawing.Size(75, 17);
            this.lbRest.TabIndex = 31;
            this.lbRest.Text = "Restriction";
            // 
            // lbCoverType
            // 
            this.lbCoverType.AutoSize = true;
            this.lbCoverType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoverType.Location = new System.Drawing.Point(59, 230);
            this.lbCoverType.Name = "lbCoverType";
            this.lbCoverType.Size = new System.Drawing.Size(81, 17);
            this.lbCoverType.TabIndex = 30;
            this.lbCoverType.Text = "Cover Type";
            // 
            // tbPubDate
            // 
            this.tbPubDate.Location = new System.Drawing.Point(151, 74);
            this.tbPubDate.Mask = "0000";
            this.tbPubDate.Name = "tbPubDate";
            this.tbPubDate.PromptChar = ' ';
            this.tbPubDate.Size = new System.Drawing.Size(37, 23);
            this.tbPubDate.TabIndex = 1;
            this.tbPubDate.ValidatingType = typeof(int);
            this.tbPubDate.Click += new System.EventHandler(this.tbPubDate_Click);
            // 
            // lbPub
            // 
            this.lbPub.AutoSize = true;
            this.lbPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPub.Location = new System.Drawing.Point(67, 34);
            this.lbPub.Name = "lbPub";
            this.lbPub.Size = new System.Drawing.Size(73, 17);
            this.lbPub.TabIndex = 26;
            this.lbPub.Text = "Publishing";
            // 
            // lbPubDate
            // 
            this.lbPubDate.AutoSize = true;
            this.lbPubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPubDate.Location = new System.Drawing.Point(33, 74);
            this.lbPubDate.Name = "lbPubDate";
            this.lbPubDate.Size = new System.Drawing.Size(107, 17);
            this.lbPubDate.TabIndex = 25;
            this.lbPubDate.Text = "Publishing Date";
            // 
            // lbPubCntry
            // 
            this.lbPubCntry.AutoSize = true;
            this.lbPubCntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPubCntry.Location = new System.Drawing.Point(14, 114);
            this.lbPubCntry.Name = "lbPubCntry";
            this.lbPubCntry.Size = new System.Drawing.Size(126, 17);
            this.lbPubCntry.TabIndex = 24;
            this.lbPubCntry.Text = "Publishing Country";
            // 
            // tbPub
            // 
            this.tbPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPub.Location = new System.Drawing.Point(151, 31);
            this.tbPub.Name = "tbPub";
            this.tbPub.Size = new System.Drawing.Size(299, 23);
            this.tbPub.TabIndex = 0;
            // 
            // tbPubCntry
            // 
            this.tbPubCntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPubCntry.Location = new System.Drawing.Point(151, 111);
            this.tbPubCntry.MaxLength = 13;
            this.tbPubCntry.Name = "tbPubCntry";
            this.tbPubCntry.Size = new System.Drawing.Size(299, 23);
            this.tbPubCntry.TabIndex = 2;
            this.tbPubCntry.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbAbout);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 417);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbAbout
            // 
            this.tbAbout.AcceptsReturn = true;
            this.tbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAbout.Location = new System.Drawing.Point(3, 3);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAbout.Size = new System.Drawing.Size(507, 411);
            this.tbAbout.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(189, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(406, 453);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(97, 35);
            this.bntCancel.TabIndex = 10;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(341, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nadCount
            // 
            this.nadCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nadCount.Location = new System.Drawing.Point(84, 461);
            this.nadCount.Name = "nadCount";
            this.nadCount.Size = new System.Drawing.Size(39, 23);
            this.nadCount.TabIndex = 11;
            this.nadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(123, 464);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(45, 17);
            this.lbCount.TabIndex = 12;
            this.lbCount.Text = "Count";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(270, 449);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(65, 35);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 493);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.nadCount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(533, 532);
            this.Name = "BookForm";
            this.Text = "Book";
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAuthors)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private byte[] imageBytes;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbISBN10;
        private System.Windows.Forms.TextBox tbISBN13;
        private System.Windows.Forms.DataGridView viewAuthors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbISBN10;
        private System.Windows.Forms.Label lbISBN13;
        private System.Windows.Forms.Label lbLang;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbPub;
        private System.Windows.Forms.Label lbPubDate;
        private System.Windows.Forms.Label lbPubCntry;
        private System.Windows.Forms.TextBox tbPub;
        private System.Windows.Forms.TextBox tbPubCntry;
        private System.Windows.Forms.MaskedTextBox tbPubDate;
        private System.Windows.Forms.Label lbCover;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.ComboBox cbCover;
        private System.Windows.Forms.Label lbRest;
        private System.Windows.Forms.Label lbCoverType;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMiddName;
        private System.Windows.Forms.TextBox tbAbout;
        private System.Windows.Forms.ComboBox cbRest;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nadCount;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Label lbLangName;
        private LibContext context;
        public Book book;
        public System.Linq.IQueryable<Author> authors;
    }
}