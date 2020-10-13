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

    class Program
    {
        static void Main(string[] args)
        {
        }


        //Fetch new bookings : Seb
        private void fetchData()
        {

        }

        //Batch update the secondary database : Seb
        private void batchUpdate()
        {

        }

        //Update Primary database with new bookings : Sing
        private void updatePrimaryDatabase()
        {
            query("", false);

        }

        //Query database for information : Sing
        private void queryDatabase()
        {

            query("", false);

        }

        //Send print notification to front-end : Akmal
        private void sendPrintNotifications()
        {

        }

        //Batch recovery/resync in case of batch failure : Ndey
        private void batchRecovery()
        {

        }

        //Notify front-end of bacth recovery : Akmal
        private void notifyRecovery()
        {

        }



        //Sing : Query Databases Function - Accept query and returns boolean value.

        public bool query(string query, bool flag)
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
}
