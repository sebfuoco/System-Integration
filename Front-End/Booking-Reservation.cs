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
            //KEVIN
            MessageBox.Show("Booking Reserved");

            string cString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb";
            string save = "INSERT INTO Customers (CustomerFirstName, CustomerLastName, Gender, PassportNumber, Nationality, Address, PostCode, ContactNumber, EmailAddress) " +
            "VALUES (@CustomerFirstName, @CustomerLastName, @Gender, @PassportNumber, @Nationality, @Address, @PostCode, @ContactNumber, @EmailAddress)";


            object[] customers = {"@CustomerFirstName", firstNametxtbox.Text, "@CustomerLastName", lastNametxtbox.Text, "@Gender", gendertxtbox.Text,
                    "@PassportNumber", passportNumbtxtbox.Text, "@Nationality", Nationalitytxtbox.Text, "@Address", Addresstxtbox.Text, "@PostCode",
                postCodetxtbox.Text, "@ContactNumber", contactNumbertxtbox.Text, "@EmailAddress", emailtxtbox.Text};

            var dbFunc = new DatabaseFunctions();
            dbFunc.writeDatabase(save, cString,customers);

            this.Hide();
            Booking_Confirmation b = new Booking_Confirmation();
            b.ShowDialog();

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
