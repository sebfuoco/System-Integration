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
    }
}
