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

    public partial class Readers : Form
    {
        Library.LibContext context = new LibContext(Library.LibConnection.GetConnString());

        public Readers()
        {
            InitializeComponent();
        }

        private void button1_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OMAE WA MOU SHINDEIRU \n\n NANI???");
        }

        private void button3_all_readers_Click(object sender, EventArgs e)
        {
            var tabe = context.readers_.Select(c => new { Name = c.name,Middle_Name= c.middleName,
                                                          Surname = c.surname, PassportSeria = c.passport,
                                                          OpenDate = c.openDate, CloseDate = c.closeDate})
                                                          .Distinct();
            viewReaders.DataSource = tabe;
            viewReaders.RowHeadersVisible = false;
        }
    }
}
