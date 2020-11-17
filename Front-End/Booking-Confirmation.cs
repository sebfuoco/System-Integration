using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Shows the inputs from the previous page (Booking Reservation)
// User can cancel, go back to edit details or proceed to confirm booking

namespace Front_End
{
    public partial class Booking_Confirmation : Form
    {
        public Booking_Confirmation()
        {
            InitializeComponent();
        }

        private void nxtButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print_Invoice p = new Print_Invoice();
            p.ShowDialog();
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {

        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking_Reservation b = new Booking_Reservation();
            b.ShowDialog();
        }
    }
}
