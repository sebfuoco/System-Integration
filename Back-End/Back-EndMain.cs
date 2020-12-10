using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Globalization;
    
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
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb",
                secondaryConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SecondaryDB.mdb",
                editDB = "UPDATE Customers SET [CustomerFirstName] = @CustomerFirstName, [CustomerLastName] = @CustomerLastName WHERE [CustomerEmail] = @CustomerEmail",
                checkDuplicateDB = "SELECT COUNT(*) FROM Customers WHERE [CustomerFirstName] = @CustomerFirstName AND [CustomerLastName] = @CustomerLastName",
                readDB = "SELECT * FROM Customers",
                deleteDB = "DELETE FROM Customers WHERE CustomerID BETWEEN 3 AND 100",
                deleteFDB = "DELETE FROM Flights WHERE ID BETWEEN 3 AND 100",
                deleteHDB = "DELETE FROM Hotel WHERE ID BETWEEN 3 AND 100",
                deleteCDB = "DELETE FROM Cars WHERE ID BETWEEN 3 AND 100";
            // batch update queries
            string fetchCustomersDB = "INSERT INTO SecondaryDB.mdb.Customers SELECT * FROM Customers",
                fetchFlightsDB = "INSERT INTO SecondaryDB.mdb.Flights SELECT * FROM Flights",
                fetchHotelDB = "INSERT INTO SecondaryDB.mdb.Hotel SELECT * FROM Hotel",
                fetchCarsDB = "INSERT INTO SecondaryDB.mdb.Cars SELECT * FROM Cars";
            string[] dbList = { fetchCustomersDB, fetchFlightsDB, fetchHotelDB, fetchCarsDB };
            // Must initalise class before use
            var dbFunc = new DatabaseFunctions();
            var primaryDatabase = new PrimaryDatabase();
            var secondaryDatabase = new SecondaryDatabase();
            //bool checkRecovery = SecondaryDatabase.recoveryProgress;
            // tests
            //bool query = primaryDatabase.batchUpdate(dbList, false);
            bool squery = secondaryDatabase.batchRecovery();
            var details = dbFunc.createDict();
            //primaryDatabase.fetchData(details);
            // Test database
            /*
            dbFunc.deleteDatabase(deleteDB, connectionString);
            dbFunc.deleteDatabase(deleteFDB, connectionString);
            dbFunc.deleteDatabase(deleteHDB, connectionString);
            dbFunc.deleteDatabase(deleteCDB, connectionString);*/
            //dbFunc.editDatabase(editDB, connectionString, details);
            //dbFunc.readDatabase(readDB, connectionString);
            //dbFunc.checkDuplicateDatabase(checkDuplicateDB, connectionString, details);
        }

        //Sing: Class declaration for calculations
        public static class calculations
        {
            //Sing:Function to calculate the spaces left based on the fight number and the flight date.
            //This function returns a string value of the number of spaces.
            public static string calculateSpacesLeft(string flightNum, string flightdate)
            {

                //Sing :  Database declarations
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                OleDbDataAdapter ad;
                DataTable dtable = new DataTable();
                OleDbCommand command = new OleDbCommand();
                OleDbDataReader reader;
                //Connection string for database location
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Primary.mdb";
                command.Connection = connection;
                
                connection.Open();
                //SQL query to the database
                string query = "select * from Flights where FlightNumber =" + Int32.Parse(flightNum);
                command.CommandText = query;
                reader = command.ExecuteReader();

                int counter = 0;
                int numberOfSpace = 20;
                //Find the number of records with the flightID
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        if (reader["FlightNumber"].ToString() == flightNum.ToString() && reader["DepartureTime"].ToString() == (DateTime.Parse(flightdate)).ToString())
                        {
                            counter += 1;
                        }
                    }
                    reader.Close();
                }
                connection.Close();
                int result = numberOfSpace - counter;
                return result.ToString();

            }

            //Sing: Function to retrieve the flightID from the database.
            //Returns the flightID as a string value.
            public static string getFlightID(string destination)
            { 
                //Sing :  Database declarations
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                OleDbDataAdapter ad;
                DataTable dtable = new DataTable();
                OleDbCommand command = new OleDbCommand();
                OleDbDataReader reader;
                //Database connection location string.
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=PrimaryDB.mdb";
                command.Connection = connection;

                connection.Open();
                //SQL Query to the database
                string query = "select * from Flights where [Destination] = '" + destination + "'";
                command.CommandText = query;
                reader = command.ExecuteReader();

                string flightnum = "";
                //Finds the flight number based on the destination in the database.
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        if (reader["Destination"].ToString() == destination.ToString())
                        {
                            flightnum = reader["FlightNumber"].ToString();
                        }
                    }
                    reader.Close();
                }
                connection.Close();
                //Returns the flight number.
                return flightnum;
            }

            //Sing: Function to calculate the total price of a booking based on the flight price, car hire price, number of days for car rental,
            //hotel price and number of nights.
            //Returns and integer value for the total price
            public static int calculateTotolPrice(string flightPrice, string carPricePerDay, int carNumberOfDays, string hotelPricePerNight, int hotelNumberOfNights )
            {
                int totalCarPice = Int32.Parse(carPricePerDay) * carNumberOfDays;
                int totalHotelPrice = Int32.Parse(hotelPricePerNight) * hotelNumberOfNights;

                int total = totalCarPice + totalHotelPrice + Int32.Parse(flightPrice);

                return total;

            }

            //Sing: Function to find the number of spaces left based on the number of spaces taken.
            //returns and string value for the number of spaces left.
            public static string spacesTaken(string spacesLeft)
            {
                int space = 20 - Int32.Parse(spacesLeft);
                return space.ToString();
            }
        }

        //Sing: Class declaration for the login class
        public static class login
        {
            //Sing : Login for Front-end.
            //Function to authenticate a user based on credentials entered.
            //Entering username: admin and password: admin will return true.
            public static bool authenticateUser(string username, string password)
            {
                try // in case database connection fails.
                {
                    //Sing : login database declarations
                    System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                    OleDbDataAdapter ad;
                    DataTable dtable = new DataTable();
                    OleDbCommand command = new OleDbCommand();

                    //Sing : Login database connection
                    connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=User.mdb;Jet OLEDB:Database Password=;";
                    command.Connection = connection;

                    //Sing:Opening a connection to the database
                    connection.Open();
                    //Sing: defining the query 
                    ad = new OleDbDataAdapter("select * from Accounts where username ='" + username + "'and password='" + password + "'", connection);
                    //Filling the table adaptor 
                    ad.Fill(dtable);
                    //If statement for log in authenticaion - Checks if username and password is present in the Accounts table. Also checks whether admin details have been entered. 
                    if (dtable.Rows.Count <= 0)
                    {
                        //Details do not exist in the database
                        connection.Close();

                        return false;

                    }
                    else if (dtable.Rows.Count > 0 && username == "admin" && password == "admin")
                    {
                        //Data exists in the database, therefore return true as admin credentials have been entered. 

                        connection.Close();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }

    public class DatabaseFunctions
    {
        // store data to send: TEST fetchData()
        public  dynamic createDict()
        {
            var details = new Dictionary<string, object>();
            // Customer Test
            details["CustomerFirstName"] = "Bobby";
            details["CustomerLastName"] = "Page";
            details["Gender"] = "Male";
            details["PassportNumber"] = "07771243"; //unique
            details["Nationality"] = "American";
            details["Address"] = "12 Garden Road, Woking, Surrey";
            details["PostCode"] = "GU21 2XT";
            details["ContactNumber"] = "771014512";
            details["EmailAddress"] = "bobpage@gmail.com"; //unique
            // Flight Test
            details["FlightType"] = "Return";
            details["Departure"] = "UK";
            details["Arrival"] = "Italy";
            details["DepartureTime"] = "13/11/2020";
            details["ArrivalTime"] = "20/11/2020";
            details["AdultPrice"] = 200.00;
            details["ChildPrice"] = 130.00;
            // Hotel Test
            details["StarRating"] = 5;
            details["CheckIn"] = "13/11/2020";
            details["CheckOut"] = "20/11/2020";
            details["PricePerNight"] = 32.00;
            // Cars Test
            details["Make"] = "Ford";
            details["CarID"] = 2;
            details["Model"] = "Fiesta";
            details["CarType"] = "Small";
            details["GearBox"] = "Manual";
            details["Seats"] = 5;
            details["PricePerDay"] = 18.00;
            details["NumberPlate"] = "BV10 XWY"; // unique
            return details;
        }

        public dynamic maxID(string connectionString, string sql)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand maxID = new OleDbCommand(sql, connection);
            int id = (Int32)maxID.ExecuteScalar();
            return id;
        }

        public void checkDuplicateDatabase(string sql, string connectionString, Dictionary<string, string> details)
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

        public void readDatabase(string sql, string connectionString)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, conn))
                {
                    conn.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read()) // reads all data from query
                    {
                        Console.WriteLine($"Name: {reader.GetString(1)} {reader.GetString(2)} {reader.GetString(3)}");
                    }
                    Console.ReadKey();
                }
            }
        }

        public void editDatabase(string sql, string connectionString, Dictionary<string, object> details)
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

        public void deleteDatabase(string sql, string connectionString)
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

        public void writeDatabase(string sql, string connectionString, object[] arr)
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

        public dynamic writeIDDatabase(string sql, string connectionString, object[] arr)
        {
            string sql2 = "SELECT @@IDENTITY AS CustomerID FROM Customers";
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
                    return (int)command.ExecuteScalar();
                }
            }
        }
    
   }

    public class PrimaryDatabase
    {
        string customerWriteDB = "INSERT INTO Customers (CustomerFirstName, CustomerLastName, Gender, PassportNumber, Nationality, Address, PostCode, ContactNumber, EmailAddress) " +
            "VALUES (@CustomerFirstName, @CustomerLastName, @Gender, @PassportNumber, @Nationality, @Address, @PostCode, @ContactNumber, @EmailAddress)",
            flightWriteDB = "INSERT INTO Flights (FlightNumber, CustomerID, HotelID, FlightType, Departure, Destination, DepartureTime, ArrivalTime, AdultPrice, ChildPrice)" +
            "VALUES (@FlightNumber, @CustomerID, @HotelID, @FlightType, @Departure, @Destination, @DepartureTime, @ArrivalTime, @AdultPrice, @ChildPrice)",
            hotelWriteDB = "INSERT INTO Hotel (HotelID, StarRating, CheckIn, CheckOut, PricePerNight, Country, NumberPlate, FlightNumber) " +
            "VALUES (@HotelID, @StarRating, @CheckIn, @CheckOut, @PricePerNight, @Country, @NumberPlate, @FlightNumber)",
            carsWriteDB = "INSERT INTO Cars (CarID, NumberPlate, HotelID, Make, Model, CarType, GearBox, Seats, PricePerDay) " +
            "VALUES (@CarID, @NumberPlate, @HotelID, @Make, @Model, @CarType, @GearBox, @Seats, @PricePerDay)";
        //Fetch new bookings, gets info from front-end : Seb
        public dynamic fetchData(Dictionary<string, object> details)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb";
            var dbFunc = new DatabaseFunctions();
            // test ID
            //details["FlightNumber"] = 1200;
            //details["HotelID"] = 4510;
            object[] customers = {"@CustomerFirstName", details["CustomerFirstName"], "@CustomerLastName", details["CustomerLastName"], "@Gender", details["Gender"],
                    "@PassportNumber", details["PassportNumber"], "@Nationality", details["Nationality"], "@Address", details["Address"], "@PostCode",
                details["PostCode"], "@ContactNumber", details["ContactNumber"], "@EmailAddress", details["EmailAddress"]};
            details["CustomerID"] = dbFunc.writeIDDatabase(customerWriteDB, connectionString, customers); // get customerID from insert query
            object[] flights = {"@FlightNumber", details["FlightNumber"], "@CustomerID", details["CustomerID"], "@HotelID", details["HotelID"],
                    "@FlightType", details["FlightType"], "@Departure", details["Departure"], "@Arrival", details["Arrival"],
                "@DepartureTime", details["DepartureTime"], "@ArrivalTime", details["ArrivalTime"], "@AdultPrice",
            details["AdultPrice"], "@ChildPrice", details["ChildPrice"]};
            dbFunc.writeDatabase(flightWriteDB, connectionString, flights);
            object[] hotel = {"@HotelID", details["HotelID"],"@StarRating", details["StarRating"], "@CheckIn", details["CheckIn"],
                    "@CheckOut", details["CheckOut"], "@PricePerNight", details["PricePerNight"], "@Country", details["Arrival"], "@NumberPlate",
                details["NumberPlate"], "@FlightNumber", details["FlightNumber"]};
            dbFunc.writeDatabase(hotelWriteDB, connectionString, hotel);
            object[] cars = {"@CarID", details["CarID"], "@NumberPlate", details["NumberPlate"], "@HotelID", details["HotelID"], "@Make", details["Make"], "@Model", details["Model"],
                "@CarType", details["CarType"], "@GearBox", details["GearBox"], "@Seats", details["Seats"], "@PricePerDay", details["PricePerDay"]};
            dbFunc.writeDatabase(carsWriteDB, connectionString, cars);
            return true;
        }
        //Batch update from primary to secondary database : Seb
        protected internal void batchDelete(string secondaryConnectionString)
        {
            string deleteCustomersDB = "DELETE FROM Customers", deleteFlightsDB = "DELETE FROM Flights",
                deleteHotelDB = "DELETE FROM Hotel", deleteCarsDB = "DELETE FROM Cars";
            string[] dbList = { deleteCustomersDB, deleteFlightsDB, deleteHotelDB, deleteCarsDB };
            using (OleDbConnection conn = new OleDbConnection(secondaryConnectionString))
            {
                conn.Open();
                for (int i = 0; i < dbList.Length; i++) // Go through all queries in loop
                {
                    using (OleDbCommand command = new OleDbCommand(dbList[i], conn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public dynamic batchUpdate(string[] dbList, bool recover) // Works but can be improved to just update
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb",
               secondaryConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SecondaryDB.mdb";
            if (recover == true) {
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SecondaryDB.mdb";
                secondaryConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb";
            }
            try {
                batchDelete(secondaryConnectionString);
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    using (OleDbConnection sConn = new OleDbConnection(secondaryConnectionString))
                    {
                        conn.Open();
                        sConn.Open();
                        for (int i = 0; i < dbList.Length; i++) // Go through all queries in loop
                        {
                            using (OleDbCommand command = new OleDbCommand(dbList[i], conn))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public static class printFunction
    {
        public static void printInvoice(string date, string firstname, string surname, string address, string phonenumber, string destination, string flightprice,
                             string carDetails, string carhirePrice, string hotellocation, string hotelprice, string total)
        {

            // batch update queries
            string fetchCustomersDB = "INSERT INTO SecondaryDB.mdb.Customers SELECT * FROM Customers",
                fetchFlightsDB = "INSERT INTO SecondaryDB.mdb.Flights SELECT * FROM Flights",
                fetchHotelDB = "INSERT INTO SecondaryDB.mdb.Hotel SELECT * FROM Hotel",
                fetchCarsDB = "INSERT INTO SecondaryDB.mdb.Cars SELECT * FROM Cars";
            string[] dbList = { fetchCustomersDB, fetchFlightsDB, fetchHotelDB, fetchCarsDB };

            var primaryDatabase = new PrimaryDatabase();
            bool query = primaryDatabase.batchUpdate(dbList, false);

            MessageBox.Show("Your booking has been confirmed.");

            MessageBox.Show("Date: " + date + "\n" + "Firstname: " + firstname + "\n" + "Surname: " + surname + "\n" + "Phone Number: " + phonenumber + "\n" + "Address: " + address + "\n" + "Destination: " + destination + "\n" + "Flight Price: £" + flightprice + "\n" + "Car hire: " + carDetails + "\n" + "Car Price: £ " + carhirePrice + "\n" + "Hotel Location: " + hotellocation + "\n" + "Hotel Price: £ " + hotelprice + "\n" + "Total Price: £ " + total);
        }
    }

    //Sing: Class decaration for Database Query functions
    public static class DatabaseQuery
    {
        //Sing: Defining a structure for flight details
       public struct flightDetails
        {
            public string flightNumber;
            public string flightType;
            public string destination;
            public string departure;
            public string arrival;
            public string adultPrice;
            public string childPrice;
        }

        //Sing: Definiing a structure for car details
        public struct cars
        {
            public string numPlate;
            public string carMake;
            public string carModel;
            public string carType;
            public string gearBox;
            public string seats;
            public string pricePerDay;

        }

        //Sing: Defining a structure for hotel details.
       public  struct hotel
        {
            public string rating;
            public string checkIn;
            public string checkOut;
            public string pricePerNight;
        }


        // Sing: Function to retrieve flight details from the database based on the flight number and flight date.
        //This function returns a structure of flight details
        public static flightDetails getFlightDetails(string flightNum, string flightdate)
        {
            //Sing: Database connection declarations
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
            DataTable dtable = new DataTable();
            OleDbCommand command = new OleDbCommand();
            OleDbDataReader reader;

            //Sing : Login database connection
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=PrimaryDB.mdb;Jet OLEDB:Database Password=;";
            command.Connection = connection;

            connection.Open();
            //sing: SQL query string
            string query = "SELECT * FROM Flights WHERE FlightNumber =" + Int32.Parse(flightNum);
            command.CommandText = query;
            reader = command.ExecuteReader();

            //Sing: Define an instance of the flightDetails structure
            flightDetails flight = new flightDetails();

            //Get all flight details 
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    if (reader["FlightNumber"].ToString() == flightNum && reader["DepartureTime"].ToString() == (DateTime.Parse(flightdate)).ToString())
                    {
                        flight.flightNumber = flightNum;
                        flight.flightType = reader["FlightType"].ToString();
                        flight.destination = reader["Destination"].ToString();
                        flight.departure = reader["DepartureTime"].ToString();
                        flight.arrival = reader["ArrivalTime"].ToString();
                        flight.adultPrice = reader["AdultPrice"].ToString();
                        flight.childPrice = reader["ChildPrice"].ToString();
                    }
                }
                reader.Close();
            }
            connection.Close();
            //Sing: Check avalibality based on where entries for the date are availiable
            if (flight.departure == null)
            {
                MessageBox.Show("No availability found for this date.");
                return flight;
            }
            else
            {
                //Display flight data on front-end.
                return flight;
            }
           
        }


        // Sing: Function to retrieve car details details from the database based on the care hire name.
        //This function returns a structure of car rental details
        public static cars getCarDetails(string carHire)
        {
            //Sing: Database connection string declarations
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
            DataTable dtable = new DataTable();
            OleDbCommand command = new OleDbCommand();
            OleDbDataReader reader;

            //Sing : Login database connection
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=PrimaryDB.mdb;Jet OLEDB:Database Password=;";
            command.Connection = connection;

            connection.Open();
            //Sing: SQL database query string
            string query = "SELECT * FROM Cars WHERE CarRentalCompany ='" + carHire + "'";
            command.CommandText = query;
            reader = command.ExecuteReader();

            //Sing: Instantiating a new car structure
            cars carDetails = new cars();

            //Sing: Get all details of car rental 
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    if (reader["CarRentalCompany"].ToString() == carHire)
                    {
                        carDetails.numPlate = reader["NumberPlate"].ToString();
                        carDetails.carMake = reader["Make"].ToString();
                        carDetails.carModel = reader["Model"].ToString();
                        carDetails.carType = reader["CarType"].ToString();
                        carDetails.gearBox = reader["GearBox"].ToString();
                        carDetails.seats = reader["Seats"].ToString();
                        carDetails.pricePerDay = reader["pricePerDay"].ToString();
                    }
                }
                reader.Close();
            }
            connection.Close();
           //return car details
            return carDetails;
            
        }


        // Sing: Function to retrieve Hotel details from the database based on the hotel name.
        //This function returns a structure of hotel details
        public static hotel getHotelDetails(string hotelName)
        {
            //Sing: Database connection declaration 
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
            DataTable dtable = new DataTable();
            OleDbCommand command = new OleDbCommand();
            OleDbDataReader reader;

            //Sing : Login database connection
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=PrimaryDB.mdb;Jet OLEDB:Database Password=;";
            command.Connection = connection;

            connection.Open();
            //Sing: SQL database query
            string query = "SELECT * FROM Hotel WHERE HotelName ='" + hotelName + "'";
            command.CommandText = query;
            reader = command.ExecuteReader();
            //Sing: Instantiating a new hotel structure
            hotel hotelDetails = new hotel();

            //Sing : get all hotel details
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    if (reader["HotelName"].ToString() == hotelName)
                    {
                        hotelDetails.rating = reader["StarRating"].ToString();
                        hotelDetails.checkIn = reader["CheckIn"].ToString();
                        hotelDetails.checkOut = reader["CheckOut"].ToString();
                        hotelDetails.pricePerNight = reader["PricePerNight"].ToString();
                        
                    }
                }
                reader.Close();
            }
            connection.Close();
            //Sing: return hotel details
            return hotelDetails;

        }

    }

    public class SecondaryDatabase
    {
        public static bool recoveryProgress = false;
        
        //Batch recovery/resync in case of batch failure : Ndey
        public dynamic batchRecovery()
        {
            try
            {
                recoveryProgress = true;
                string fetchCustomersDB = "INSERT INTO PrimaryDB.mdb.Customers SELECT * FROM Customers",
                    fetchFlightsDB = "INSERT INTO PrimaryDB.mdb.Flights SELECT * FROM Flights",
                    fetchHotelDB = "INSERT INTO PrimaryDB.mdb.Hotel SELECT * FROM Hotel",
                    fetchCarsDB = "INSERT INTO PrimaryDB.mdb.Cars SELECT * FROM Cars";
                string[] dbList = { fetchCustomersDB, fetchFlightsDB, fetchHotelDB, fetchCarsDB };
                var primaryDatabase = new PrimaryDatabase();
                bool query = primaryDatabase.batchUpdate(dbList, true);
                recoveryProgress = false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Notify front-end of bacth recovery : Avar
        public static void notifyRecovery()
        {

            if (SecondaryDatabase.recoveryProgress == true)
            {
            
                MessageBox.Show("Holiday search might not be upto date");

            }
            //var secondaryDatabase = new SecondaryDatabase();
            //bool checkRecovery = SecondaryDatabase.recoveryProgress;
            //string message = "Holiday search might not be upto date";
            //string title = "Batch Recovery in progress";
            //MessageBox.Show(message, title);
        }

        struct customerDetails
        {
            public string fname;
            string sname;
            string address;
        }

        //Send print notification to front-end : Avar
        protected internal void sendPrintNotifications(string customerID)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
            DataTable dtable = new DataTable();
            OleDbCommand command = new OleDbCommand();
            OleDbDataReader reader;

            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=PrimaryDB.mdb";
            command.Connection = connection;

            connection.Open();

            string query = "SELECT * from Customers where [ID] =" + customerID;
            command.CommandText = query;
            reader = command.ExecuteReader();

            customerDetails details = new customerDetails();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    if (reader["ID"].ToString() == customerID)
                    {
                        details.fname = reader["CustomerFirstName"].ToString();
                    }
                }
                reader.Close();
            }
            connection.Close();
        }
    }
}
