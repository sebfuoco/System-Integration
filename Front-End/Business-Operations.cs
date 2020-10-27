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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Business_Operations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'holiday_Booking_System_NEWDataSet.CustomerInfo' table. You can move, or remove it, as needed.
            this.customerInfoTableAdapter.Fill(this.holiday_Booking_System_NEWDataSet.CustomerInfo);

        }
    }
}
