using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Availability Check/Query
// This form will check and allow user to select items for reservation

namespace Front_End
{
    public partial class Availability_Check : Form
    {
        public Availability_Check()
        {
            InitializeComponent();
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            const string text = "Do you want to cancel? This will redirect you to the starting page.";
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

        private void nxtButton_Click(object sender, EventArgs e)
        {
            // Please a condition here that will notify the user that they have to choose at least 1 selection
            this.Hide();
            Booking_Reservation b = new Booking_Reservation();
            b.ShowDialog();
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

        private void cnlButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.ShowDialog();
        }

        private void nxtButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
