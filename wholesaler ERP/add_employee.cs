using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using MySql.Data.MySqlClient;

using System.Windows.Forms;

namespace wholesaler_ERP
{
    public partial class add_employee : Form
    {

        Dictionary<string, int> job_titles = new Dictionary<string, int>();
        public add_employee()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            add_job newJob = new add_job();
            newJob.Show();
            load_jobs();
        }

        private void add_employee_Load(object sender, EventArgs e)
        {
          

            load_jobs();

            load_employees();


        }

        private void btn_employee_save_Click(object sender, EventArgs e)
        {
            string emp_job = "";
            emp_job = cmb_employee_job.Text;
            string emp_job_ID = get_job_ID(emp_job).ToString();
            try
            {
                if (txt_employee_name.Text != "" && cmb_employee_job.SelectedValue != "")
                {
                    Program.db.OpenConnection();
                    string query = "Insert INTO employees(emp_name,job_title_id,national_ID,address,phone,notes) Values ('" + txt_employee_name.Text + "' , '" + emp_job_ID + "', '" + txt_employee_ID.Text + "', '" + txt_employee_add.Text + "', '" + txt_employee_phone.Text + "', '" + txt_employee_notes.Text + "'); ";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    MessageBox.Show("تم تسجيل الموظف بنجاح");
                }
                else
                {
                    if (txt_employee_name.Text == "")
                    { MessageBox.Show("الرجاء ادخال اسم الموظف "); }
                    else if (emp_job == "") { MessageBox.Show("الرجاء ادخال نوع الوظيفه "); }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void load_jobs()
        {
            try { 
            job_titles.Clear();
            cmb_employee_job.Items.Clear();
            cmb_job_search.Items.Clear();
            cmb_update_employees.Items.Clear();
            Program.db.OpenConnection();
            MySqlDataReader row;
            string query = "select * from job_titles ";
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                cmb_employee_job.Items.Add(row[1].ToString());
                cmb_job_search.Items.Add(row[1].ToString());
                cmb_update_employees.Items.Add(row[1].ToString());

                job_titles.Add(row[1].ToString(), Convert.ToInt32(row[0]));
            }
            Program.db.close_reader();
            Program.db.CloseConnection();
        }
             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public int get_job_ID(string jobName)
        {
            int job_ID=0;
            job_ID = job_titles[jobName];
            return job_ID;
        }

        private void cmb_employee_job_MouseClick(object sender, MouseEventArgs e)
        {
            load_jobs();
        }

        public void load_employees()
        {
            try
            {
                cmb_empp_names.Items.Clear();
                dgv_employee_search.Rows.Clear();
                Program.db.OpenConnection();
                string query = "SELECT emp_ID,emp_name,phone,national_ID,address,job_name FROM employees e INNER JOIN job_titles j where e.job_title_id=j.job_ID";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    int rowId = dgv_employee_search.Rows.Add();
                    DataGridViewRow roww = dgv_employee_search.Rows[rowId];
                    // cmb.Items.Add(row["customer_name"].ToString());
                    roww.Cells[0].Value = row["emp_ID"].ToString();
                    roww.Cells[1].Value = row["emp_name"].ToString();
                    roww.Cells[2].Value = row["job_name"].ToString();
                    roww.Cells[3].Value = row["phone"].ToString();
                    roww.Cells[4].Value = row["national_id"].ToString();
                    roww.Cells[5].Value = row["address"].ToString();

                    cmb_empp_names.Items.Add(row["emp_name"].ToString());

                }
                Program.db.close_reader();
                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void cmb_job_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string search_job_employee = cmb_job_search.Text;
                int job_ID = get_job_ID(search_job_employee);
                dgv_employee_search.Rows.Clear();
                Program.db.OpenConnection();
                string query = "select emp_ID,emp_name,phone,national_ID,address,job_name" +
                    " FROM employees e INNER JOIN job_titles j  " +
                    "where e.job_title_id=j.job_ID and job_title_id='" + job_ID.ToString() + "' order by emp_ID";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    int rowId = dgv_employee_search.Rows.Add();
                    DataGridViewRow roww = dgv_employee_search.Rows[rowId];
                    // cmb.Items.Add(row["customer_name"].ToString());
                    roww.Cells[0].Value = row["emp_ID"].ToString();
                    roww.Cells[1].Value = row["emp_name"].ToString();
                    roww.Cells[2].Value = row["job_name"].ToString();
                    roww.Cells[3].Value = row["phone"].ToString();
                    roww.Cells[4].Value = row["national_id"].ToString();
                    roww.Cells[5].Value = row["address"].ToString();
                }
                Program.db.close_reader();

                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Program.db.CloseConnection();

            }
        }

        private void cmb_job_search_MouseClick(object sender, MouseEventArgs e)
        {
          //  load_jobs();
        }

        private void dgv_employee_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            txt_employee_search.Text = dgv_employee_search.CurrentRow.Cells[1].Value.ToString();
            txt_phone_search.Text = dgv_employee_search.CurrentRow.Cells[3].Value.ToString();
            txt_id_search.Text = dgv_employee_search.CurrentRow.Cells[4].Value.ToString();
            txt_add_search.Text = dgv_employee_search.CurrentRow.Cells[5].Value.ToString();
            cmb_update_employees.Text = dgv_employee_search.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgv_employee_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try {

                DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string emp_id = dgv_employee_search.CurrentRow.Cells[0].Value.ToString();
                    Program.db.OpenConnection();
                    string query = "Delete from employees where emp_ID='" + emp_id + "'";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    txt_add_search.Text = "";
                    txt_id_search.Text = "";
                    txt_phone_search.Text = "";
                    txt_employee_search.Text = "";
                    cmb_job_search.Text = "";
                    load_employees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string emp_id = dgv_employee_search.CurrentRow.Cells[0].Value.ToString();
                string jon_name= cmb_update_employees.Text;
                int job_ID = get_job_ID(jon_name);
                Program.db.OpenConnection();
                string query = "Update employees Set emp_name='" + txt_employee_search.Text 
                              + "', job_title_id='" + job_ID.ToString() 
                              + "', national_ID ='" + txt_id_search.Text 
                              + "', phone ='" + txt_phone_search.Text
                              + "', address ='" + txt_add_search.Text 
                              + "', national_ID ='" + txt_id_search.Text 
                              + "'where emp_ID ='" + Convert.ToInt32(emp_id) + "'";
                Program.db.ExecuteNonQuery(query);

                string query1 = "Update treasury Set operator_ID='" + txt_employee_search.Text
                            
                             + "'where operator_type ='موظف'";
                Program.db.ExecuteNonQuery(query1);

                Program.db.CloseConnection();
                load_employees();
                MessageBox.Show("تم تعديل البيانات");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_employee_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            load_employees();
            load_jobs();

        }

        private void cmb_empp_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string emp_name_search = cmb_empp_names.Text;
              //  int job_ID = get_job_ID(cmb_job_search.Text);
                dgv_employee_search.Rows.Clear();
                Program.db.OpenConnection();
                string query = "select emp_ID,emp_name,phone,national_ID,address,job_name" +
                    " FROM employees e INNER JOIN job_titles j  " +
                    "where e.job_title_id=j.job_ID  and emp_name='"+ emp_name_search+"' order by emp_ID";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    int rowId = dgv_employee_search.Rows.Add();
                    DataGridViewRow roww = dgv_employee_search.Rows[rowId];
                    // cmb.Items.Add(row["customer_name"].ToString());
                    roww.Cells[0].Value = row["emp_ID"].ToString();
                    roww.Cells[1].Value = row["emp_name"].ToString();
                    roww.Cells[2].Value = row["job_name"].ToString();
                    roww.Cells[3].Value = row["phone"].ToString();
                    roww.Cells[4].Value = row["national_id"].ToString();
                    roww.Cells[5].Value = row["address"].ToString();
                }
                Program.db.close_reader();

                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_job_search_Click(object sender, EventArgs e)
        {
          //  load_jobs();
        }
    }
    }


