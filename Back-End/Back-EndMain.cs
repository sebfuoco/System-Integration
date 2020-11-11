using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Back_End
{
    public class Program
    {
        //Sing : login database declarations
        System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dtable = new DataTable();
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader reader;

        public static void Main(string[] args)
        {
            // Primary Database + queries
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=HolidayBookingSystem.mdb",
                editDB = "UPDATE Customers SET [CustomerFirstName] = @CustomerFirstName, [CustomerLastName] = @CustomerLastName WHERE [CustomerEmail] = @CustomerEmail",
                checkDuplicateDB = "SELECT COUNT(*) FROM Customers WHERE [CustomerFirstName] = @CustomerFirstName AND [CustomerLastName] = @CustomerLastName",
                deleteDB = "DELETE FROM Customers WHERE CustomerID BETWEEN 5 AND 1000",
                readDB = "SELECT * FROM Customers";
            // Must initalise class before use
            var dbFunc = new DatabaseFunctions();
            var primaryDatabase = new PrimaryDatabase();
            var secondaryDatabase = new SecondaryDatabase();
            // tests
            //primaryDatabase.batchUpdate();
            var details = dbFunc.createDict();
            primaryDatabase.fetchData(details);
            // Test database
            //dbFunc.deleteDatabase(deleteDB, connectionString);
            //dbFunc.editDatabase(editDB, connectionString, details);
            //dbFunc.readDatabase(readDB, connectionString);
            //dbFunc.checkDuplicateDatabase(checkDuplicateDB, connectionString, details);
        }
        private string passedString;
        //Sing : Class Constructor 
        public Program(string uname, string password, Form next)
        {
            //Sing : Login database connection
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Users.mdb;Jet OLEDB:Database Password=;";
            command.Connection = connection;
            //sing : Login - Authenticating admin and normal user.
            authenticateUser(uname, password, next);
        }

        //Sing : Login for Front-end.
        private void authenticateUser(string username, string password, Form nextForm)
        {
            //Opening a connection to the database
            connection.Open();
            //defining the query 
            ad = new OleDbDataAdapter("select * from Accounts where username ='" + username + "'and password='" + password + "'", connection);
            //Filling the table adaptor 
            ad.Fill(dtable);
            //If statement for log in authenticaion - Checks if username and password is present in the Accounts table. Also checks whether admin details have been entered. 
            if (dtable.Rows.Count <= 0)
            {
                //Details do not exist in the database
                connection.Close();
                MessageBox.Show("Login Invalid. Please try again.");
            }
            else if (dtable.Rows.Count > 0)
            {
                //Data exists in the database, therefore this function checks where admin credientials are used.
                if (username == "admin" && password == "admin")
                {
                    connection.Close();
                    MessageBox.Show("You are an admin user");

                    nextForm.Show();
                    //admin credentials are used.
                    //Open admin page 
                    //Login authenticated
                }
                else
                {
                    MessageBox.Show("You are a normal user");
                    //username and password exists in the database
                    connection.Close();
                    nextForm.Show();
                    //normal user authenticated
                }
            }
        }
    }

    class DatabaseFunctions
    {
        // store data to send
        protected internal dynamic createDict()
        {
            var details = new Dictionary<string, string>();
            // Customer Test
            details["CustomerFirstName"] = "Bob";
            details["CustomerLastName"] = "Page";
            details["Gender"] = "Male";
            details["PassportNumber"] = "07771243";
            details["Nationality"] = "American";
            details["Address"] = "12 Garden Road, Woking, Surrey";
            details["PostCode"] = "GU21 2XT";
            details["ContactNumber"] = "771014512";
            details["EmailAddress"] = "bobpage@gmail.com";
            // Flight Test
            details["FlightNumber"] = "1200";
            details["HotelID"] = "4000";
            details["FlightType"] = "Return";
            details["Departure"] = "UK";
            details["Arrival"] = "Italy";
            details["DepartureTime"] = "13/11/2020";
            details["ArrivalTime"] = "20/11/2020";
            details["AdultPrice"] = "200.00";
            details["ChildPrice"] = "130.00";
            // Hotel Test
            details["HotelID"] = "4000";
            details["StarRating"] = "5";
            details["CheckIn"] = "13/11/2020";
            details["CheckOut"] = "20/11/2020";
            details["PricePerNight"] = "32.00";
            details["Country"] = "Italy";
            details["NumberPlate"] = "2200";
            // Cars Test
            details["Make"] = "Ford";
            details["Model"] = "Focus";
            details["CarType"] = "Large";
            details["GearBox"] = "Automatic";
            details["Seats"] = "10.00";
            details["PricePerDay"] = "18.00";
            return details;
        }

        protected internal void checkDuplicateDatabase(string sql, string connectionString, Dictionary<string, string> details)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@CustomerFirstName", details["firstName"]);
                    command.Parameters.AddWithValue("@CustomerLastName", details["lastName"]);
                    conn.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        Console.WriteLine(reader.GetInt32(0)); // show number of duplicates
                    }
                }
            }
            Console.ReadKey();
        }

        protected internal void editDatabase(string sql, string connectionString, Dictionary<string,string> details)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, conn))
                {
                    // Update row from email
                    command.Parameters.AddWithValue("@CustomerFirstName", OleDbType.VarChar).Value = details["firstName"];
                    command.Parameters.AddWithValue("@CustomerLastName", OleDbType.VarChar).Value = details["lastName"];
                    command.Parameters.AddWithValue("@CustomerEmail", OleDbType.VarChar).Value = details["email"];
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected internal void deleteDatabase(string sql, string connectionString)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, conn))
                {
                    // Delete from ID range
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected internal void writeDatabase(string sql, string connectionString, Dictionary<string, string> details, object[] arr)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, conn))
                {
                    conn.Open();
                    // loop through parameters
                    for (int i = 0; i < arr.Length; i += 2)
                    {
                        command.Parameters.Add(new OleDbParameter(arr[i].ToString(), OleDbType.VarChar)).Value = arr[i + 1];
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        protected internal dynamic writeIDDatabase(string sql, string sql2, string connectionString, Dictionary<string, string> details, object[] arr)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, conn))
                {
                    conn.Open();
                    // loop through parameters
                    for (int i = 0; i < arr.Length; i += 2)
                    {
                        command.Parameters.Add(new OleDbParameter(arr[i].ToString(), OleDbType.VarChar)).Value = arr[i + 1];
                    }
                    command.ExecuteNonQuery();
                }
                using (OleDbCommand command = new OleDbCommand(sql2, conn))
                {
                    var id = (int)command.ExecuteScalar();
                    string myId = id.ToString();
                    return myId;
                }
            }
        }
    }

    class PrimaryDatabase
    {
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=HolidayBookingSystem.mdb";
        string customerWriteDB = "INSERT INTO Customers (CustomerFirstName, CustomerLastName, Gender, PassportNumber, Nationality, Address, PostCode, ContactNumber, EmailAddress) " +
            "VALUES (@CustomerFirstName, @CustomerLastName, @Gender, @PassportNumber, @Nationality, @Address, @PostCode, @ContactNumber, @EmailAddress)",
            flightWriteDB = "INSERT INTO Flights (FlightNumber, CustomerID, FlightType, Departure, Destination, DepartureTime, ArrivalTime, AdultPrice, ChildPrice)" +
            "VALUES (@FlightNumber, @CustomerID, @FlightType, @Departure, @Destination, @DepartureTime, @ArrivalTime, @AdultPrice, @ChildPrice)",
            hotelWriteDB = "INSERT INTO Hotel (HotelID, StarRating, CheckIn, CheckOut, PricePerNight, Country, NumberPlate, FlightNumber) " +
            "VALUES (@HotelID, @StarRating, @CheckIn, @CheckOut, @PricePerNight, @Country, @NumberPlate, @FlightNumber)",
            carsWriteDB = "INSERT INTO Cars (NumberPlate, HotelID, Make, Model, CarType, GearBox, Seats, PricePerDay) " +
            "VALUES (@NumberPlate, @HotelID, @Make, @Model, @CarType, @GearBox, @Seats, @PricePerDay)";
        //Fetch new bookings, gets info from front-end : Seb
        protected internal void fetchData(Dictionary<string, string> details)
        {
            string firstName = details["CustomerFirstName"],
                readCustomerID = "SELECT @@IDENTITY AS CustomerID FROM Customers";
            var dbFunc = new DatabaseFunctions();
            object[] customers = {"@CustomerFirstName", details["CustomerFirstName"], "@CustomerLastName", details["CustomerLastName"], "@Gender", details["Gender"],
                    "@PassportNumber", details["PassportNumber"], "@Nationality", details["Nationality"], "@Address", details["Address"], "@PostCode",
                details["PostCode"], "@ContactNumber", details["ContactNumber"], "@EmailAddress", details["EmailAddress"]};
            details["CustomerID"] = dbFunc.writeIDDatabase(customerWriteDB, readCustomerID, connectionString, details, customers); // get customerID from insert query
            var myList = new List<KeyValuePair<int, string>>(); // change to list for int and strings
            object[] flights = {"@FlightNumber", details["FlightNumber"], "@CustomerID", details["CustomerID"], "@HotelID", details["HotelID"],
                    "@FlightType", details["FlightType"], "@Departure", details["Departure"], "@Arrival", details["Arrival"],
                "@DepartureTime", details["DepartureTime"], "@ArrivalTime", details["ArrivalTime"], "@AdultPrice",
            details["AdultPrice"], "@ChildPrice", details["ChildPrice"]};
            dbFunc.writeDatabase(flightWriteDB, connectionString, details, flights);
            object[] hotel = {"@HotelID", details["HotelID"], "@StarRating", details["StarRating"], "@CheckIn", details["CheckIn"],
                    "@CheckOut", details["CheckOut"], "@PricePerNight", details["PricePerNight"], "@Country", details["Country"], "@NumberPlate",
                details["NumberPlate"], "@FlightNumber", details["FlightNumber"]};
            dbFunc.writeDatabase(hotelWriteDB, connectionString, details, hotel);
            object[] cars = {"@NumberPlate", details["NumberPlate"], "@HotelID", details["HotelID"], "@Make", details["Make"], "@Model", details["Model"],
                "@CarType", details["CarType"], "@GearBox", details["GearBox"], "@Seats", details["Seats"], "@PricePerDay", details["PricePerDay"]};
            dbFunc.writeDatabase(carsWriteDB, connectionString, details, cars);
        }
        //Batch update the secondary database : Seb
        protected internal void batchUpdate()
        {

        }
        //Update Primary database with new bookings : Sing
        protected internal void updatePrimaryDatabase()
        {
            //query("", false);
        }
        //Sing : Query Databases Function - Accept query and returns boolean value.
        protected internal bool query(string query, bool flag)
        {
            try
            {
                //connection.Open();
                //command.CommandText = query;
                //command.ExecuteNonQuery();
                //connection.Close();
                return flag = true;
            }
            catch (Exception error)
            {
                // connection.Close();
                MessageBox.Show(error.Message.ToString());
                return flag = false;
            }
        }
        //Query database for information : Sing
        protected internal void queryDatabase()
        {
            //query("", false);
        }
    }
    class SecondaryDatabase
    {
        //Batch recovery/resync in case of batch failure : Ndey
        protected internal void batchRecovery()
        {

        }
        //Notify front-end of bacth recovery : Avar
        protected internal void notifyRecovery()
        {

        }
        //Send print notification to front-end : Avar
        protected internal void sendPrintNotifications()
        {

        }
    }
}