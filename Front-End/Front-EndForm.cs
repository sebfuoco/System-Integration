using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Starting page of the program
// User and business operations

namespace Front_End
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void userSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Availability_Check a = new Availability_Check();
            a.ShowDialog();
        }

        private void mgrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager m = new Manager();
            m.ShowDialog();
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
    }
}
