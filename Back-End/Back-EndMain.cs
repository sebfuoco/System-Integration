using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Back_End
{
    //Database connection goes here : Ndey
    /* IMPORTANT!!!
     * Data being exchanged between programs must be in file format!
     * !!!
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            // Must initalise class before use
            var primaryDatabase = new PrimaryDatabase();
            var secondaryDatabase = new SecondaryDatabase();
            // tests
            primaryDatabase.fetchData();
            primaryDatabase.batchUpdate();
        }
        //Sing : Login for Front-end.
        private void authenticateUser(string username, string password)
            {
                if (username == "admin" && password == "password")
                {
                    //athenticate admin
                }
                else if (username == "normaluser" && password == "normalpassword")
                {
                    //athenticate normal user
                }
                else
                {
                    //username and password is wrong - try again.
                    MessageBox.Show("Username or password is incorrrect, please try again");
                };
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