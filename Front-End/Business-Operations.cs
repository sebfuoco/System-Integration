using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Front_End
{
    public partial class Business_Ops : Form
    {
        //SqlConnection con = new SqlConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C: \Users\giann\Source\Repos\sebfuoco\System - Integration\Front - End\Holiday Booking System NEW.mdb"");
        public Business_Ops()
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

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manager_Database);

        }

        private void Business_Ops_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primaryDBDataSet.Hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.primaryDBDataSet.Hotel);
            // TODO: This line of code loads data into the 'primaryDBDataSet.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.primaryDBDataSet.Flights);
            // TODO: This line of code loads data into the 'primaryDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.primaryDBDataSet.Customers);
            // TODO: This line of code loads data into the 'manager_Database.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.manager_Database.Customers);

        }
    }
}
