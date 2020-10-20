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
    public partial class Business_Operations : Form
    {
        public Business_Operations()
        {
            InitializeComponent();
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            const string text = "Do you want to exit? This will redirect you to the starting page.";
            const string caption = "EXIT";
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
