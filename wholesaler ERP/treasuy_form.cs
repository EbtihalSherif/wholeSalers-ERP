using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MySql.Data.MySqlClient;
using System.Linq.Expressions;

namespace wholesaler_ERP
{
    public partial class treasury_form : Form
    {

        Dictionary<string, int> employees_IDS = new Dictionary<string, int>();
        Dictionary<string, int> cutomers_IDS = new Dictionary<string, int>();


        bool new_added = false;

        double customer_credit = 0;
        public treasury_form()
        {
            InitializeComponent();
            load_employees();
            load_hesab();
        }

        private void bunifuCustomLabel25_Click(object sender, EventArgs e)
        {

        }


        private void treasury_form_Load(object sender, EventArgs e)
        {


           

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        public void load_employees()
        {
            try
            {
                employees_IDS.Clear();
                cmb_name.Items.Clear();
                Program.db.OpenConnection();
                string query = "SELECT emp_ID,emp_name,phone,national_ID,address,job_name FROM employees e INNER JOIN job_titles j where e.job_title_id=j.job_ID";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {

                    cmb_name.Items.Add(row["emp_name"].ToString());
                    employees_IDS.Add(row["emp_name"].ToString(), Convert.ToInt32(row["emp_ID"].ToString()));


                }
                row.Close();
                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void load_customers(string type)
        {
            //  try
            //{
            //  cutomers_IDS.Clear();
            cmb_name.Items.Clear();
            Program.db.OpenConnection();
            string query = "SELECT *  FROM customers  where customer_type='" + type + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {

                cmb_name.Items.Add(row["customer_name"].ToString());

                //  cutomers_IDS.Add(row["customer_name"].ToString(), Convert.ToInt32(row["customer_ID"].ToString()));


            }
            row.Close();
            Program.db.CloseConnection();
            // }
            // catch (Exception ex)
            // {
            //    MessageBox.Show(ex.ToString());
            // }
        }

        public int get_emp_ID(string empName)
        {
            int emp_ID = 0;
            emp_ID = employees_IDS[empName];
            return emp_ID;
        }
        public int get_customer_ID(string customerName)
        {
            int customer_ID = 0;
            customer_ID = cutomers_IDS[customerName];
            return customer_ID;
        }

        public int customer_Id(string name)
        {
            int id = 0;
            //  Program.db.OpenConnection();
            string query = "SELECT *  FROM customers  where customer_name='" + name + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {

                id = Convert.ToInt32(row["customer_ID"].ToString());
                customer_credit = Convert.ToInt32(row["credit"].ToString());
            }
            row.Close();
            //  Program.db.CloseConnection();
            return id;
        }
        public int employee_Id(string name)
        {
            int id = 0;
            //  Program.db.OpenConnection();
            string query = "SELECT *  FROM employees  where emp_name='" + name + "'";
            MySqlDataReader reader;
            reader = Program.db.ExecuteReader(query);
            while (reader.Read())
            {

                id = Convert.ToInt32(reader["emp_ID"].ToString());

            }
            reader.Close();
            //   Program.db.CloseConnection();
            return id;
        }
        public string customer_name(string id)
        {
            string name = "";
            //  Program.db.OpenConnection();
            string query = "SELECT *  FROM customers  where customer_ID='" + id + "'";
            MySqlDataReader reader;
            reader = Program.db.ExecuteReader(query);
            while (reader.Read())
            {

                name = (reader["customer_name"].ToString());

            }
            reader.Close();
            //  Program.db.CloseConnection();
            return name;
        }
        public string employee_name(string id)
        {
            string name = "";
            //  Program.db.OpenConnection();
            string query = "SELECT *  FROM employees  where emp_ID='" + id + "'";
            MySqlDataReader reader;
            reader = Program.db.ExecuteReader(query);
            while (reader.Read())
            {

                name = (reader["emp_name"].ToString());

            }
            reader.Close();
            //   Program.db.CloseConnection();
            return name;
        }
        private void dgv_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = "";
            name = cmb_name.Text;
            int operator_ID = 0;
            string operator_type = "";
            try
            {
                Program.db.OpenConnection();

                if (cmb_op_type.Text != "" && cmb_name.Text != "")
                {


                    if (cmb_op_type.Text == "صرف داخلي" || cmb_op_type.Text == "قبض داخلي")
                    {
                        operator_ID = employee_Id(name);
                        operator_type = "موظف";



                    }
                    else if (cmb_op_type.Text == "صرف خارجي")
                    {

                        //  operator_ID = customer_Id(name);

                        operator_type = "مورد";

                    }
                    else if (cmb_op_type.Text == "قبض خارجي")
                    {
                        int customer_ID = customer_Id(name);

                        operator_type = "عميل";
                        string query5 = "Update customers Set credit='" + (customer_credit - Convert.ToDouble(txt_money.Text))
                                     + "'where customer_ID ='" + customer_ID.ToString() + "'";
                        Program.db.ExecuteNonQuery(query5);

                    }
                    string query = "Insert INTO treasury(date,operation_type	,money_amount,money_for,notes,operator_ID,operator_type ) " +
                         "Values ('" + Convert.ToDateTime(dtp_st_date.Value).ToString("yyyy-MM-dd") + "' , '" + cmb_op_type.Text + "', '" + txt_money.Text + "', '" +
                         cmb_hesab_type.Text + "', '" + txt_notes.Text + "', '" + name + "', '" + operator_type + "'); ";
                    Program.db.ExecuteNonQuery(query);



                    Program.db.CloseConnection();
                    MessageBox.Show("تم تسجيل السند بنجاح");
                }
                else
                {
                    if (cmb_op_type.Text == "")
                    { MessageBox.Show("الرجاء ادخال نوع العمليه  "); }
                    else if (name == "") { MessageBox.Show("الرجاء ادخال اسم الموظف  "); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void cmb_opType_search_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_opType_search.Text == "صرف داخلي" || cmb_opType_search.Text == "قبض داخلي")
            {
                load_employees();
            }
            else if (cmb_opType_search.Text == "صرف خارجي")
            {
                load_customers("مورد");
            }
            else if (cmb_opType_search.Text == "قبض خارجي")
            {
                load_customers("عميل");

            }

            dgv_search.Rows.Clear();

            string name = "";
            Program.db.OpenConnection();
            string query = "select * FROM treasury  where operation_type='" + cmb_opType_search.Text + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                int rowId = dgv_search.Rows.Add();
                DataGridViewRow roww = dgv_search.Rows[rowId];
                roww.Cells[0].Value = row["ID"].ToString();
                roww.Cells[1].Value = row["operation_type"].ToString();
                roww.Cells[2].Value = row["money_for"].ToString();

                roww.Cells[4].Value = row["operator_type"].ToString();



                roww.Cells[3].Value = row["operator_ID"].ToString();
                if (row["operation_type"].ToString() == "صرف خارجي" || row["operation_type"].ToString() == "صرف داخلي")
                {
                    roww.Cells[6].Value = row["money_amount"].ToString();
                }
                else
                {
                    roww.Cells[5].Value = row["money_amount"].ToString();

                }
                roww.Cells[7].Value = row["date"].ToString();
                roww.Cells[8].Value = row["notes"].ToString();

            }
            Program.db.close_reader();

            Program.db.CloseConnection();


        }

        private void cmb_op_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_op_type.Text == "صرف داخلي" || cmb_op_type.Text == "قبض داخلي")
            {
                load_employees();
            }
            else if (cmb_op_type.Text == "صرف خارجي")
            {
                load_customers("مورد");
            }
            else if (cmb_op_type.Text == "قبض خارجي")
            {
                load_customers("عميل");

            }
        }

        private void dt_date_search_ValueChanged(object sender, EventArgs e)
        {
           // dgv_search.Rows.Clear();

          //  load_treasury();
        }

        public void load_treasury()
        {
            try
            {

                //string search_operation = cmb_opType_search.Text;
                //  int emp_ID = get_emp_ID(search_operation);
                dgv_search.Rows.Clear();

                string name = "";
                Program.db.OpenConnection();
                string query = "select * FROM treasury  where date >='" + Convert.ToDateTime(dt_date_search.Value).ToString("yyyy-MM-dd") +
                    "'and date <= '" + Convert.ToDateTime(dtp_end.Value).ToString("yyyy-MM-dd")+"' and operation_type= '"+cmb_opType_search.Text +"'";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    int rowId = dgv_search.Rows.Add();
                    DataGridViewRow roww = dgv_search.Rows[rowId];
                    roww.Cells[0].Value = row["ID"].ToString();
                    roww.Cells[1].Value = row["operation_type"].ToString();
                    roww.Cells[2].Value = row["money_for"].ToString();

                    roww.Cells[4].Value = row["operator_type"].ToString();

                    //if (row["operator_type"].ToString() == "موظف")
                    //{

                    //    name = employee_name(row["operator_ID"].ToString());
                    //}
                    //else if (row["operator_type"].ToString() == "عميل" || row["operator_type"].ToString() == "مورد")
                    //{
                    //    name = customer_name(row["operator_ID"].ToString());

                    //}

                    roww.Cells[3].Value = row["operator_ID"].ToString();
                    if (row["operation_type"].ToString() == "صرف خارجي" || row["operation_type"].ToString() == "صرف داخلي")
                    {
                        roww.Cells[6].Value = row["money_amount"].ToString();
                    }
                    else
                    {
                        roww.Cells[5].Value = row["money_amount"].ToString();

                    }
                    roww.Cells[7].Value = row["date"].ToString();
                    roww.Cells[8].Value = row["notes"].ToString();

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
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                string money = txt_money_search.Text;

                string name = dgv_search.CurrentRow.Cells[3].Value.ToString();
                string op_type = dgv_search.CurrentRow.Cells[4].Value.ToString();
                int ID = 0;
                if (op_type == "عميل")
                {
                    ID = customer_Id(name);
                    string query5 = "Update customers Set credit='" + (customer_credit + Convert.ToDouble(money))
                                    + "'where customer_ID ='" + ID.ToString() + "'";
                    Program.db.ExecuteNonQuery(query5);

                }


                string id = dgv_search.CurrentRow.Cells[0].Value.ToString();
                Program.db.OpenConnection();
                string query = "Delete from treasury where ID='" + id + "'";
                Program.db.ExecuteNonQuery(query);
                Program.db.CloseConnection();
                txt_money_search.Text = "";
                cmb_empname_search.Text = "";
                cmb_opType_search.Text = "";

                MessageBox.Show("تم الحذف");
                load_treasury();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Program.db.CloseConnection();

            }
        }

        private void dgv_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_sanad_search.Text = dgv_search.CurrentRow.Cells[0].Value.ToString();
                cmb_opType_search.Text = dgv_search.CurrentRow.Cells[1].Value.ToString();
                cmb_empname_search.Text = dgv_search.CurrentRow.Cells[3].Value.ToString();
                txt_notes_search.Text = dgv_search.CurrentRow.Cells[8].Value.ToString();
                if (dgv_search.CurrentRow.Cells[6].Value == null)
                    txt_money_search.Text = dgv_search.CurrentRow.Cells[5].Value.ToString();
                else if (dgv_search.CurrentRow.Cells[5].Value == null)
                    txt_money_search.Text = dgv_search.CurrentRow.Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
            string query = "Update treasury Set money_amount='" + txt_money_search.Text
                         + "', money_for='" + cmb_hesab_search.Text
                         + "', notes='" + txt_notes_search.Text
                         + "'where ID ='" + txt_sanad_search.Text + "'";
            Program.db.ExecuteNonQuery(query);

            string money = txt_money_search.Text;
            string name = dgv_search.CurrentRow.Cells[3].Value.ToString();
            string op_type = dgv_search.CurrentRow.Cells[4].Value.ToString();
            int ID = 0;

            Program.db.CloseConnection();
            load_employees();
            MessageBox.Show("تم تعديل البيانات");
        }

        private void btn_save_tasfya_Click(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
            string query = "Insert INTO treasury(date,operation_type	,money_amount,money_for ) " +
                                    "Values ('" + Convert.ToDateTime(dt_date_tasfya.Value).ToString("yyyy-MM-dd") + "' , '" + "تصفيه" + "', '" + txt_tasfya_money.Text + "', '" +
                                    "تصفيه الخزنه" + "'); ";
            Program.db.ExecuteNonQuery(query);



            Program.db.CloseConnection();
            MessageBox.Show("تم تصفيه الخزنه بنجاح");

        }

        private void txt_hesab_type_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_hesab_Click(object sender, EventArgs e)
        {
            mn_hesab newone = new mn_hesab();
            newone.Show();


        }

        public void load_hesab()
        {
            cmb_hesab_search.Items.Clear();
            cmb_hesab_type.Items.Clear();
            Program.db.OpenConnection();
            string query = "select * from salary_type order by ID";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                cmb_hesab_search.Items.Add(row["Name"].ToString());
                cmb_hesab_type.Items.Add(row["Name"].ToString());
            }
            Program.db.CloseConnection();

        }

        private void cmb_hesab_type_SelectedIndexChanged(object sender, EventArgs e)
        {
       //     load_hesab();
        }

        private void cmb_hesab_type_Click(object sender, EventArgs e)
        {
        }

        private void cmb_empname_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_hesab_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_search.Rows.Clear();

            string name = "";
            Program.db.OpenConnection();
            string query = "select * FROM treasury  where money_for='" + cmb_hesab_search.Text + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                int rowId = dgv_search.Rows.Add();
                DataGridViewRow roww = dgv_search.Rows[rowId];
                roww.Cells[0].Value = row["ID"].ToString();
                roww.Cells[1].Value = row["operation_type"].ToString();
                roww.Cells[2].Value = row["money_for"].ToString();

                roww.Cells[4].Value = row["operator_type"].ToString();



                roww.Cells[3].Value = row["operator_ID"].ToString();
                if (row["operation_type"].ToString() == "صرف خارجي" || row["operation_type"].ToString() == "صرف داخلي")
                {
                    roww.Cells[6].Value = row["money_amount"].ToString();
                }
                else
                {
                    roww.Cells[5].Value = row["money_amount"].ToString();

                }
                roww.Cells[7].Value = row["date"].ToString();
                roww.Cells[8].Value = row["notes"].ToString();

            }
            Program.db.close_reader();

            Program.db.CloseConnection();

        }

        private void cmb_hesab_type_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            dgv_search.Rows.Clear();
            load_treasury();
        }

        private void cmb_hesab_type_MouseEnter(object sender, EventArgs e)
        {

            if (new_added == true)
            {
                load_hesab();

                new_added = false;
            }
        }
    }
}
