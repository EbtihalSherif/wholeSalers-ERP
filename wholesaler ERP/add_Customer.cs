using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wholesaler_ERP
{
    public partial class add_Customer : Form
    {
       // DBconnect Program.db = new DBconnect();
        static int index;
        public add_Customer()
        {
            InitializeComponent();
        }
        public void load_cust_info()
        {
            cmb_search_customer.Items.Clear();
            dgv_search_customers.Rows.Clear();
            Program.db.OpenConnection();
            string query = "select * from customers";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                int rowId = dgv_search_customers.Rows.Add();
                DataGridViewRow roww = dgv_search_customers.Rows[rowId];
                cmb_search_customer.Items.Add(row["customer_name"].ToString());
                roww.Cells[0].Value = row["customer_ID"].ToString();
                roww.Cells[1].Value = row["customer_name"].ToString();
                roww.Cells[2].Value = row["customer_type"].ToString();
                roww.Cells[3].Value = row["credit"].ToString();
            }
            Program.db.CloseConnection();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            cmb_search_customer.Items.Clear();
            load_cust_info();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string cust_type = "";
            if (rd_customer.Checked == true)
            { cust_type = rd_customer.Text; }
            else if (RD_supplier.Checked == true)
            { cust_type = RD_supplier.Text; }

            try
            {
                if (txt_customer_Name.Text != "" && cust_type != "")
                {
                    Program.db.OpenConnection();
                    string query = "Insert INTO customers(customer_name,customer_type,national_ID,address,phone,notes) Values ('" + txt_customer_Name.Text + "' , '" + cust_type + "', '" + txt_customer_natID.Text + "', '" + txt_customer_address.Text + "', '" + txt_customer_phone.Text + "', '" + txt_customer_notes.Text + "'); ";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    MessageBox.Show("تم تسجيل العميل بنجاح");
                }
                else
                {
                    if (txt_customer_Name.Text == "")
                    { MessageBox.Show("الرجاء ادخال اسم العميل "); }
                    else if (cust_type == "") { MessageBox.Show("الرجاء ادخال اختيار نوع العميل "); }
                }
            }
            catch
            {

            }
        }

        private void add_Customer_Load(object sender, EventArgs e)
        {
            load_cust_info();

        }

        private void dgv_search_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_search_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_search_customers.Rows.Clear();
            Program.db.OpenConnection();
            string query = "select * from customers where customer_name='" + cmb_search_customer.SelectedItem.ToString() + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
           // cmb_search_customer.Items.Clear();
            while (row.Read())
            {
                int rowId = dgv_search_customers.Rows.Add();
                DataGridViewRow roww = dgv_search_customers.Rows[rowId];
                //cmb_search_customer.Items.Add(row["customer_name"].ToString());
                roww.Cells[0].Value = row["customer_ID"].ToString();
                roww.Cells[1].Value = row["customer_name"].ToString();
                roww.Cells[2].Value = row["customer_type"].ToString();
                roww.Cells[3].Value = row["credit"].ToString();
            }
            Program.db.CloseConnection();

        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cust_id = dgv_search_customers.Rows[index].Cells[0].Value.ToString();
                Program.db.OpenConnection();
                string query = "Delete from customers where customer_id='" + cust_id + "'";
                Program.db.ExecuteNonQuery(query);
                Program.db.CloseConnection();
                load_cust_info();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
          
        }

        private void Rd_customer_search_CheckedChanged(object sender, EventArgs e)
        {
            dgv_search_customers.Rows.Clear();
            Program.db.OpenConnection();
            string query = "select * from customers where customer_type='" + rd_customer.Text + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                int rowId = dgv_search_customers.Rows.Add();
                DataGridViewRow roww = dgv_search_customers.Rows[rowId];
              //  cmb_search_customer.Items.Add(row["customer_name"].ToString());
                roww.Cells[0].Value = row["customer_ID"].ToString();
                roww.Cells[1].Value = row["customer_name"].ToString();
                roww.Cells[2].Value = row["customer_type"].ToString();
                roww.Cells[3].Value = row["credit"].ToString();
            }
            Program.db.CloseConnection();


        }

        private void Rd_supplier_search_CheckedChanged(object sender, EventArgs e)
        {
            dgv_search_customers.Rows.Clear();
            Program.db.OpenConnection();
            string query = "select * from customers where customer_type='" + RD_supplier.Text + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                int rowId = dgv_search_customers.Rows.Add();
                DataGridViewRow roww = dgv_search_customers.Rows[rowId];
             //   cmb_search_customer.Items.Add(row["customer_name"].ToString());
                roww.Cells[0].Value = row["customer_ID"].ToString();
                roww.Cells[1].Value = row["customer_name"].ToString();
                roww.Cells[2].Value = row["customer_type"].ToString();
                roww.Cells[3].Value = row["credit"].ToString();
            }
            Program.db.CloseConnection();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

           //  up_selected_row_index = dgv_search_customers.SelectedRows[0].Index;
            bunifuCustomLabel7.Visible = true;
            bunifuCustomLabel8.Visible = true;
            bunifuCustomLabel9.Visible = true;
            textBox1.Visible = true;
            comboBox1.Visible = true;
            textBox3.Visible = true;
            bunifuThinButton21.Visible = true;
            textBox1.Text = dgv_search_customers.Rows[index].Cells[3].Value.ToString();
            textBox3.Text = dgv_search_customers.Rows[index].Cells[1].Value.ToString();
            comboBox1.Text = dgv_search_customers.Rows[index].Cells[2].Value.ToString();

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cust_id = dgv_search_customers.Rows[index].Cells[0].Value.ToString();
                Program.db.OpenConnection();
                string query = "Update customers Set credit='" + textBox1.Text + "', customer_name='" + textBox3.Text + "', customer_type ='" +comboBox1.SelectedItem.ToString() + "'where customer_ID ='" + Convert.ToInt32(cust_id) + "'";
                Program.db.ExecuteNonQuery(query);

                string query1 = "Update treasury Set operator_ID='" + textBox3.Text

                           + "'where operator_type ='عميل' or  operator_type ='مورد' ";
                Program.db.ExecuteNonQuery(query1);
               
                Program.db.CloseConnection();
                load_cust_info();
                bunifuCustomLabel7.Visible = false;
                bunifuCustomLabel8.Visible = false;
                bunifuCustomLabel9.Visible = false;
                comboBox1.Visible = false;
                textBox1.Visible = false;
                comboBox1.Visible = false;
                textBox3.Visible = false;
                bunifuThinButton21.Visible = false;
                MessageBox.Show("تم تعديل البيانات");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_search_customers_SelectionChanged(object sender, EventArgs e)
        {
            index = dgv_search_customers.CurrentCell.RowIndex;
        }

        private void tab_customers_Click(object sender, EventArgs e)
        {
            load_cust_info();
        }

        private void tab_customers_DoubleClick(object sender, EventArgs e)
        {
            load_cust_info();
        }
    }
}
