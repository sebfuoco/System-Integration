using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End
{
    public partial class Manager : Form
    {
        public Manager()
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

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void lgnButton_Click(object sender, EventArgs e)
        {
            // Please add code here for username and password
            // hi
            // hello
            this.Hide();
            Business_Operations b = new Business_Operations();
            b.ShowDialog();
        }
    }
}
