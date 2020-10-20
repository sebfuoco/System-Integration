using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Prints invoice for the user showing the booked items

namespace Front_End
{
    public partial class Print_Invoice : Form
    {
        public Print_Invoice()
        {
            InitializeComponent();
        }

        private void Print_Invoice_Load(object sender, EventArgs e)
        {

        }

        private void rtnButtom_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.ShowDialog();
        }

        private void prntInvButton_Click(object sender, EventArgs e)
        {
            // Code for printing the invoice

        }
    }
}
