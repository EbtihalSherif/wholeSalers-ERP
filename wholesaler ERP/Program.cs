using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace wholesaler_ERP
{
    static class Program
    {

        public static bool OpenDetailFormOnClose { get; set; }
        public static bool sales_close=false, puechase_close = false;
        public static DBconnect db = new DBconnect();

        public static int user_ID, record_ID;

        public static double treasury_amount=0;
        public static string bill_type = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login_form());
            if (OpenDetailFormOnClose)
            {
                Application.Run(new mainForm());
            }
        }


        public static void treasury_count()
        {
            double money_srf = 0;
            db.OpenConnection();
            string query = "SELECT SUM(money_amount) FROM treasury WHERE operation_type='قبض خارجي' or operation_type='قبض داخلي' ";
            MySqlDataReader row = db.ExecuteReader(query);
            while (row.Read())
            {
                treasury_amount =Convert.ToDouble( row[0].ToString());

            }
            row.Close();

            string query1 = "SELECT SUM(money_amount) FROM treasury WHERE operation_type='صرف خارجي' or operation_type='صرف داخلي' or  operation_type='تصفيه' ";
            MySqlDataReader row1 = db.ExecuteReader(query1);
            while (row1.Read())
            {
                money_srf = Convert.ToDouble(row1[0].ToString());

            }
            row1.Close();

            treasury_amount -= money_srf;

            db.CloseConnection();

        }
    }
}
