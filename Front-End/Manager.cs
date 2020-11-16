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

       
        
        private void lgnButton_Click(object sender, EventArgs e)
        {
            ////Sing : login
           
            //This will return true if user is a manager and false if user is not a manager.
            Back_End.Program.login.authenticateUser(usernametxt.Text, passwordtxt.Text);
           

            //this.Hide();
            //Business_Operations b = new Business_Operations();
            //b.ShowDialog();



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
