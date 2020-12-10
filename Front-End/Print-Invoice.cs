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
            public string bookingDate;
            public string fname;
            public string sname;
            public string customerAddress;
            public string customerPhone;
            public string gender;
            public string nationality;
            public string passportNum;
            public string postCode;
            public string email;

            public string flightNumber;
            public string flightType;
            public string Departuretime;
            public string arrivalTime;
            public string numAdults;
            public string numChild;
            public string flightDestination;
            public string flightTotalPrice;

            public string carNumPlate;
            public string carSeats;
            public string carMake;
            public string carModel;
            public string carHirePrice;
            public string carHireName;

            public string hotelStar;
            public string hotelCheckin;
            public string hotelCheckout;
            public string hotelName;
            public string hotelTotalPrice;

            public string totalPrice;

        }
        
        public Print_Invoice(string date, string firstname, string surname, 
            string address, string phone,string gender, string nationality,
            string passportNumber, string postCode, string email, 
            string flightnumber, string flighttype,
            string flightdeparture, string flightarrival, string adults,
            string child, string destination, string numberPlate, 
            string carSeats, string make, string model, string hirePrice,
            string hireName, string hotelStarRating, string checkIn, 
            string checkOut, string hotelName, string hotelPrice, string totalPrice)
        {
            InitializeComponent();
            //Assign data from the previous form to the structure

            invoiceDetails.bookingDate = date;
            invoiceDetails.fname = firstname;
            invoiceDetails.sname = surname;
            invoiceDetails.customerAddress = address;
            invoiceDetails.customerPhone = phone;
            invoiceDetails.gender = gender;
            invoiceDetails.nationality = nationality;
            invoiceDetails.passportNum = passportNumber;
            invoiceDetails.postCode = postCode;
            invoiceDetails.email = email;
            invoiceDetails.flightNumber = flightnumber;
            invoiceDetails.flightType = flighttype;
            invoiceDetails.Departuretime = flightdeparture;
            invoiceDetails.arrivalTime = flightarrival;
            invoiceDetails.numAdults = adults;
            invoiceDetails.numChild = child;
            invoiceDetails.flightDestination = destination;
            invoiceDetails.carNumPlate = numberPlate;
            invoiceDetails.carSeats = carSeats;
            invoiceDetails.carMake = make;
            invoiceDetails.carModel = model;
            invoiceDetails.carHirePrice = hirePrice;
            invoiceDetails.carHireName = hireName;
            invoiceDetails.hotelStar = hotelStarRating;
            invoiceDetails.hotelCheckin = checkIn;
            invoiceDetails.hotelCheckout = checkOut;
            invoiceDetails.hotelName = hotelName;
            invoiceDetails.hotelTotalPrice = hotelPrice;
            invoiceDetails.totalPrice = totalPrice;

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

        private void printInvoiceBtn_Click(object sender, EventArgs e)
        {
            try {
                Back_End.printFunction.printInvoice(invoiceDetails.invoiceDate, invoiceDetails.fname, invoiceDetails.sname, invoiceDetails.customerAddress, invoiceDetails.customerPhone, invoiceDetails.flightDestination, invoiceDetails.flightTotalPrice, invoiceDetails.hireDetails, invoiceDetails.carHirePrice, invoiceDetails.hotelDetails, invoiceDetails.hotelTotalPrice, invoiceDetails.totalPrice);

            }
            catch (Exception)
            {
                MessageBox.Show("Could not retrieve invoice");
            }
        }

    }
}
