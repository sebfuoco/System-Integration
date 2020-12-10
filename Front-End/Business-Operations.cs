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
using Back_End;

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
            // TODO: This line of code loads data into the 'primaryDB.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter1.Fill(this.primaryDB.Flights);
            // TODO: This line of code loads data into the 'primaryDB.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter2.Fill(this.primaryDB.Customers);
            // TODO: This line of code loads data into the 'primaryDB.Hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter1.Fill(this.primaryDB.Hotel);
            // TODO: This line of code loads data into the 'primaryDBDataSet.Hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.primaryDBDataSet.Hotel);
            // TODO: This line of code loads data into the 'primaryDBDataSet.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.primaryDBDataSet.Flights);
            // TODO: This line of code loads data into the 'primaryDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.primaryDBDataSet.Customers);
            // TODO: This line of code loads data into the 'manager_Database.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.manager_Database.Customers);

        }

        private void customerFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void recovery_Click(object sender, EventArgs e)
        {
            // batch recovery query: Seb + Gianni
            var secondaryDatabase = new SecondaryDatabase();
            bool query = secondaryDatabase.batchRecovery();
            // Avar: notify of recovery process
            if (query == true)
            {
                MessageBox.Show("System recovery is compeleted.");
            }
            else
            {
                MessageBox.Show("System recovery has already completed or sync unsuccessful.");
            }
        }

        private void sync_Click(object sender, EventArgs e)
        {
            // batch update queries: Seb + Gianni
            string fetchCustomersDB = "INSERT INTO SecondaryDB.mdb.Customers SELECT * FROM Customers",
                fetchFlightsDB = "INSERT INTO SecondaryDB.mdb.Flights SELECT * FROM Flights",
                fetchHotelDB = "INSERT INTO SecondaryDB.mdb.Hotel SELECT * FROM Hotel",
                fetchCarsDB = "INSERT INTO SecondaryDB.mdb.Cars SELECT * FROM Cars";
            string[] dbList = { fetchCustomersDB, fetchFlightsDB, fetchHotelDB, fetchCarsDB };
            // Avar: batch update notification  
            var primaryDatabase = new PrimaryDatabase();
            bool query = primaryDatabase.batchUpdate(dbList, false);

            if (query == true)
            {
                MessageBox.Show("Sync Completed");
            }
            else
            {
                MessageBox.Show("Sync unsuccessful. Please contact your system administrator.");
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
