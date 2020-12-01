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
            // tests
            bool query = primaryDatabase.batchUpdate(dbList, false);
            //bool squery = secondaryDatabase.batchRecovery();
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

        public static class calculations
        {

            public static int calculateSpacesLeft(string flightNum)
            {

                //Sing :  Database declarations
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                OleDbDataAdapter ad;
                DataTable dtable = new DataTable();
                OleDbCommand command = new OleDbCommand();
                OleDbDataReader reader;

                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Primary.mdb";
                command.Connection = connection;

                connection.Open();

                string query = "select * from Flights where [FlightNumber] =" + flightNum;
                command.CommandText = query;
                reader = command.ExecuteReader();

                int counter = 0;
                int numberOfSpace = 20;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        if (reader["FlightNumber"].ToString() == flightNum.ToString())
                        {
                            counter = counter + 1;
                        }
                    }
                    reader.Close();
                }
                connection.Close();

                return (numberOfSpace - counter);

            }

        }

        public static class login
        {
            //Sing : Login for Front-end.
            public static bool authenticateUser(string username, string password)
            {
                //Sing : login database declarations
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                OleDbDataAdapter ad;
                DataTable dtable = new DataTable();
                OleDbCommand command = new OleDbCommand();
                OleDbDataReader reader;

                //Sing : Login database connection
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=User.mdb;Jet OLEDB:Database Password=;";
                command.Connection = connection;

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

                    return false;

                }
                else if (dtable.Rows.Count > 0 && username == "admin" && password == "admin")
                {
                    //Data exists in the database, therefore this function checks where admin credientials are used.

                    connection.Close();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    class DatabaseFunctions
    {
        // store data to send: TEST fetchData()
        protected internal dynamic createDict()
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

        protected internal dynamic maxID(string connectionString, string sql)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand maxID = new OleDbCommand(sql, connection);
            int id = (Int32)maxID.ExecuteScalar();
            return id;
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

        protected internal void readDatabase(string sql, string connectionString)
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

        protected internal void editDatabase(string sql, string connectionString, Dictionary<string, object> details)
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

        protected internal void writeDatabase(string sql, string connectionString, Dictionary<string, object> details, object[] arr)
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

        protected internal dynamic writeIDDatabase(string sql, string sql2, string connectionString, Dictionary<string, object> details, object[] arr)
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
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb",
                   secondaryConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SecondaryDB.mdb";
            string readCustomerID = "SELECT @@IDENTITY AS CustomerID FROM Customers";
            var dbFunc = new DatabaseFunctions();
            // test ID
            //details["FlightNumber"] = 1200;
            //details["HotelID"] = 4510;
            object[] customers = {"@CustomerFirstName", details["CustomerFirstName"], "@CustomerLastName", details["CustomerLastName"], "@Gender", details["Gender"],
                    "@PassportNumber", details["PassportNumber"], "@Nationality", details["Nationality"], "@Address", details["Address"], "@PostCode",
                details["PostCode"], "@ContactNumber", details["ContactNumber"], "@EmailAddress", details["EmailAddress"]};
            details["CustomerID"] = dbFunc.writeIDDatabase(customerWriteDB, readCustomerID, connectionString, details, customers); // get customerID from insert query
            object[] flights = {"@FlightNumber", details["FlightNumber"], "@CustomerID", details["CustomerID"], "@HotelID", details["HotelID"],
                    "@FlightType", details["FlightType"], "@Departure", details["Departure"], "@Arrival", details["Arrival"],
                "@DepartureTime", details["DepartureTime"], "@ArrivalTime", details["ArrivalTime"], "@AdultPrice",
            details["AdultPrice"], "@ChildPrice", details["ChildPrice"]};
            dbFunc.writeDatabase(flightWriteDB, connectionString, details, flights);
            object[] hotel = {"@HotelID", details["HotelID"],"@StarRating", details["StarRating"], "@CheckIn", details["CheckIn"],
                    "@CheckOut", details["CheckOut"], "@PricePerNight", details["PricePerNight"], "@Country", details["Arrival"], "@NumberPlate",
                details["NumberPlate"], "@FlightNumber", details["FlightNumber"]};
            dbFunc.writeDatabase(hotelWriteDB, connectionString, details, hotel);
            object[] cars = {"@CarID", details["CarID"], "@NumberPlate", details["NumberPlate"], "@HotelID", details["HotelID"], "@Make", details["Make"], "@Model", details["Model"],
                "@CarType", details["CarType"], "@GearBox", details["GearBox"], "@Seats", details["Seats"], "@PricePerDay", details["PricePerDay"]};
            dbFunc.writeDatabase(carsWriteDB, connectionString, details, cars);
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
    }

    //Sing:
    public class DatabaseQuery
    {
        //Update Primary database with new bookings : Sing
        public void showBookings()
        {
            //connection.Open();

            //string query = "select * from ServiceTable where [ID] =" + Admin.ServiceID;
            //command.CommandText = query;
            //reader = command.ExecuteReader();

            //string inspection = "";

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {

            //        if (reader["ID"].ToString() == Admin.ServiceID.ToString())
            //        {
            //            inspection = reader["Inspection Complete"].ToString();
            //        }
            //    }
            //    reader.Close();
            //}
            //connection.Close();

            //if (inspection == "true")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}         
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
    }
    public class SecondaryDatabase
    {
        //Batch recovery/resync in case of batch failure : Ndey
        public dynamic batchRecovery()
        { // improve the batch update query if you want
            string fetchCustomersDB = "INSERT INTO PrimaryDB.mdb.Customers SELECT * FROM Customers",
                fetchFlightsDB = "INSERT INTO PrimaryDB.mdb.Flights SELECT * FROM Flights",
                fetchHotelDB = "INSERT INTO PrimaryDB.mdb.Hotel SELECT * FROM Hotel",
                fetchCarsDB = "INSERT INTO PrimaryDB.mdb.Cars SELECT * FROM Cars";
            string[] dbList = { fetchCustomersDB, fetchFlightsDB, fetchHotelDB, fetchCarsDB };
            var primaryDatabase = new PrimaryDatabase();
            bool query = primaryDatabase.batchUpdate(dbList, true);
            return true;
        }
        //Notify front-end of bacth recovery : Avar
        protected internal void notifyRecovery()
        {
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

            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Primary.mdb";
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