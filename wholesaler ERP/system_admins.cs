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
    public partial class system_admins : UserControl
    {
        
        static int index,dgv_emp_names_index;
        static string selected_name = "";
        static int userr_id;
        public system_admins()
        {
            InitializeComponent();
        }
        public void Load_infoo()
        {
            dataGridView1.Rows.Clear();
            Program.db.OpenConnection();
            string query = "select employees.emp_name,users.user_name,users.password,job_titles.job_name from users INNER JOIN employees ON users.emp_id=employees.emp_ID INNER JOIN job_titles ON employees.job_title_id=job_titles.job_ID ";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);

            while (row.Read())
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow roww = dataGridView1.Rows[rowId];

                roww.Cells[0].Value = row["emp_name"].ToString();
                roww.Cells[1].Value = row["user_name"].ToString();
                roww.Cells[2].Value = row["password"].ToString();
                roww.Cells[3].Value = row["job_name"].ToString();
            }
            Program.db.CloseConnection();
            row.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            this.Hide();
            
        }

        private void system_admins_Load(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
            string query = "select emp_name FROM employees";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while(row.Read())
            {
                int rowId = dgv_emp_names.Rows.Add();
                DataGridViewRow roww = dgv_emp_names.Rows[rowId];
                roww.Cells[0].Value = row["emp_name"].ToString();
             
            }
            Program.db.CloseConnection();
            row.Close();

            Load_infoo();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
          

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.db.OpenConnection();
            //selected_name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string querry = "Select * from users where user_name ='" + selected_name + "'";
            MySqlDataReader valuee;
            valuee = Program.db.ExecuteReader(querry);
            if (valuee.Read())
            {
                userr_id = valuee.GetInt32(0);
                MessageBox.Show(userr_id.ToString());

            }
            valuee.Close();
            txt_user_name.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txt_pass.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string query = "select employees.emp_name,users.IS_admin From users INNER JOIN employees ON employees.emp_ID = users.emp_id AND users.user_ID='"+userr_id+"' ";
            MySqlDataReader dr;
           dr= Program.db.ExecuteReader(query);
            while(dr.Read())
            {
                //comboBox1.Text = dr["emp_name"].ToString();
                string isadmin = dr["IS_admin"].ToString();
                if(isadmin=="1")
                {
                    radioButton1.Checked = true;
                }
                else if(isadmin=="0")
                {
                    radioButton2.Checked = true;
                }
            }
            dr.Close();
            Program.db.CloseConnection();

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
               
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {


        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (txt_user_name.Text != "" && txt_pass.Text != "")
                {
                    Program.db.OpenConnection();
                    string checkedd = "";
                    string emp_id = "";
                    if (radioButton1.Checked == true && radioButton2.Checked == false)
                    {
                        checkedd = "1";
                    }
                    else if (radioButton2.Checked == true && radioButton1.Checked == false)
                    {
                        checkedd = "0";
                    }
                    string get_emp_id = "select * FROM employees where emp_name='" + dgv_emp_names.Rows[dgv_emp_names_index].Cells[0].Value.ToString() + "'";
                    MySqlDataReader value;
                    value = Program.db.ExecuteReader(get_emp_id);
                    if (value.Read())
                    {
                        emp_id = value.GetString(0);

                    }
                    value.Close();

                    string query = "Insert INTO users(user_name,password,emp_id,IS_admin) Values ('" + txt_user_name.Text + "' , '" + txt_pass.Text + "' , '" + emp_id + "','" + checkedd + "'); ";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    Load_infoo();
                    txt_user_name.Text = "";
                    txt_pass.Text = "";
                    txt_emp_name.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    MessageBox.Show("تم تسجيل المستخدم بنجاح");
                    //comboBox1.Text = "";

                }

            }

            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());


            }
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
           
            string querry = "Select * from users where user_name ='" + selected_name + "'";
            MySqlDataReader valuee;
            valuee = Program.db.ExecuteReader(querry);
            if (valuee.Read())
            {
                userr_id = valuee.GetInt32(0);
                MessageBox.Show(userr_id.ToString());

            }
            valuee.Close();
            Program.db.CloseConnection();
            if (txt_user_name.Text != "" && txt_pass.Text != "")
            {
                Program.db.OpenConnection();
                string query = "Update users Set user_name ='" + txt_user_name.Text + "', password ='" + txt_pass.Text + "'where user_ID ='" + userr_id + "'";
                Program.db.ExecuteNonQuery(query);
                Program.db.CloseConnection();
                Load_infoo();
                MessageBox.Show("تم التعديل بنجاح");
                txt_user_name.Text = "";
                txt_pass.Text = "";
               // comboBox1.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else
            {
                MessageBox.Show("برجاء ادخال اسم المستخدم وكلمة المرور بشكل صحيح");
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Program.db.OpenConnection();

                string querry = "Select * from users where user_name ='" + selected_name + "'";
                MySqlDataReader valuee;
                valuee = Program.db.ExecuteReader(querry);
                if (valuee.Read())
                {
                    userr_id = Convert.ToInt32(valuee[0].ToString());
                }
                valuee.Close();
                Program.db.CloseConnection();
                if (txt_user_name.Text != "" && txt_pass.Text != "")
                {
                    Program.db.OpenConnection();
                    string query = "Delete From users where user_ID ='" + userr_id + "'";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    Load_infoo();
                    MessageBox.Show("تم الحذف بنجاح");
                    txt_user_name.Text = "";
                    txt_pass.Text = "";
                }
                else
                {
                    MessageBox.Show("برجاء اختيار اسم المستخدم وكلمة المرور ");
                }
            }
            else
            {

            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selected_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_user_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_pass.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_emp_names_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           dgv_emp_names_index = dgv_emp_names.CurrentCell.RowIndex;
            txt_emp_name.Text = dgv_emp_names.CurrentRow.Cells[0].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
