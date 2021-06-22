using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MySql.Data.MySqlClient;
namespace wholesaler_ERP
{
    public partial class reports_usercontrol : UserControl
    {
        static int index;
        public static string bill_id = "";
        public static int index2;
        public reports_usercontrol()
        {
            InitializeComponent();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reports_usercontrol_Load(object sender, EventArgs e)
        {


        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_show_bills_Click(object sender, EventArgs e)
        {
            dgv_bills.Rows.Clear();

            Program.db.OpenConnection();

            //btn_sales_bill_details.Enabled = true;
            ///////////ALL////////////////////
            if ((string)cmb_bill_typee.SelectedItem == "الكل" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "الكل")
            {
                string query = "select purchase_bill.bill_ID,bill_type,customers.customer_name,bill_date,discount_amount,total_price" +
                " from purchase_bill INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID " +
                "order by purchase_bill.bill_ID ASC";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                string query2 = "select sales_bill.bill_ID,bill_type,customers.customer_name,bill_date,discount_amount,total_price" +
                    " from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID " +
                    "order by sales_bill.bill_ID ASC";
                MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
                while (dr2.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr2["bill_ID"].ToString();
                    roww.Cells[1].Value = dr2["bill_type"].ToString();
                    roww.Cells[2].Value = dr2["customer_name"].ToString();
                    roww.Cells[3].Value = dr2["bill_date"].ToString();
                    roww.Cells[4].Value = dr2["discount_amount"].ToString();
                    roww.Cells[5].Value = dr2["total_price"].ToString();
                }
                dr2.Close();

            //    Program.db.CloseConnection();
            }
            ////////////////All with time
            if ((string)cmb_bill_typee.SelectedItem == "الكل" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "الكل")
            {
              //  Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,bill_type,customers.customer_name,bill_date," +
                    "discount_amount,total_price from purchase_bill INNER JOIN customers ON" +
                    " purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "'" +
                    " AND purchase_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' order by purchase_bill.bill_ID ASC";

                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                string query2 = "select sales_bill.bill_ID,bill_type,customers.customer_name,bill_date," +
                "discount_amount,total_price from sales_bill INNER JOIN customers " +
                "ON sales_bill.customer_id=customers.customer_ID" +
                " where sales_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND" +
                " sales_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "'order by sales_bill.bill_ID ASC ";
                MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
                while (dr2.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr2["bill_ID"].ToString();
                    roww.Cells[1].Value = dr2["bill_type"].ToString();
                    roww.Cells[2].Value = dr2["customer_name"].ToString();
                    roww.Cells[3].Value = dr2["bill_date"].ToString();
                    roww.Cells[4].Value = dr2["discount_amount"].ToString();
                    roww.Cells[5].Value = dr2["total_price"].ToString();
                }
                dr2.Close();

                //Program.db.CloseConnection();
            }

            else if ((string)cmb_bill_typee.SelectedItem == "الكل" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "نقدى")
            {
               // Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,purchase_bill.bill_type,customers.customer_name,purchase_bill.bill_date," +
                 "purchase_bill.discount_amount,purchase_bill.total_price from purchase_bill  INNER JOIN customers " +
                 "ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_type='" + "نقدى" + 
                 "'order by purchase_bill.bill_ID ASC";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                string query2 = "select sales_bill.bill_ID,sales_bill.bill_type,customers.customer_name,sales_bill.bill_date," +
                "sales_bill.discount_amount,sales_bill.total_price from sales_bill INNER JOIN customers " +
                "ON sales_bill.customer_id=customers.customer_ID  where sales_bill.bill_type='" + "نقدى" + "' ";
                MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
                while (dr2.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr2["bill_ID"].ToString();
                    roww.Cells[1].Value = dr2["bill_type"].ToString();
                    roww.Cells[2].Value = dr2["customer_name"].ToString();
                    roww.Cells[3].Value = dr2["bill_date"].ToString();
                    roww.Cells[4].Value = dr2["discount_amount"].ToString();
                    roww.Cells[5].Value = dr2["total_price"].ToString();
                }
                dr2.Close();
                //Program.db.CloseConnection();
            }
            /////////////////Time////////////
            else if ((string)cmb_bill_typee.SelectedItem == "الكل" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "نقدى")
            {
               // Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,purchase_bill.bill_type,customers.customer_name,purchase_bill.bill_date,purchase_bill.discount_amount,purchase_bill.total_price from purchase_bill  INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_type='" + "نقدى" + "' And  purchase_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND purchase_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                string query2 = "select sales_bill.bill_ID,sales_bill.bill_type,customers.customer_name,sales_bill.bill_date,sales_bill.discount_amount,sales_bill.total_price" +
                " from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID " +
                " where sales_bill.bill_type='" + "نقدى" + "' AND sales_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND sales_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
                while (dr2.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr2["bill_ID"].ToString();
                    roww.Cells[1].Value = dr2["bill_type"].ToString();
                    roww.Cells[2].Value = dr2["customer_name"].ToString();
                    roww.Cells[3].Value = dr2["bill_date"].ToString();
                    roww.Cells[4].Value = dr2["discount_amount"].ToString();
                    roww.Cells[5].Value = dr2["total_price"].ToString();
                }
                dr2.Close();
               // Program.db.CloseConnection();
            }
            else if ((string)cmb_bill_typee.SelectedItem == "الكل" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "اجل")
            {
               // Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,purchase_bill.bill_type,customers.customer_name,purchase_bill.bill_date,purchase_bill.discount_amount,purchase_bill.total_price from purchase_bill  INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_type='" + "اجل" + "'";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                string query2 = "select sales_bill.bill_ID,sales_bill.bill_type,customers.customer_name,sales_bill.bill_date,sales_bill.discount_amount,sales_bill.total_price from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID  where sales_bill.bill_type='" + "اجل" + "' ";
                MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
                while (dr2.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr2["bill_ID"].ToString();
                    roww.Cells[1].Value = dr2["bill_type"].ToString();
                    roww.Cells[2].Value = dr2["customer_name"].ToString();
                    roww.Cells[3].Value = dr2["bill_date"].ToString();
                    roww.Cells[4].Value = dr2["discount_amount"].ToString();
                    roww.Cells[5].Value = dr2["total_price"].ToString();
                }
                dr2.Close();
               // Program.db.CloseConnection();

            }
            //////////////////Time
            else if ((string)cmb_bill_typee.SelectedItem == "الكل" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "اجل")
            {
               // Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,purchase_bill.bill_type,customers.customer_name,purchase_bill.bill_date,purchase_bill.discount_amount,purchase_bill.total_price from purchase_bill  INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_type='" + "اجل" + "'AND purchase_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND purchase_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                string query2 = "select sales_bill.bill_ID,sales_bill.bill_type,customers.customer_name,sales_bill.bill_date,sales_bill.discount_amount,sales_bill.total_price from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID  where sales_bill.bill_type='" + "اجل" + "'AND sales_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND sales_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
                while (dr2.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr2["bill_ID"].ToString();
                    roww.Cells[1].Value = dr2["bill_type"].ToString();
                    roww.Cells[2].Value = dr2["customer_name"].ToString();
                    roww.Cells[3].Value = dr2["bill_date"].ToString();
                    roww.Cells[4].Value = dr2["discount_amount"].ToString();
                    roww.Cells[5].Value = dr2["total_price"].ToString();
                }
                dr2.Close();
               // Program.db.CloseConnection();

            }


            /////////////////////////
            else if ((string)cmb_bill_typee.SelectedItem == "مشتريات" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "الكل")
            {
                btn_purchased_bill_details.Enabled = true;
              //  Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,bill_type,customers.customer_name,bill_date,discount_amount,total_price from purchase_bill INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
               // Program.db.CloseConnection();
            }
            ////////////////TIME//////////////
            else if ((string)cmb_bill_typee.SelectedItem == "مشتريات" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "الكل")
            {
                btn_purchased_bill_details.Enabled = true;
               // Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,bill_type,customers.customer_name,bill_date,discount_amount,total_price from purchase_bill INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND purchase_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
               // Program.db.CloseConnection();
            }


            else if ((string)cmb_bill_typee.SelectedItem == "مشتريات" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "نقدى")
            {
                btn_purchased_bill_details.Enabled = true;
              //  Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,purchase_bill.bill_type,customers.customer_name,purchase_bill.bill_date,purchase_bill.discount_amount,purchase_bill.total_price from purchase_bill  INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_type='" + "نقدى" + "'";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
               // Program.db.CloseConnection();
            }
            ///////////////////TIME////////////////
            else if ((string)cmb_bill_typee.SelectedItem == "مشتريات" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "نقدى")
            {
                btn_purchased_bill_details.Enabled = true;
               // Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,purchase_bill.bill_type,customers.customer_name,purchase_bill.bill_date,purchase_bill.discount_amount,purchase_bill.total_price from purchase_bill  INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_type='" + "نقدى" + "'AND purchase_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND purchase_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
               // Program.db.CloseConnection();
            }

            else if ((string)cmb_bill_typee.SelectedItem == "مشتريات" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "اجل")
            {
                btn_purchased_bill_details.Enabled = true;
                //Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,purchase_bill.bill_type,customers.customer_name,purchase_bill.bill_date,purchase_bill.discount_amount,purchase_bill.total_price from purchase_bill INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_type='" + "اجل" + "'";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                //Program.db.CloseConnection();
            }
            /////////////TIME//////////
            else if ((string)cmb_bill_typee.SelectedItem == "مشتريات" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "اجل")
            {
                btn_purchased_bill_details.Enabled = true;
               // Program.db.OpenConnection();
                string query = "select purchase_bill.bill_ID,purchase_bill.bill_type,customers.customer_name,purchase_bill.bill_date,purchase_bill.discount_amount,purchase_bill.total_price from purchase_bill INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID where purchase_bill.bill_type='" + "اجل" + "'AND  purchase_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND purchase_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
               // Program.db.CloseConnection();
            }
            ////////////////////////////////////////////////////////////
            else if ((string)cmb_bill_typee.SelectedItem == "مبيعات" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "الكل")
            {
                btn_sal_bill_details.Enabled = true;
              //  Program.db.OpenConnection();
                string query = "select sales_bill.bill_ID,bill_type,customers.customer_name,bill_date,discount_amount,total_price " +
                "from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
               // Program.db.CloseConnection();
            }
            //////////////////TIME///////////////
            else if ((string)cmb_bill_typee.SelectedItem == "مبيعات" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "الكل")
            {
                btn_sal_bill_details.Enabled = true;
               // Program.db.OpenConnection();
                string query = "select sales_bill.bill_ID,bill_type,customers.customer_name,bill_date,discount_amount,total_price from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID where sales_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND sales_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
               // Program.db.CloseConnection();
            }
            else if ((string)cmb_bill_typee.SelectedItem == "مبيعات" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "نقدى")
            {
                btn_sal_bill_details.Enabled = true;
               // Program.db.OpenConnection();
                string query2 = "select sales_bill.bill_ID,sales_bill.bill_type,customers.customer_name,sales_bill.bill_date," +
                 "sales_bill.discount_amount,sales_bill.total_price from sales_bill INNER JOIN customers " +
                 "ON sales_bill.customer_id=customers.customer_ID  where sales_bill.bill_type='" + "نقدى" + "' ";
                MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
                while (dr2.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr2["bill_ID"].ToString();
                    roww.Cells[1].Value = dr2["bill_type"].ToString();
                    roww.Cells[2].Value = dr2["customer_name"].ToString();
                    roww.Cells[3].Value = dr2["bill_date"].ToString();
                    roww.Cells[4].Value = dr2["discount_amount"].ToString();
                    roww.Cells[5].Value = dr2["total_price"].ToString();
                }
                dr2.Close();
               // Program.db.CloseConnection();
            }
            ///////////TIME///////////////////////
            else if ((string)cmb_bill_typee.SelectedItem == "مبيعات" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "نقدى")
            {
                btn_sal_bill_details.Enabled = true;
              //  Program.db.OpenConnection();
                string query = "select sales_bill.bill_ID,sales_bill.bill_type,customers.customer_name,sales_bill.bill_date,sales_bill.discount_amount,sales_bill.total_price" +
                " from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID where sales_bill.bill_type='" + "نقدى" +
                "'AND  sales_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd") + "' AND sales_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd") + "' ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                //Program.db.CloseConnection();
            }
            else if ((string)cmb_bill_typee.SelectedItem == "مبيعات" && alltimee.Checked == true && (string)cmb_bill_nature.SelectedItem == "اجل")
            {
                btn_sal_bill_details.Enabled = true;
                //Program.db.OpenConnection();
                string query = "select sales_bill.bill_ID,sales_bill.bill_type,customers.customer_name,sales_bill.bill_date,sales_bill.discount_amount,sales_bill.total_price from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID where sales_bill.bill_type='" + "اجل" + "'";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
                //Program.db.CloseConnection();
            }
            ////////////////TIME/////////////////
            else if ((string)cmb_bill_typee.SelectedItem == "مبيعات" && sp_time.Checked == true && (string)cmb_bill_nature.SelectedItem == "اجل")
            {
                btn_sal_bill_details.Enabled = true;
               // Program.db.OpenConnection();
                string query = "select sales_bill.bill_ID,sales_bill.bill_type,customers.customer_name,sales_bill.bill_date,sales_bill.discount_amount,sales_bill.total_price from sales_bill INNER JOIN customers ON sales_bill.customer_id=customers.customer_ID where sales_bill.bill_type='" + "اجل" + "'AND  sales_bill.bill_date>='" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd ") + "' AND sales_bill.bill_date<='" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {

                    int rowId = dgv_bills.Rows.Add();
                    DataGridViewRow roww = dgv_bills.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["bill_type"].ToString();
                    roww.Cells[2].Value = dr["customer_name"].ToString();
                    roww.Cells[3].Value = dr["bill_date"].ToString();
                    roww.Cells[4].Value = dr["discount_amount"].ToString();
                    roww.Cells[5].Value = dr["total_price"].ToString();
                }
                dr.Close();
               // Program.db.CloseConnection();
            }
            Program.db.CloseConnection();
            txt_total.Text = dgv_bills.Rows.Count.ToString();
        }

        private void bunifuMetroTextbox14_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_moneyForme_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void transac_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            dgv_treasury.Rows.Clear();


            if ((string)transac_type.SelectedItem == "الكل" && alltime.Checked == true)
            {
                Program.db.OpenConnection();
                
                string query3 = " select * from treasury";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query3);
                while (dr1.Read())
                {
                    int rowId = dgv_treasury.Rows.Add();
                    DataGridViewRow roww = dgv_treasury.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();

                    if (dr1["operation_type"].ToString() == "صرف داخلي" || dr1["operation_type"].ToString() == "صرف خارجي" || dr1["operation_type"].ToString() == "تصفيه")
                        roww.Cells[1].Value = dr1["money_amount"].ToString();
                    if (dr1["operation_type"].ToString() == "قبض داخلي" || dr1["operation_type"].ToString() == "قبض خارجي")

                        roww.Cells[2].Value = dr1["money_amount"].ToString(); ;
                    // dr1["left_money"].ToString();
                    roww.Cells[3].Value = dr1["date"].ToString();
                    roww.Cells[4].Value = dr1["operator_ID"].ToString() + " - " + dr1["operator_type"].ToString() + " - " + dr1["money_for"].ToString();

                }

                Program.db.CloseConnection();
            }
            else if ((string)transac_type.SelectedItem == "الكل" && specifictime.Checked == true)
            {

                Program.db.OpenConnection();
               string query3 = " select * from treasury where date  >= '" + Convert.ToDateTime(dateTimePicker4.Value).ToString("yyyy-MM-dd ")
                    + "' AND  date  <='" + Convert.ToDateTime(dateTimePicker3.Value).ToString("yyyy-MM-dd ") + "' "; ;
                MySqlDataReader dr1 = Program.db.ExecuteReader(query3);
                while (dr1.Read())
                {
                    int rowId = dgv_treasury.Rows.Add();
                    DataGridViewRow roww = dgv_treasury.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();

                    if (dr1["operation_type"].ToString() == "صرف داخلي" || dr1["operation_type"].ToString() == "صرف خارجي" || dr1["operation_type"].ToString() == "تصفيه")
                    { roww.Cells[1].Value = dr1["money_amount"].ToString();
                    }
                    if (dr1["operation_type"].ToString() == "قبض داخلي" || dr1["operation_type"].ToString() == "قبض خارجي")

                        roww.Cells[2].Value = dr1["money_amount"].ToString(); ;
                    // dr1["left_money"].ToString();
                    roww.Cells[3].Value = dr1["date"].ToString();
                    roww.Cells[4].Value = dr1["operator_ID"].ToString() + " - " + dr1["operator_type"].ToString() + " - " + dr1["money_for"].ToString();

                }

                dr1.Close();

                Program.db.CloseConnection();
            }
            else if ((string)transac_type.SelectedItem == "صرف" && specifictime.Checked == true)
            {

                Program.db.OpenConnection();
                string query3 = " select * from treasury where date >='" + Convert.ToDateTime(dateTimePicker4.Value).ToString("yyyy-MM-dd ")
                    + "' AND date<='" + Convert.ToDateTime(dateTimePicker3.Value).ToString("yyyy-MM-dd ") + "' and (operation_type='صرف داخلي'  or operation_type='صرف خارجي' or operation_type='تصفيه') "; ;
                MySqlDataReader dr1 = Program.db.ExecuteReader(query3);
                while (dr1.Read())
                {
                    int rowId = dgv_treasury.Rows.Add();
                    DataGridViewRow roww = dgv_treasury.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();

                    if (dr1["operation_type"].ToString() == "صرف داخلي" || dr1["operation_type"].ToString() == "صرف خارجي" || dr1["operation_type"].ToString() == "تصفيه")
                        roww.Cells[1].Value = dr1["money_amount"].ToString();
                    if (dr1["operation_type"].ToString() == "قبض داخلي" || dr1["operation_type"].ToString() == "قبض خارجي")

                        roww.Cells[2].Value = dr1["money_amount"].ToString(); ;
                    // dr1["left_money"].ToString();
                    roww.Cells[3].Value = dr1["date"].ToString();
                    roww.Cells[4].Value = dr1["operator_ID"].ToString() + " - " + dr1["operator_type"].ToString() + " - " + dr1["money_for"].ToString();

                }
                dr1.Close();
                Program.db.CloseConnection();


            }
            else if ((string)transac_type.SelectedItem == "صرف" && alltime.Checked == true)
            {
                Program.db.OpenConnection();
               
                string query3 = " select * from treasury where operation_type='صرف داخلي'  or operation_type='صرف خارجي' or operation_type='تصفيه'";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query3);
                while (dr1.Read())
                {
                    int rowId = dgv_treasury.Rows.Add();
                    DataGridViewRow roww = dgv_treasury.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();

                    if (dr1["operation_type"].ToString() == "صرف داخلي" || dr1["operation_type"].ToString() == "صرف خارجي" || dr1["operation_type"].ToString() == "تصفيه")
                        roww.Cells[1].Value = dr1["money_amount"].ToString();
                    if (dr1["operation_type"].ToString() == "قبض داخلي" || dr1["operation_type"].ToString() == "قبض خارجي")

                        roww.Cells[2].Value = dr1["money_amount"].ToString(); ;
                    // dr1["left_money"].ToString();
                    roww.Cells[3].Value = dr1["date"].ToString();
                    roww.Cells[4].Value = dr1["operator_ID"].ToString() + " - " + dr1["operator_type"].ToString() + " - " + dr1["money_for"].ToString();

                }
                dr1.Close();


                Program.db.CloseConnection();
            }
            else if ((string)transac_type.SelectedItem == "قبض" && specifictime.Checked == true)
            {

                Program.db.OpenConnection();
               

                string query3 = " select * from treasury where date >='" + Convert.ToDateTime(dateTimePicker4.Value).ToString("yyyy-MM-dd ")
                                   + "' AND date<='" + Convert.ToDateTime(dateTimePicker3.Value).ToString("yyyy-MM-dd ") + "' and (operation_type='قبض داخلي'  or operation_type='قبض خارجي') "; 
                MySqlDataReader dr1 = Program.db.ExecuteReader(query3);
                while (dr1.Read())
                {
                    int rowId = dgv_treasury.Rows.Add();
                    DataGridViewRow roww = dgv_treasury.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();

                    if (dr1["operation_type"].ToString() == "صرف داخلي" || dr1["operation_type"].ToString() == "صرف خارجي" || dr1["operation_type"].ToString() == "تصفيه")
                        roww.Cells[1].Value = dr1["money_amount"].ToString();
                    if (dr1["operation_type"].ToString() == "قبض داخلي" || dr1["operation_type"].ToString() == "قبض خارجي")

                        roww.Cells[2].Value = dr1["money_amount"].ToString(); ;
                    // dr1["left_money"].ToString();
                    roww.Cells[3].Value = dr1["date"].ToString();
                    roww.Cells[4].Value = dr1["operator_ID"].ToString() + " - " + dr1["operator_type"].ToString() + " - " + dr1["money_for"].ToString();

                }
                dr1.Close();


                Program.db.CloseConnection();
            }
            else if ((string)transac_type.SelectedItem == "قبض" && alltime.Checked == true)
            {
                Program.db.OpenConnection();
               
                string query3 = " select * from treasury where operation_type='قبض داخلي'  or operation_type='قبض خارجي' ";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query3);
                while (dr1.Read())
                {
                    int rowId = dgv_treasury.Rows.Add();
                    DataGridViewRow roww = dgv_treasury.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();

                    if (dr1["operation_type"].ToString() == "صرف داخلي" || dr1["operation_type"].ToString() == "صرف خارجي" || dr1["operation_type"].ToString() == "تصفيه")
                        roww.Cells[1].Value = dr1["money_amount"].ToString();
                    if (dr1["operation_type"].ToString() == "قبض داخلي" || dr1["operation_type"].ToString() == "قبض خارجي")

                        roww.Cells[2].Value = dr1["money_amount"].ToString(); ;
                    // dr1["left_money"].ToString();
                    roww.Cells[3].Value = dr1["date"].ToString();
                    roww.Cells[4].Value = dr1["operator_ID"].ToString() + " - " + dr1["operator_type"].ToString() + " - " + dr1["money_for"].ToString();

                }
                dr1.Close();


                Program.db.CloseConnection();
            }


            double total_paid = 0;
            double total_recieved = 0;
            for (int i = 0; i < dgv_treasury.RowCount; i++)
            {
                total_paid += Convert.ToDouble(dgv_treasury.Rows[i].Cells[1].Value);
                total_recieved += Convert.ToDouble(dgv_treasury.Rows[i].Cells[2].Value);

            }
            Program.treasury_count();
            txt_treasury_total.Text = Program.treasury_amount.ToString();
            txt_paid.Text = total_paid.ToString();
            txt_recieved.Text = total_recieved.ToString();


        }

        private void specifictime_CheckedChanged(object sender, EventArgs e)
        {
            if (specifictime.Checked == true)
            {

                fromdate.Visible = true;
                todate.Visible = true;
                dateTimePicker3.Visible = true;
                dateTimePicker4.Visible = true;
            }
            else
            {

                fromdate.Visible = false;
                todate.Visible = false;
                dateTimePicker3.Visible = false;
                dateTimePicker4.Visible = false;
            }
        }

        private void dgv_treasury_SelectionChanged(object sender, EventArgs e)
        {
            index = dgv_treasury.CurrentCell.RowIndex;
        }

        private void dgv_treasury_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txt_treasury_total_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_treasury_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (specific_Time_radioButton.Checked == true)
            {
                from_date.Visible = true;
                to_date.Visible = true;
                To_dateTimePicker.Visible = true;
                From_dateTimePicker.Visible = true;
            }
        }
        public int return_total_returned_purchased()
        {
            Program.db.OpenConnection();
            int total = 0;
            string query = "Select returned.product_quantity,returned.price FROM returned" +
            " where returned.returned_type='" + "مشتريات" + "'";
            MySqlDataReader dr1 = Program.db.ExecuteReader(query);
            while (dr1.Read())
            {
                int price = Int32.Parse(dr1["price"].ToString());
                int quantity = Int32.Parse(dr1["product_quantity"].ToString());
                total += (price * quantity);
            }
            Program.db.CloseConnection();
            return total;
        }
        public int return_total_returned_purchased_Time()
        {
            Program.db.OpenConnection();
            int total = 0;
            string query = "Select returned.product_quantity,returned.price FROM returned " +
            "where returned.returned_type='" + "مشتريات" + "' AND  date>='" + Convert.ToDateTime(From_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' AND date<='" + Convert.ToDateTime(To_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' ";
            MySqlDataReader dr1 = Program.db.ExecuteReader(query);
            while (dr1.Read())
            {
                int price = Int32.Parse(dr1["price"].ToString());
                int quantity = Int32.Parse(dr1["product_quantity"].ToString());
                total += (price * quantity);
            }
            Program.db.CloseConnection();
            return total;
        }
        public int return_total_returned_sales()
        {
            Program.db.OpenConnection();
            int total = 0;
            string query = "Select returned.product_quantity,returned.price FROM returned " +
            "where returned.returned_type='" + "مبيعات" + "'";
            MySqlDataReader dr1 = Program.db.ExecuteReader(query);
            while (dr1.Read())
            {
                int price = Int32.Parse(dr1["price"].ToString());
                int quantity = Int32.Parse(dr1["product_quantity"].ToString());
                total += (price * quantity);
            }
            Program.db.CloseConnection();
            return total;
        }
        public int return_total_returned_sales_Time()
        {
            Program.db.OpenConnection();
            int total = 0;
            string query = "Select returned.product_quantity,returned.price " + "FROM returned " +
            "where returned.returned_type='" + "مبيعات" + "' AND  date>='" + Convert.ToDateTime(From_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' AND date<='" + Convert.ToDateTime(To_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' ";
            MySqlDataReader dr1 = Program.db.ExecuteReader(query);
            while (dr1.Read())
            {
                int price = Int32.Parse(dr1["price"].ToString());
                int quantity = Int32.Parse(dr1["product_quantity"].ToString());
                total += (price * quantity);
            }
            Program.db.CloseConnection();
            return total;
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            returned_dataGridView.Rows.Clear();
            if ((string)cmb_returns_type.SelectedItem == "الكل" && All_Time_radioButton.Checked == true)
            {
                txt_total_purchased.Text = "";
                txt_total_sales.Text = "";
                Program.db.OpenConnection();
                string query = "Select returned.ID,customers.customer_name,returned.total_price,returned.date," +
                "product.product_name,returned.product_quantity,returned.price " +
                "FROM returned INNER JOIN product ON returned.product_ID = product.product_ID INNER JOIN customers ON returned.customer_ID = customers.customer_ID ";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query);
                while (dr1.Read())
                {
                    int rowId = returned_dataGridView.Rows.Add();
                    DataGridViewRow roww = returned_dataGridView.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();
                    roww.Cells[1].Value = dr1["customer_name"].ToString();
                    roww.Cells[2].Value = dr1["product_name"].ToString();
                    roww.Cells[3].Value = dr1["price"].ToString();
                    roww.Cells[4].Value = dr1["product_quantity"].ToString();
                    roww.Cells[5].Value = (Int32.Parse(dr1["product_quantity"].ToString()) * Int32.Parse(dr1["price"].ToString())).ToString();
                    roww.Cells[6].Value = dr1["date"].ToString();
                }
                dr1.Close();
                Program.db.CloseConnection();
                txt_total_purchased.Text = return_total_returned_purchased().ToString();
                txt_total_sales.Text = return_total_returned_sales().ToString();

            }
            else if ((string)cmb_returns_type.SelectedItem == "مبيعات" && All_Time_radioButton.Checked == true)
            {
                txt_total_purchased.Text = "";
                txt_total_sales.Text = "";
                Program.db.OpenConnection();
                string query = "Select returned.ID,customers.customer_name,returned.total_price,returned.date,product.product_name,returned.product_quantity,returned.price " +
                "FROM returned INNER JOIN product ON returned.product_ID = product.product_ID INNER JOIN customers ON returned.customer_ID = customers.customer_ID" +
                " where returned.returned_type='" + "مبيعات" + "'";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query);
                while (dr1.Read())
                {
                    int rowId = returned_dataGridView.Rows.Add();
                    DataGridViewRow roww = returned_dataGridView.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();
                    roww.Cells[1].Value = dr1["customer_name"].ToString();
                    roww.Cells[2].Value = dr1["product_name"].ToString();
                    roww.Cells[3].Value = dr1["price"].ToString();
                    roww.Cells[4].Value = dr1["product_quantity"].ToString();
                    roww.Cells[5].Value = (Int32.Parse(dr1["product_quantity"].ToString()) * Int32.Parse(dr1["price"].ToString())).ToString();
                    roww.Cells[6].Value = dr1["date"].ToString();
                }
                dr1.Close();
                Program.db.CloseConnection();
                int total = returned_dataGridView.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[5].Value));
                txt_total_sales.Text = total.ToString();

            }
            else if ((string)cmb_returns_type.SelectedItem == "مشتريات" && All_Time_radioButton.Checked == true)
            {
                txt_total_purchased.Text = "";
                txt_total_sales.Text = "";
                Program.db.OpenConnection();
                string query = "Select returned.ID,customers.customer_name,returned.total_price,returned.date," +
                "product.product_name,returned.product_quantity,returned.price" +
                " FROM returned INNER JOIN product ON returned.product_ID = product.product_ID INNER JOIN customers " +
                "ON returned.customer_ID = customers.customer_ID where returned.returned_type='" + "مشتريات" + "'";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query);
                while (dr1.Read())
                {
                    int rowId = returned_dataGridView.Rows.Add();
                    DataGridViewRow roww = returned_dataGridView.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();
                    roww.Cells[1].Value = dr1["customer_name"].ToString();
                    roww.Cells[2].Value = dr1["product_name"].ToString();
                    roww.Cells[3].Value = dr1["price"].ToString();
                    roww.Cells[4].Value = dr1["product_quantity"].ToString();
                    roww.Cells[5].Value = (Int32.Parse(dr1["product_quantity"].ToString()) * Int32.Parse(dr1["price"].ToString())).ToString();
                    roww.Cells[6].Value = dr1["date"].ToString();
                }
                dr1.Close();
                Program.db.CloseConnection();
                int total = returned_dataGridView.Rows.Cast<DataGridViewRow>()
              .Sum(t => Convert.ToInt32(t.Cells[5].Value));
                txt_total_purchased.Text = total.ToString();

            }
            ////////////////////Time/////////////////////////

            else if ((string)cmb_returns_type.SelectedItem == "الكل" && specific_Time_radioButton.Checked == true)
            {
                txt_total_purchased.Text = "";
                txt_total_sales.Text = "";
                Program.db.OpenConnection();
                string query = "Select returned.ID,customers.customer_name,returned.total_price,returned.date,product.product_name,returned.product_quantity,returned.price " +
                "FROM returned INNER JOIN product ON returned.product_ID = product.product_ID" +
                " INNER JOIN customers ON returned.customer_ID = customers.customer_ID " +
                " where date>='" + Convert.ToDateTime(From_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' AND date<='" + Convert.ToDateTime(To_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query);
                while (dr1.Read())
                {
                    int rowId = returned_dataGridView.Rows.Add();
                    DataGridViewRow roww = returned_dataGridView.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();
                    roww.Cells[1].Value = dr1["customer_name"].ToString();
                    roww.Cells[2].Value = dr1["product_name"].ToString();
                    roww.Cells[3].Value = dr1["price"].ToString();
                    roww.Cells[4].Value = dr1["product_quantity"].ToString();
                    roww.Cells[5].Value = (Int32.Parse(dr1["product_quantity"].ToString()) * Int32.Parse(dr1["price"].ToString())).ToString();
                    roww.Cells[6].Value = dr1["date"].ToString();
                }
                dr1.Close();
                Program.db.CloseConnection();
                txt_total_purchased.Text = return_total_returned_purchased_Time().ToString();
                txt_total_sales.Text = return_total_returned_sales_Time().ToString();

            }
            else if ((string)cmb_returns_type.SelectedItem == "مبيعات" && specific_Time_radioButton.Checked == true)
            {
                txt_total_purchased.Text = "";
                txt_total_sales.Text = "";
                Program.db.OpenConnection();
                string query = "Select returned.ID,customers.customer_name,returned.total_price,returned.date,product.product_name,returned.product_quantity,returned.price " +
                "FROM returned INNER JOIN product ON returned.product_ID = product.product_ID INNER JOIN customers ON returned.customer_ID = customers.customer_ID" +
                " where returned.returned_type='" + "مبيعات" + "'" +
                " AND  date>='" + Convert.ToDateTime(From_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' AND date<='" + Convert.ToDateTime(To_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query);
                while (dr1.Read())
                {
                    int rowId = returned_dataGridView.Rows.Add();
                    DataGridViewRow roww = returned_dataGridView.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();
                    roww.Cells[1].Value = dr1["customer_name"].ToString();
                    roww.Cells[2].Value = dr1["product_name"].ToString();
                    roww.Cells[3].Value = dr1["price"].ToString();
                    roww.Cells[4].Value = dr1["product_quantity"].ToString();
                    roww.Cells[5].Value = (Int32.Parse(dr1["product_quantity"].ToString()) * Int32.Parse(dr1["price"].ToString())).ToString();
                    roww.Cells[6].Value = dr1["date"].ToString();
                }
                dr1.Close();
                Program.db.CloseConnection();
                int total = returned_dataGridView.Rows.Cast<DataGridViewRow>()
              .Sum(t => Convert.ToInt32(t.Cells[5].Value));
                txt_total_sales.Text = total.ToString();

            }
            else if ((string)cmb_returns_type.SelectedItem == "مشتريات" && specific_Time_radioButton.Checked == true)
            {
                Program.db.OpenConnection();
                string query = "Select returned.ID,customers.customer_name,returned.total_price,returned.date,product.product_name,returned.product_quantity,returned.price" +
                " FROM returned INNER JOIN product ON returned.product_ID = product.product_ID INNER JOIN customers ON returned.customer_ID = customers.customer_ID " +
                "where returned.returned_type='" + "مشتريات" + "' AND date>='" + Convert.ToDateTime(From_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' AND date<='" + Convert.ToDateTime(To_dateTimePicker.Value).ToString("yyyy-MM-dd ") + "' ";
                MySqlDataReader dr1 = Program.db.ExecuteReader(query);
                while (dr1.Read())
                {
                    int rowId = returned_dataGridView.Rows.Add();
                    DataGridViewRow roww = returned_dataGridView.Rows[rowId];
                    roww.Cells[0].Value = dr1["ID"].ToString();
                    roww.Cells[1].Value = dr1["customer_name"].ToString();
                    roww.Cells[2].Value = dr1["product_name"].ToString();
                    roww.Cells[3].Value = dr1["price"].ToString();
                    roww.Cells[4].Value = dr1["product_quantity"].ToString();
                    roww.Cells[5].Value = (Int32.Parse(dr1["product_quantity"].ToString()) * Int32.Parse(dr1["price"].ToString())).ToString();
                    roww.Cells[6].Value = dr1["date"].ToString();
                }
                dr1.Close();
                Program.db.CloseConnection();
                int total = returned_dataGridView.Rows.Cast<DataGridViewRow>()
              .Sum(t => Convert.ToInt32(t.Cells[5].Value));
                txt_total_purchased.Text = total.ToString();

            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
            string query = "select count(ID) from returned where returned_type='" + "مبيعات" + "'";
            MySqlDataReader dr = Program.db.ExecuteReader(query);
            if (dr.Read())
            {
                txt_total_sales.Text = dr.GetString(0);

            }
            dr.Close();
            string query2 = "select count(ID) from returned where returned_type='" + "مشتريات" + "'";
            MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
            if (dr2.Read())
            {
                txt_total_purchased.Text = dr2.GetString(0);

            }
            dr2.Close();
            Program.db.CloseConnection();

        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_bills_SelectionChanged(object sender, EventArgs e)
        {
            txt_total_purch.Text = "";
            txt_total_sal.Text = "";

        }

        private void dgv_bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = dgv_bills.CurrentCell.RowIndex;
            // MessageBox.Show(index2.ToString());
            Program.db.OpenConnection();
            if ((string)cmb_bill_typee.SelectedItem == "مشتريات")
            {
                string query = "select Count(purchased_bill_product.ID) FROM purchased_bill_product where purchased_bill_product.bill_ID='"
                    + dgv_bills.CurrentRow.Cells[0].Value.ToString() + "'";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                if (dr.Read())
                {
                    txt_total_purch.Text = dr.GetString(0);
                }
                dr.Close();
            }
            ///////////////////sales/////////////
            else if ((string)cmb_bill_typee.SelectedItem == "مبيعات")
            {
                string query_sal = "select Count(sales_bill_product.ID) FROM sales_bill_product where sales_bill_product.bill_ID='" + dgv_bills.CurrentRow.Cells[0].Value.ToString() + "'";
                MySqlDataReader dr_sal = Program.db.ExecuteReader(query_sal);
                if (dr_sal.Read())
                {
                    txt_total_sal.Text = dr_sal.GetString(0);
                }
                dr_sal.Close();
            }
            Program.db.CloseConnection();
        }



        private void sp_time_CheckedChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Visible = true;
            bunifuCustomLabel3.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void alltimee_CheckedChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Visible = false;
            bunifuCustomLabel3.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void All_Time_radioButton_CheckedChanged(object sender, EventArgs e)
        {

            from_date.Visible = false;
            to_date.Visible = false;
            To_dateTimePicker.Visible = false;
            From_dateTimePicker.Visible = false;

        }

        private void cmb_returns_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            returned_dataGridView.Rows.Clear();
            if ((string)cmb_returns_type.SelectedItem == "مبيعات")
            {
                Total_returned_sales_lbl.Visible = true;
                txt_total_sales.Visible = true;
                Total_retuned_purchased_lbl.Visible = false;
                txt_total_purchased.Visible = false;

            }
            else if ((string)cmb_returns_type.SelectedItem == "مشتريات")
            {
                Total_retuned_purchased_lbl.Visible = true;
                txt_total_purchased.Visible = true;
                Total_returned_sales_lbl.Visible = false;
                txt_total_sales.Visible = false;

            }
            else
            {
                Total_returned_sales_lbl.Visible = true;
                txt_total_sales.Visible = true;
                Total_retuned_purchased_lbl.Visible = true;
                txt_total_purchased.Visible = true;

            }
            txt_total_purchased.Text = "";
            txt_total_sales.Text = "";
        }

        private void dgv_bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {
            purchased_bill_details pd_details = new purchased_bill_details();
            bill_id = dgv_bills.Rows[index2].Cells[0].Value.ToString();
           // MessageBox.Show(bill_id);
            purchased_bill_details pbd = new purchased_bill_details();
            // this.Hide();

            pbd.Show();
            pbd.BringToFront();
           


        }

        private void cmb_bill_typee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmb_bill_typee.SelectedItem == "مشتريات" )
            { 
                txt_total_purch.Visible = true;
                txt_total_sal.Visible = false;
                lbl_purch.Visible = true;
                lbl_sal.Visible = false;
                btn_sal_bill_details.Visible = false;
                btn_purchased_bill_details.Visible = true;
                btn_purchased_bill_details.Enabled = false;
                Program.bill_type = "مشتريات";
        }
            else if((string)cmb_bill_typee.SelectedItem == "مبيعات")
            {
                txt_total_purch.Visible = false;
                txt_total_sal.Visible = true;
                lbl_sal.Visible = true;
                lbl_purch.Visible = false;
                btn_sal_bill_details.Visible = true;
                btn_purchased_bill_details.Visible =false;
                btn_sal_bill_details.Enabled = false;
                Program.bill_type = "مبيعات";
            }
            else
            {
                txt_total_sal.Visible = false;
                txt_total_purch.Visible = false;
                lbl_purch.Visible = false;
                lbl_sal.Visible = false;
                btn_purchased_bill_details.Visible = false;
                btn_sal_bill_details.Visible = false;
            }
        }

        private void btn_sal_bill_details_Click(object sender, EventArgs e)
        {
            bill_id = dgv_bills.Rows[index2].Cells[0].Value.ToString();
            purchased_bill_details pbd = new purchased_bill_details();
            pbd.Show();
            pbd.BringToFront();

          //  Program.db.OpenConnection();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //Excel_info ex = new Excel_info();
            //ex.Show();

        }

        private void lbl_sal_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_sal_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_total_purch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_purch_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_bill_nature_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel25_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_bills_Click(object sender, EventArgs e)
        {

        }

        private void Total_returned_sales_lbl_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_purchased_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_total_sales_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Total_retuned_purchased_lbl_Click(object sender, EventArgs e)
        {

        }

        private void returned_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void To_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void From_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void from_date_Click(object sender, EventArgs e)
        {

        }

        private void to_date_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {

        }

        private void alltime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_paid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_recieved_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fromdate_Click(object sender, EventArgs e)
        {

        }

        private void todate_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void tap_reprorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
