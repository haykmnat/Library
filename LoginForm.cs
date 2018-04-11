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
    public partial class LoginForm : Form
    {
        Library.LibContext context = new LibContext(Library.LibConnection.GetConnString());
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var table = context.users.Select(c => new { Login = c.login, Password = c.password });
            if (!table.Any())
            {
                MessageBox.Show("Incorrect username or password");
            }
            else
            {
                MainForm a = new MainForm();
                this.Hide();
                a.ShowDialog();
                this.Close();
            }
            
        }
    }
}
