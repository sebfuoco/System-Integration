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
        //Database connection goes here : Ndey
        /* IMPORTANT!!!
         * Data being exchanged between programs must be in file format!
         * !!!
        */

        //Sing : login database declarations
        System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dtable = new DataTable();
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader reader;

        public static void Main(string[] args)
        {
            // Primary Database
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=HolidayBookingSystem.mdb";
            // Must initalise class before use
            var dbFunc = new DatabaseFunctions();
            var primaryDatabase = new PrimaryDatabase();
            var secondaryDatabase = new SecondaryDatabase();
            // tests
            //primaryDatabase.dummyWrite();
            //primaryDatabase.fetchData();
            primaryDatabase.batchUpdate();
            // Test database
            //dbFunc.writeDatabase(connectionString);
            //dbFunc.readDatabase(connectionString);
            //dbFunc.deleteDatabase(connectionString);
            dbFunc.checkDuplicateDatabase(connectionString);
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
        protected internal void checkDuplicateDatabase(string connectionString)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM CustomerDetails WHERE [FirstName] = @FirstName AND [LastName] = @LastName", conn))
                {
                    string firstName = "Julian", lastName = "Smith";
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
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

        protected internal void deleteDatabase(string connectionString)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                // Delete from ID range
                string sql = ("DELETE FROM CustomerDetails WHERE CustomerID BETWEEN 9 AND 15");
                conn.Open();
                OleDbCommand command = new OleDbCommand(sql, conn);
                command.ExecuteNonQuery();
            }
        }

        protected internal void writeDatabase(string connectionString)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string title = "Mr", firstName = "Bob", lastName = "Page", gender = "Male", nationality = "American", address = "America", 
                    email = "bobpage@gmail.com", customerAge = "20", passportNumber = "07771243", contactDetails = "771014512"; ;
                string[] arr = { "@title", title, "@firstName", firstName, "@lastName", lastName, "@gender", gender, "@customerAge", customerAge,
                    "@passportNumber", passportNumber, "@nationality", nationality, "@address", address, "@contactDetails", contactDetails, "@email", email };   
                string sql = ("INSERT INTO CustomerDetails (Title, FirstName, LastName, Gender, CustomerAge, PassportNumber, Nationality," +
                    "Address, ContactDetails, Email) VALUES (@title, @firstName, @lastName, @gender, @customerAge, @passportNumber, @nationality, @address," +
                    "@contactDetails, @email)");
                conn.Open();
                OleDbCommand command = new OleDbCommand(sql, conn);
                // loop through parameters
                for (int i = 0; i < arr.Length; i+=2){
                    command.Parameters.Add(new OleDbParameter(arr[i], OleDbType.VarChar)).Value = arr[i+1];
                }
                command.ExecuteNonQuery();
            }
        }

        protected internal void readDatabase(string connectionString)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                // query
                string sql = "SELECT * FROM CustomerDetails";
                // Create a command and set its connection  
                conn.Open();
                OleDbCommand command = new OleDbCommand(sql, conn);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) // reads all data from query
                {
                    Console.WriteLine($"Name: {reader.GetString(1)} {reader.GetString(2)} {reader.GetString(3)}");
                }
            }
            Console.ReadKey();
        }
    }

    class PrimaryDatabase
    {
        protected internal void dummyWrite()
        {
            if (!File.Exists("bookings.txt")){
                // Create a file to write to.
                using (StreamWriter writetext = new StreamWriter("bookings.txt"))
                {
                    // test
                    int price = 100;
                    string name = "Seb Fuoco", country = "Spain", city = "Barcelona", flightType = "return";
                    writetext.WriteLine($"{name}|{price}|{country}|{city}|{flightType}");
                }
            }
        }
        //Fetch new bookings : Seb
        protected internal void fetchData()
        {
            using (StreamReader readtext = new StreamReader("bookings.txt"))
            {
                Console.WriteLine(readtext.ReadLine());
                Console.ReadKey();
            }
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