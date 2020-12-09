using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Fatima booking-code

namespace Front_End
{
    public partial class Booking_Confirmation : Form
    {
        //Kevin - Booking Details Structure:
        struct bookingDetails
        {
            public string bookingDate;
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
        //Kevin - Instatiate bookingDetails
        bookingDetails booking = new bookingDetails();

        public Booking_Confirmation(string date, string firstname, string surname, string address, string phonenumber, string destination, string flightprice,
                             string carDetails, string carhirePrice, string hotellocation, string hotelprice, string total)
        {
            InitializeComponent();
            //Kevin - assign data from the previous form to the structure
            booking.bookingDate = date;
            booking.fname = firstname;
            booking.sname = surname;
            booking.customerPhone = phonenumber;
            booking.customerAddress = address;
            booking.flightDestination = destination;
            booking.flightTotalPrice = flightprice;
            booking.hireDetails = carDetails;
            booking.carHirePrice = carhirePrice;
            booking.hotelDetails = hotellocation;
            booking.hotelTotalPrice = hotelprice;
            booking.totalPrice = total;

        }
        public Booking_Confirmation()
        {
            InitializeComponent();
        }

        // connect to homepage
        private void cnlButton_Click(object sender, EventArgs e)
        {

        }

        // exit code
        private void extButton_Click(object sender, EventArgs e)
        {

        }

        // connect to invoice
        private void nxtButton_Click(object sender, EventArgs e)
        {

        }
    }
}
