using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Front_End
{
    class Connection
    {
        // WIP - need to correct the connection to the database
        public static string dbconnect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb";
        // Application.StartupPath + "\\Primary.mdb";
        public static OleDbConnection con = new OleDbConnection(dbconnect);

        public static void DB()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
