using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_End
{
    //Database connection goes here : Akmal

    class Program
    {
        static void Main(string[] args)
        {
        }
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
        querydatabase("",false);

    }

    //Query database for information : Sing
    private void queryDatabase()
    {
    
         querydatabase("",false);

    }

    //Send print notification to front-end : Akmal
    private void sendPrintNotifications(){

    }

    //Batch recovery/resync in case of batch failure : Ndey
    private void batchRecovery(){
    
    }

    //Notify front-end of bacth recovery : Ndey
    private void notifyRecovery(){
    
    }
        
    

    //Sing : Query Databases Function - Accept query and returns boolean value.

         public bool querydatabase(string query, bool flag)
        {
            try
            {
                connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                return flag = true;
            }
            catch (Exception error)
            {
                connection.Close();
                MessageBox.Show(error.Message.ToString());
                return flag = false;
            }
        }


}
