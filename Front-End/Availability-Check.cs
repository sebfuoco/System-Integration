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


        private void nxtButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Booking_Reservation a = new Booking_Reservation();
            a.ShowDialog();
        }

        private void extButton_Click_1(object sender, EventArgs e)
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

        private void cnlButton_Click_2(object sender, EventArgs e)
        {
            const string text = "Do you want to cancel? This will redirect you to the home page.";
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

        private void Copyb_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Avaoutput.Text);
            sb.AppendLine(Seatoutput.Text);
            Clipboard.SetText(sb.ToString());

        }

        private void Avaoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seatoutput_TextChanged(object sender, EventArgs e)
        {

        }

		private void Printb_Click(object sender, EventArgs e)
		{

		}
	}
}
