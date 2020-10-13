using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /* IMPORTANT!!!
         * Data being exchanged between programs must be in file format!
         * !!!
        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
