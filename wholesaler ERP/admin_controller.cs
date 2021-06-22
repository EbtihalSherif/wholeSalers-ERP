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
    public partial class admin_controller : UserControl
    {
        public admin_controller()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void admin_controller_Load(object sender, EventArgs e)
        {
           
            int rowId = dataGridView1.Rows.Add();

            // Grab the new row!
            DataGridViewRow row = dataGridView1.Rows[rowId];
            row.Cells[0].Value = "1";
            row.Cells[1].Value = "محمد";

            row.Cells[2].Value = "10-10-2020";
            row.Cells[3].Value = "10-10-2020";

            row.Cells[4].Value = "1:30";
            row.Cells[5].Value = "5:30 ";

            load_employees();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string start_date = dt_start.Value.ToString("yyyy-MM-dd");
                string end_date = dt_end.Value.ToString("yyyy-MM-dd");

                dataGridView1.Rows.Clear();
                Program.db.OpenConnection();
                string empName = cmb_employees.Text;
                string query = "SELECT l.user_id,e.emp_name,l.login_date,l.logout_date,l.login_time,l.logout_time FROM login_records l inner JOIN users u " +
                    "on l.user_ID=u.user_ID INNER join employees e on u.emp_id=e.emp_ID where e.emp_name='" + empName
                             + "' and l.login_date >= '" + start_date + "'and  l.login_date <='" + end_date + "'";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow roww = dataGridView1.Rows[rowId];
                    roww.Cells[0].Value = row["user_id"].ToString();
                    roww.Cells[1].Value = row["emp_name"].ToString();
                    roww.Cells[2].Value = row["login_date"].ToString();
                    roww.Cells[3].Value = row["logout_date"].ToString();
                    roww.Cells[4].Value = row["login_time"].ToString();
                    roww.Cells[5].Value = row["logout_time"].ToString();


                }
                Program.db.close_reader();
                Program.db.CloseConnection();
                //  MessageBox.Show("done");ebt 123
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Rows.Clear();
                Program.db.OpenConnection();
                string empName = cmb_employees.Text;
                string query = "SELECT l.user_id,e.emp_name,l.login_date,l.logout_date,l.login_time,l.logout_time FROM login_records l inner JOIN users u on l.user_ID=u.user_ID INNER join employees e on u.emp_id=e.emp_ID where e.emp_name='" + empName + "'";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow roww = dataGridView1.Rows[rowId];
                    // cmb.Items.Add(row["customer_name"].ToString());
                    roww.Cells[0].Value = row["user_id"].ToString();
                    roww.Cells[1].Value = row["emp_name"].ToString();
                    roww.Cells[2].Value = row["login_date"].ToString();
                    roww.Cells[3].Value = row["logout_date"].ToString();
                    roww.Cells[4].Value = row["login_time"].ToString();
                    roww.Cells[5].Value = row["logout_time"].ToString();


                }
                Program.db.close_reader();
                Program.db.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void load_employees()
        {
            try
            {
                Program.db.OpenConnection();
                string query = "SELECT emp_name from users u inner join employees e where u.emp_id=e.emp_ID";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    cmb_employees.Items.Add(row["emp_name"].ToString());
                }
                Program.db.close_reader();
                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
