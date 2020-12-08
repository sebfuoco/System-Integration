using Back_End;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Requires user input after selecting the items
// previous page (Availability check/Query

namespace Front_End
{
    public partial class Booking_Reservation : Form
    {
       
        public Booking_Reservation()
        {
            InitializeComponent();
          

        }

        private void nxtButton_Click(object sender, EventArgs e)
        {
            if (firstNametxtbox.Text == "")
            {
                MessageBox.Show("First name can not be empty");
            }

            else if (lastNametxtbox.Text == "")
            {
                MessageBox.Show("Last name can not be empty");
            }

            else if (gendertxtbox.Text == "")
            {
                MessageBox.Show("Gender can not be empty");
            }

            else if (passportNumbtxtbox.Text == "")
            {
                MessageBox.Show("Passport number can not be empty");
            }

            else if (Nationalitytxtbox.Text == "")
            {
                MessageBox.Show("Nationality can not be empty");
            }

            else if (Addresstxtbox.Text == "")
            {
                MessageBox.Show("Address can not be empty");
            }

            else if (postCodetxtbox.Text == "")
            {
                MessageBox.Show("Post code can not be empty");
            }

            else if (contactNumbertxtbox.Text == "")
            {
                MessageBox.Show("Contact number can not be empty");
            }

            else if (emailtxtbox.Text == "")
            {
                MessageBox.Show("Email Address can not be empty");
            }
            else
            //KEVIN
            {
                MessageBox.Show("Booking Reserved");

                string cString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb";
                string save = "INSERT INTO Customers (CustomerFirstName, CustomerLastName, Gender, PassportNumber, Nationality, Address, PostCode, ContactNumber, EmailAddress) " +
                "VALUES (@CustomerFirstName, @CustomerLastName, @Gender, @PassportNumber, @Nationality, @Address, @PostCode, @ContactNumber, @EmailAddress)";


                object[] customers = {"@CustomerFirstName", firstNametxtbox.Text, "@CustomerLastName", lastNametxtbox.Text, "@Gender", gendertxtbox.Text,
                        "@PassportNumber", passportNumbtxtbox.Text, "@Nationality", Nationalitytxtbox.Text, "@Address", Addresstxtbox.Text, "@PostCode",
                    postCodetxtbox.Text, "@ContactNumber", contactNumbertxtbox.Text, "@EmailAddress", emailtxtbox.Text};

                var dbFunc = new DatabaseFunctions();
                dbFunc.writeDatabase(save, cString, customers);

                this.Hide();
                Booking_Confirmation b = new Booking_Confirmation();
                b.ShowDialog();
            }
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            const string text = "Are you sure want to cancel? This will delete your progress.";
            const string caption = "CANCEL";
            var result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                main m = new main();
                m.ShowDialog();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Availability_Check a = new Availability_Check();
            a.ShowDialog();
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            const string text = "Do you want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
