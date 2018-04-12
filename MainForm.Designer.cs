using System.Drawing;

namespace Library
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddBook = new System.Windows.Forms.Button();
            this.viewBooks = new System.Windows.Forms.DataGridView();
            this.bntViewBook = new System.Windows.Forms.Button();
            this.bookMenu = new System.Windows.Forms.ContextMenu();
            this.bookMenuView = new System.Windows.Forms.MenuItem();
            this.bookMenuProcess = new System.Windows.Forms.MenuItem();
            this.lbRefresh = new System.Windows.Forms.LinkLabel();
            this.pFirst = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnLang = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.pBook = new System.Windows.Forms.Panel();
            this.btnAllBooks = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pCategory = new System.Windows.Forms.Panel();
            this.btnAddLang = new System.Windows.Forms.Button();
            this.btnCategorys = new System.Windows.Forms.Button();
            this.btnBackC = new System.Windows.Forms.Button();
            this.pReader = new System.Windows.Forms.Panel();
            this.btnSearchReader = new System.Windows.Forms.Button();
            this.btnAllReaders = new System.Windows.Forms.Button();
            this.btnBackR = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.pLang = new System.Windows.Forms.Panel();
            this.btnPanelAddLang = new System.Windows.Forms.Button();
            this.btnAllLang = new System.Windows.Forms.Button();
            this.btnBackLang = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerProdactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.viewBooks)).BeginInit();
            this.pFirst.SuspendLayout();
            this.pBook.SuspendLayout();
            this.pCategory.SuspendLayout();
            this.pReader.SuspendLayout();
            this.pLang.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(0, 96);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(216, 35);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.AllowUserToOrderColumns = true;
            this.viewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBooks.Location = new System.Drawing.Point(0, 27);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewBooks.Size = new System.Drawing.Size(0, 535);
            this.viewBooks.TabIndex = 10;
            this.viewBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewBooks_MouseClick);
            // 
            // bntViewBook
            // 
            this.bntViewBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntViewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntViewBook.Location = new System.Drawing.Point(0, 65);
            this.bntViewBook.Name = "bntViewBook";
            this.bntViewBook.Size = new System.Drawing.Size(216, 35);
            this.bntViewBook.TabIndex = 11;
            this.bntViewBook.Text = "Search Books";
            this.bntViewBook.UseVisualStyleBackColor = false;
            this.bntViewBook.Click += new System.EventHandler(this.bntViewBook_Click);
            // 
            // bookMenu
            // 
            this.bookMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.bookMenuView,
            this.bookMenuProcess});
            // 
            // bookMenuView
            // 
            this.bookMenuView.Index = 0;
            this.bookMenuView.Text = "View";
            this.bookMenuView.Click += new System.EventHandler(this.bookMenuView_Click);
            // 
            // bookMenuProcess
            // 
            this.bookMenuProcess.Index = 1;
            this.bookMenuProcess.Text = "Process";
            this.bookMenuProcess.Click += new System.EventHandler(this.bookMenuProcess_Click);
            // 
            // lbRefresh
            // 
            this.lbRefresh.AutoSize = true;
            this.lbRefresh.Location = new System.Drawing.Point(3, 134);
            this.lbRefresh.Name = "lbRefresh";
            this.lbRefresh.Size = new System.Drawing.Size(44, 13);
            this.lbRefresh.TabIndex = 13;
            this.lbRefresh.TabStop = true;
            this.lbRefresh.Text = "Refresh";
            this.lbRefresh.Click += new System.EventHandler(this.lbRefresh_Click);
            // 
            // pFirst
            // 
            this.pFirst.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFirst.Controls.Add(this.btnHistory);
            this.pFirst.Controls.Add(this.btnCategory);
            this.pFirst.Controls.Add(this.btnLang);
            this.pFirst.Controls.Add(this.btnStaff);
            this.pFirst.Controls.Add(this.btnUsers);
            this.pFirst.Controls.Add(this.btnReader);
            this.pFirst.Controls.Add(this.btnBook);
            this.pFirst.Dock = System.Windows.Forms.DockStyle.Right;
            this.pFirst.Location = new System.Drawing.Point(753, 27);
            this.pFirst.Name = "pFirst";
            this.pFirst.Size = new System.Drawing.Size(216, 535);
            this.pFirst.TabIndex = 14;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(0, 226);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(216, 35);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(0, 194);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(216, 35);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnLang
            // 
            this.btnLang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.Location = new System.Drawing.Point(0, 162);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(216, 35);
            this.btnLang.TabIndex = 4;
            this.btnLang.Text = "Language";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(0, 130);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(216, 35);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(0, 98);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(216, 35);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "User";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReader
            // 
            this.btnReader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReader.Location = new System.Drawing.Point(0, 66);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(216, 35);
            this.btnReader.TabIndex = 1;
            this.btnReader.Text = "Reader";
            this.btnReader.UseVisualStyleBackColor = false;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(0, 34);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(216, 35);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pBook
            // 
            this.pBook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBook.Controls.Add(this.bntViewBook);
            this.pBook.Controls.Add(this.btnAllBooks);
            this.pBook.Controls.Add(this.btnBack);
            this.pBook.Controls.Add(this.btnAddBook);
            this.pBook.Controls.Add(this.lbRefresh);
            this.pBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBook.Location = new System.Drawing.Point(537, 27);
            this.pBook.Name = "pBook";
            this.pBook.Size = new System.Drawing.Size(216, 535);
            this.pBook.TabIndex = 15;
            this.pBook.Visible = false;
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBooks.Location = new System.Drawing.Point(0, 32);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(216, 35);
            this.btnAllBooks.TabIndex = 1;
            this.btnAllBooks.Text = "All Books";
            this.btnAllBooks.UseVisualStyleBackColor = false;
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(216, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pCategory
            // 
            this.pCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCategory.Controls.Add(this.btnAddLang);
            this.pCategory.Controls.Add(this.btnCategorys);
            this.pCategory.Controls.Add(this.btnBackC);
            this.pCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCategory.Location = new System.Drawing.Point(105, 27);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(216, 535);
            this.pCategory.TabIndex = 17;
            this.pCategory.Visible = false;
            // 
            // btnAddLang
            // 
            this.btnAddLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLang.Location = new System.Drawing.Point(0, 65);
            this.btnAddLang.Name = "btnAddLang";
            this.btnAddLang.Size = new System.Drawing.Size(216, 35);
            this.btnAddLang.TabIndex = 11;
            this.btnAddLang.Text = "Add";
            this.btnAddLang.UseVisualStyleBackColor = true;
            this.btnAddLang.Click += new System.EventHandler(this.btnAddLang_Click);
            // 
            // btnCategorys
            // 
            this.btnCategorys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorys.Location = new System.Drawing.Point(0, 32);
            this.btnCategorys.Name = "btnCategorys";
            this.btnCategorys.Size = new System.Drawing.Size(216, 35);
            this.btnCategorys.TabIndex = 1;
            this.btnCategorys.Text = "Categories";
            this.btnCategorys.UseVisualStyleBackColor = true;
            this.btnCategorys.Click += new System.EventHandler(this.btnCategorys_Click);
            // 
            // btnBackC
            // 
            this.btnBackC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBackC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackC.Image = ((System.Drawing.Image)(resources.GetObject("btnBackC.Image")));
            this.btnBackC.Location = new System.Drawing.Point(0, 0);
            this.btnBackC.Name = "btnBackC";
            this.btnBackC.Size = new System.Drawing.Size(216, 35);
            this.btnBackC.TabIndex = 0;
            this.btnBackC.UseVisualStyleBackColor = false;
            this.btnBackC.Click += new System.EventHandler(this.btnBackC_Click);
            // 
            // pReader
            // 
            this.pReader.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pReader.Controls.Add(this.btnSearchReader);
            this.pReader.Controls.Add(this.btnAllReaders);
            this.pReader.Controls.Add(this.btnBackR);
            this.pReader.Controls.Add(this.btnAddReader);
            this.pReader.Dock = System.Windows.Forms.DockStyle.Right;
            this.pReader.Location = new System.Drawing.Point(-111, 27);
            this.pReader.Name = "pReader";
            this.pReader.Size = new System.Drawing.Size(216, 535);
            this.pReader.TabIndex = 16;
            this.pReader.Visible = false;
            // 
            // btnSearchReader
            // 
            this.btnSearchReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReader.Location = new System.Drawing.Point(0, 65);
            this.btnSearchReader.Name = "btnSearchReader";
            this.btnSearchReader.Size = new System.Drawing.Size(216, 35);
            this.btnSearchReader.TabIndex = 11;
            this.btnSearchReader.Text = "Search Reader";
            this.btnSearchReader.UseVisualStyleBackColor = true;
            // 
            // btnAllReaders
            // 
            this.btnAllReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllReaders.Location = new System.Drawing.Point(0, 32);
            this.btnAllReaders.Name = "btnAllReaders";
            this.btnAllReaders.Size = new System.Drawing.Size(216, 35);
            this.btnAllReaders.TabIndex = 1;
            this.btnAllReaders.Text = "All Readers";
            this.btnAllReaders.UseVisualStyleBackColor = true;
            this.btnAllReaders.Click += new System.EventHandler(this.btnAllReaders_Click);
            // 
            // btnBackR
            // 
            this.btnBackR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBackR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackR.Image = ((System.Drawing.Image)(resources.GetObject("btnBackR.Image")));
            this.btnBackR.Location = new System.Drawing.Point(0, 0);
            this.btnBackR.Name = "btnBackR";
            this.btnBackR.Size = new System.Drawing.Size(216, 35);
            this.btnBackR.TabIndex = 0;
            this.btnBackR.UseVisualStyleBackColor = false;
            this.btnBackR.Click += new System.EventHandler(this.btnBackR_Click);
            // 
            // btnAddReader
            // 
            this.btnAddReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.Location = new System.Drawing.Point(0, 96);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(216, 35);
            this.btnAddReader.TabIndex = 0;
            this.btnAddReader.Text = "Add Reader";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // pLang
            // 
            this.pLang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pLang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLang.Controls.Add(this.btnPanelAddLang);
            this.pLang.Controls.Add(this.btnAllLang);
            this.pLang.Controls.Add(this.btnBackLang);
            this.pLang.Dock = System.Windows.Forms.DockStyle.Right;
            this.pLang.Location = new System.Drawing.Point(321, 27);
            this.pLang.Name = "pLang";
            this.pLang.Size = new System.Drawing.Size(216, 535);
            this.pLang.TabIndex = 18;
            this.pLang.Visible = false;
            // 
            // btnPanelAddLang
            // 
            this.btnPanelAddLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelAddLang.Location = new System.Drawing.Point(0, 65);
            this.btnPanelAddLang.Name = "btnPanelAddLang";
            this.btnPanelAddLang.Size = new System.Drawing.Size(216, 35);
            this.btnPanelAddLang.TabIndex = 11;
            this.btnPanelAddLang.Text = "Add";
            this.btnPanelAddLang.UseVisualStyleBackColor = true;
            this.btnPanelAddLang.Click += new System.EventHandler(this.btnPanelAddLang_Click);
            // 
            // btnAllLang
            // 
            this.btnAllLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllLang.Location = new System.Drawing.Point(0, 32);
            this.btnAllLang.Name = "btnAllLang";
            this.btnAllLang.Size = new System.Drawing.Size(216, 35);
            this.btnAllLang.TabIndex = 1;
            this.btnAllLang.Text = "Languages";
            this.btnAllLang.UseVisualStyleBackColor = true;
            this.btnAllLang.Click += new System.EventHandler(this.btnAllLang_Click);
            // 
            // btnBackLang
            // 
            this.btnBackLang.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBackLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLang.Image = ((System.Drawing.Image)(resources.GetObject("btnBackLang.Image")));
            this.btnBackLang.Location = new System.Drawing.Point(0, 0);
            this.btnBackLang.Name = "btnBackLang";
            this.btnBackLang.Size = new System.Drawing.Size(216, 35);
            this.btnBackLang.TabIndex = 0;
            this.btnBackLang.UseVisualStyleBackColor = false;
            this.btnBackLang.Click += new System.EventHandler(this.btnBackLang_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 27);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.toolsToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(52, 23);
            this.toolsToolStripMenuItem1.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendFeedbackToolStripMenuItem,
            this.registerProdactToolStripMenuItem,
            this.onlineHelpToolStripMenuItem,
            this.aboutLibraryAppToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            // 
            // registerProdactToolStripMenuItem
            // 
            this.registerProdactToolStripMenuItem.Name = "registerProdactToolStripMenuItem";
            this.registerProdactToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.registerProdactToolStripMenuItem.Text = "Register Prodact";
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            // 
            // aboutLibraryAppToolStripMenuItem
            // 
            this.aboutLibraryAppToolStripMenuItem.Name = "aboutLibraryAppToolStripMenuItem";
            this.aboutLibraryAppToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.aboutLibraryAppToolStripMenuItem.Text = "About LibraryApp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 562);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.pReader);
            this.Controls.Add(this.pCategory);
            this.Controls.Add(this.pLang);
            this.Controls.Add(this.pBook);
            this.Controls.Add(this.pFirst);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Lib";
            ((System.ComponentModel.ISupportInitialize)(this.viewBooks)).EndInit();
            this.pFirst.ResumeLayout(false);
            this.pBook.ResumeLayout(false);
            this.pBook.PerformLayout();
            this.pCategory.ResumeLayout(false);
            this.pReader.ResumeLayout(false);
            this.pLang.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        //this.panel1 = new LangPanel(0);
        //this.panel2 = new CategoryPanel(0);
        private LangPanel langPanel;
        private CategoryPanel categoryPanel;
        private System.Windows.Forms.DataGridView viewBooks;
        private System.Windows.Forms.Button bntViewBook;
        private System.Windows.Forms.ContextMenu bookMenu;
        private System.Windows.Forms.MenuItem bookMenuView;
        private System.Windows.Forms.MenuItem bookMenuProcess;
        private System.Windows.Forms.LinkLabel lbRefresh;
        private System.Windows.Forms.Panel pFirst;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel pBook;
        private System.Windows.Forms.Button btnAllBooks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pReader;
        private System.Windows.Forms.Button btnSearchReader;
        private System.Windows.Forms.Button btnAllReaders;
        private System.Windows.Forms.Button btnBackR;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Panel pCategory;
        private System.Windows.Forms.Button btnAddLang;
        private System.Windows.Forms.Button btnCategorys;
        private System.Windows.Forms.Button btnBackC;
        private System.Windows.Forms.Panel pLang;
        private System.Windows.Forms.Button btnPanelAddLang;
        private System.Windows.Forms.Button btnAllLang;
        private System.Windows.Forms.Button btnBackLang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerProdactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryAppToolStripMenuItem;
    }
}

