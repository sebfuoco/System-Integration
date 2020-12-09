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
        //Instance of a the invoice structure
        invoice invoiceDetails = new invoice();
        //Structure for booking details
        struct invoice
        {
            public string invoiceDate;
            public string fname;
            public string sname;
            public string customerAddress;
            public string customerPhone;
            public string flightDestination;
            public string flightTotalPrice;
            public string carHirePrice;
            public string hireDetails;
            public string hotelDetails;
            public string hotelTotalPrice;
            public string totalPrice;

        }
        
        public Print_Invoice(string date,string firstname, string surname,string address,string phonenumber,string destination,string flightprice,
                             string carDetails,string carhirePrice,string hotellocation,string hotelprice,string total)
        {
            InitializeComponent();
            //Assign data from the previous form to the structure
            invoiceDetails.invoiceDate = date;
            invoiceDetails.fname = firstname;
            invoiceDetails.sname = surname;
            invoiceDetails.customerPhone = phonenumber;
            invoiceDetails.customerAddress = address;
            invoiceDetails.flightDestination = destination;
            invoiceDetails.flightTotalPrice = flightprice;
            invoiceDetails.hireDetails = carDetails;
            invoiceDetails.carHirePrice = carhirePrice;
            invoiceDetails.hotelDetails = hotellocation;
            invoiceDetails.hotelTotalPrice = hotelprice;
            invoiceDetails.totalPrice = total;

        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            const string text = "Do you want to go back to the homepage without printing the invoice?";
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

        private void button1_Click(object sender, EventArgs e)
        {
            const string text = "Confirmation Complete!";
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

        private void Print_Invoice_Load(object sender, EventArgs e)
        {
            //Display data of structure on the front-end
            dateLbl.Text = invoiceDetails.invoiceDate;
            fnameLbl.Text = invoiceDetails.fname;
            snameLbl.Text = invoiceDetails.sname; ;
            addrLbl.Text = invoiceDetails.customerAddress; 
            phonenumLbl.Text = invoiceDetails.customerPhone;
            destiLbl.Text = invoiceDetails.flightDestination;
            flipriceLbl.Text = invoiceDetails.flightTotalPrice;
            cardetailLbl.Text = invoiceDetails.hireDetails;
            carpriceLbl.Text = invoiceDetails.carHirePrice; ;
            locatLbl.Text = invoiceDetails.hotelDetails;
            htlpriLbl.Text = invoiceDetails.hotelTotalPrice;
            totalLbl.Text = invoiceDetails.totalPrice;

        }
    }
}
