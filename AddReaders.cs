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
    public partial class AddReaders : Form
    {
        public AddReaders()
        {
            InitializeComponent();
        }

        private void AddReaders_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fillReader(readers reader)
        {
            reader.name = tbName.Text;
            reader.surname = tbSurname.Text;
            reader.middleName = tbMiddlename.Text;
            reader.passport = tbPassport.Text;
            reader.address = tbAddress.Text;
            reader.birthDate = dateBirthDate.Value.ToString();
            reader.phone = tbPhoneNumber.Text;
            reader.openDate = DateTime.Now.ToShortDateString();



        }

        private void baddReader_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (tbName.Text.Trim().Equals(""))
            {
                tbName.BackColor = Color.Tomato;
                return;
            }

            if (tbSurname.Text.Trim().Equals(""))
            {
                tbSurname.BackColor = Color.Tomato;
                return;
            }

            if (tbPassport.Text.Trim().Equals(""))
            {
                tbPassport.BackColor = Color.Tomato;
                return;
            }

            if (tbAddress.Text.Trim().Equals(""))
            {
                tbAddress.BackColor = Color.Tomato;
                return;
            }
            if (tbPhoneNumber.Text.Trim().Equals(""))
            {
                tbPhoneNumber.BackColor = Color.Tomato;
                return;
            }
            using (context = new LibContext(LibConnection.GetConnString()))
            {
                context.Connection.Open();

                readers newReader = new readers();
                fillReader(newReader);

                try
                {
                    context.readers_.InsertOnSubmit(newReader);
                    context.SubmitChanges();
                    success = true;
                }
                catch (System.Exception ex)
                {
                    success = false;
                    throw new Exception($"Error: Could not add reader\n", ex); ;
                }

                if (success)
                {
                    Close();
                }
            }
        }
    }
}