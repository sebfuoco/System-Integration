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
            // Must initalise class before use
            var primaryDatabase = new PrimaryDatabase();
            var secondaryDatabase = new SecondaryDatabase();
            // tests
            primaryDatabase.fetchData();
            primaryDatabase.batchUpdate();
        }

        //Sing : Class Constructor 
        public Program()
        {
            //Sing : Login database connection
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Users.mdb;Jet OLEDB:Database";
            command.Connection = connection;
        }


        //Sing : Login for Front-end.
        private void authenticateUser(string username, string password)
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
                    //admin credentials are used.
                    //Open admin page 
                    //Login authenticated
                }
                else
                {
                    //username and password exists in the database
                    connection.Close();
                    //normal user authenticated
                }
            }

        }
    }
    class PrimaryDatabase
    {
        //Fetch new bookings : Seb
        protected internal void fetchData()
        {
            Console.WriteLine("HELLO");
            Console.ReadKey();
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
        //Notify front-end of bacth recovery : Akmal
        protected internal void notifyRecovery()
        {

        }
        //Send print notification to front-end : Akmal
        protected internal void sendPrintNotifications()
        {

        }
    }
}