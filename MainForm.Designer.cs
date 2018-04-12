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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new LangPanel(0);
            this.panel2 = new CategoryPanel(0);
            this.viewBooks = new System.Windows.Forms.DataGridView();
            this.bntViewBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bookMenu = new System.Windows.Forms.ContextMenu();
            this.bookMenuView = new System.Windows.Forms.MenuItem();
            this.bookMenuProcess = new System.Windows.Forms.MenuItem();
            this.lbRefresh = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.viewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(580, 12);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Language";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(176, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 196);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(481, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 196);
            this.panel2.TabIndex = 9;
            // 
            // viewBooks
            // 
            this.viewBooks.AllowUserToOrderColumns = true;
            this.viewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewBooks.Location = new System.Drawing.Point(48, 13);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewBooks.Size = new System.Drawing.Size(396, 220);
            this.viewBooks.TabIndex = 10;
            this.viewBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewBooks_MouseClick);
            // 
            // bntViewBook
            // 
            this.bntViewBook.Location = new System.Drawing.Point(580, 70);
            this.bntViewBook.Name = "bntViewBook";
            this.bntViewBook.Size = new System.Drawing.Size(75, 23);
            this.bntViewBook.TabIndex = 11;
            this.bntViewBook.Text = "View Books";
            this.bntViewBook.UseVisualStyleBackColor = true;
            this.bntViewBook.Click += new System.EventHandler(this.bntViewBook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Readers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Readers_Click);
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
            this.lbRefresh.Location = new System.Drawing.Point(499, 159);
            this.lbRefresh.Name = "lbRefresh";
            this.lbRefresh.Size = new System.Drawing.Size(44, 13);
            this.lbRefresh.TabIndex = 13;
            this.lbRefresh.TabStop = true;
            this.lbRefresh.Text = "Refresh";
            this.lbRefresh.Click += new System.EventHandler(this.lbRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 466);
            this.Controls.Add(this.lbRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntViewBook);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBook);
            this.Name = "MainForm";
            this.Text = "Lib";
            ((System.ComponentModel.ISupportInitialize)(this.viewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private LangPanel panel1;
        private CategoryPanel panel2;
        //this.panel1 = new LangPanel(0);
        //this.panel2 = new CategoryPanel(0);
        private System.Windows.Forms.DataGridView viewBooks;
        private System.Windows.Forms.Button bntViewBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenu bookMenu;
        private System.Windows.Forms.MenuItem bookMenuView;
        private System.Windows.Forms.MenuItem bookMenuProcess;
        private System.Windows.Forms.LinkLabel lbRefresh;
    }
}

