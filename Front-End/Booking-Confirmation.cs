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
        //Kevin - Instatiate bookingDetails
        bookingDetails booking = new bookingDetails();

        public Booking_Confirmation(string date, string firstname, string surname,
            string address, string phone, string gender, string nationality,
            string passportNumber, string postCode, string email,
            string flightnumber, string flighttype,
            string flightdeparture, string flightarrival, string adults,
            string child, string destination, string numberPlate,
            string carSeats, string make, string model, string hirePrice,
            string hireName, string hotelStarRating, string checkIn,
            string checkOut, string hotelName, string hotelPrice, string totalPrice)
        {
            InitializeComponent();
            //Kevin - assign data from the previous form to the structure

            booking.bookingDate = date;
            booking.fname = firstname;
            booking.sname = surname;
            booking.customerAddress = address;
            booking.customerPhone = phone;
            booking.gender = gender;
            booking.nationality = nationality;
            booking.passportNum = passportNumber;
            booking.postCode = postCode;
            booking.email = email;
            booking.flightNumber = flightnumber;
            booking.flightType = flighttype;
            booking.Departuretime = flightdeparture;
            booking.arrivalTime = flightarrival;
            booking.numAdults = adults;
            booking.numChild = child;
            booking.flightDestination = destination;
            booking.carNumPlate = numberPlate;
            booking.carSeats = carSeats;
            booking.carMake = make;
            booking.carModel = model;
            booking.carHirePrice = hirePrice;
            booking.carHireName = hireName;
            booking.hotelStar = hotelStarRating;
            booking.hotelCheckin = checkIn;
            booking.hotelCheckout = checkOut;
            booking.hotelName = hotelName;
            booking.hotelTotalPrice = hotelPrice;
            booking.totalPrice = totalPrice;

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
            //Sing : passing values to invoice:
            Print_Invoice invoice = new Print_Invoice(booking.bookingDate,booking.fname,booking.sname,
                booking.customerAddress,booking.customerPhone,booking.gender, booking.nationality,
                booking.passportNum, booking.postCode, booking.email, booking.flightNumber,
                booking.flightType, booking.Departuretime,booking.arrivalTime,booking.numAdults,
                booking.numChild, booking.flightDestination, booking.carNumPlate,
                booking.carSeats, booking.carMake, booking.carModel,booking.carHirePrice, booking.carHireName,
                booking.hotelStar,booking.hotelCheckin, booking.hotelCheckout, booking.hotelName,booking.hotelTotalPrice,booking.totalPrice);
            this.Hide();
            invoice.Show();
        }

        private void Booking_Confirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
