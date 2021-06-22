using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace wholesaler_ERP
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //  panel_main.Hide();
            admin_controller1.Hide();
            add_products1.Hide();
           inventory_usercontrol2.Hide();
            purchases_usercontrol1.Hide();
            reports_usercontrol1.Hide();
            salesusercontrol1.Hide();
            system_admins1.Hide();
           

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            add_Customer newCustomer = new add_Customer();
            newCustomer.Show();
        }

        private void bunifuTileButton12_Click(object sender, EventArgs e)
        {
            ////add_products newProduct = new add_products();

            ////panel_main.Controls.Add(newProduct);
            //newProduct.Show();
            //newProduct.BringToFront();
            add_products1.Show();
            add_products1.BringToFront();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            add_employee emp = new add_employee();
            emp.Show();
        }

        private void btn_purchases_Click(object sender, EventArgs e)
        {
            //purchases_usercontrol purchase = new purchases_usercontrol();

            //panel_main.Controls.Add(purchase);
            //purchase.Show();
            //purchase.BringToFront();
            purchases_usercontrol1.Show();
            purchases_usercontrol1.BringToFront();
            bunifuGradientPanel1.SendToBack();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            //salesusercontrol sales = new salesusercontrol();

            //panel_main.Controls.Add(sales);
            //sales.Show();
            //sales.BringToFront();
            salesusercontrol1.Show();
            salesusercontrol1.BringToFront();


        }

        private void btn_grpProducts_Click(object sender, EventArgs e)
        {
            products_group pg = new products_group();
            pg.Show();
        }

        private void btn_locker_Click(object sender, EventArgs e)
        {
            treasury_form tForm = new treasury_form();
            tForm.Show();
        }
      

        private void btn_users_Click(object sender, EventArgs e)
        {
            //system_admins admin = new system_admins();

            //panel_main.Controls.Add(admin);
            system_admins1.Show();
            system_admins1.BringToFront();
        }

        private void btn_userAttendance_Click(object sender, EventArgs e)
        {
           
            admin_controller1.Show();
            admin_controller1.BringToFront();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            //inventory_usercontrol inventory = new inventory_usercontrol();

            //panel_main.Controls.Add(inventory);
            //inventory.Show();
            //inventory.BringToFront();
            inventory_usercontrol2.Show();
            inventory_usercontrol2.BringToFront();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {

            //  panel_main.Controls.Clear();
            //  panel_main.Show();
            //reports_usercontrol report = new reports_usercontrol();

            //panel_main.Controls.Add(report);
            //report.Show();
            //report.BringToFront();
            reports_usercontrol1.Show();
            reports_usercontrol1.BringToFront();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
           

        }

        private void add_products1_Load(object sender, EventArgs e)
        {

        }

        private void salesusercontrol1_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string logout_date;
            string time;
            DateTime timenow = DateTime.Now;
            string date = DateTime.UtcNow.ToString("yyyy-MM-dd h:mm:ss");
            time = DateTime.Now.ToString("h:mm:ss tt");
             update_date_time_logout(date, time, Program.user_ID.ToString());

            // closeCurrent();
        }
        public void update_date_time_logout(string date, string time, string empID)
        {
            try
            {

                Program.db.OpenConnection();
                string rc_ID = "select record_ID FROM login_records where user_ID" +
                    "='" + Program.user_ID + "'";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(rc_ID);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        Program.record_ID = Int32.Parse(row["record_ID"].ToString());
                    }
                }
                row.Close();
                string query = "Update login_records" +
               " Set logout_date='" + date + "' ," +
               " logout_time='" + time + "'" +
               "where user_ID='" + empID + "'AND record_ID='" + Program.record_ID + "'";

                Program.db.ExecuteNonQuery(query);
                Program.db.CloseConnection();
                // this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Program.db.CloseConnection();

            }


        }

    }
}
