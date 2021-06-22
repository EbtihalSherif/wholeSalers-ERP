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

namespace wholesaler_ERP
{

    public partial class login_form : Form
    {
        DBconnect db_con = new DBconnect();

        string emp_id = "";

        public login_form()
        {
            InitializeComponent();
        }
        public static mainForm mform = new mainForm();

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        //DateTime timenow = DateTime.Now;
        //string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
        // time = DateTime.Now.ToString("h:mm:ss tt");
        //insert_date_time_login(date, time,emp_id);

        //closeCurrent();

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string login_date;
            string time;
            //     try
            //     {
            if (txtbox_userName.Text != "" && txt_password.Text != "")
            {

                Program.db.OpenConnection();
                string query = "select user_ID from users WHERE user_name ='" + txtbox_userName.Text + "' AND password ='" + txt_password.Text + "'";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        emp_id = row["user_ID"].ToString();
                        Program.user_ID = Int32.Parse(row["user_ID"].ToString());


                    }
                    //  MessageBox.Show("تم تسجيل الدخول بنجاح");
                    Program.db.CloseConnection();

                    Program.treasury_count();
                    DateTime timenow = DateTime.Now;
                    string date = DateTime.UtcNow.ToString("yyyy-MM-dd h:mm:ss tt");
                    time = DateTime.Now.ToString("h:mm:ss tt");
                    insert_date_time_login(date, time, Program.user_ID.ToString());

                    closeCurrent();

                }
                else
                {
                    MessageBox.Show("خطأ في اسم المستخدم او كلمة المرور");
                    Program.db.CloseConnection();

                }
            }
            else
            {
                MessageBox.Show("ادخل اسم المستخدم و كلمة المرور");
                Program.db.CloseConnection();
            }
            //  }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    Program.db.CloseConnection();

            //}



        }
        private void closeCurrent()
        {
            Program.OpenDetailFormOnClose = true;

            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_userName_OnValueChanged(object sender, EventArgs e)
        {



        }

        private void txtbox_userName_MouseClick(object sender, MouseEventArgs e)
        {
            txtbox_userName.Text = "";
        }

        private void bunifuMaterialTextbox2_MouseClick(object sender, MouseEventArgs e)
        {
            txt_password.Text = "";
        }
        public void insert_date_time_login(string date, string time, string empID)
        {
            try
            {

                Program.db.OpenConnection();
                string query = "Insert INTO login_records(user_ID,login_date,login_time) Values ('" + empID + "' , '" + date + "', '" + time + "'); ";


                Program.db.ExecuteNonQuery(query);
                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void txtbox_userName_MouseHover_1(object sender, EventArgs e)
        {
            txtbox_userName.Text = "";
        }

        private void txtbox_userName_Click(object sender, EventArgs e)
        {
            txtbox_userName.Text = "";
            txt_password.Text = "";
        }

        private void txtbox_userName_MouseEnter(object sender, EventArgs e)
        {
            if (txtbox_userName.Text == "اسم المستخدم")
                txtbox_userName.Text = null;
        }

        private void txtbox_userName_MouseLeave(object sender, EventArgs e)
        {
            if (txtbox_userName.Text == "")
                txtbox_userName.Text = "اسم المستخدم";
            if (txtbox_userName.Text != "")
                txtbox_userName.Text = txtbox_userName.Text;
        }

        private void txt_password_MouseEnter(object sender, EventArgs e)
        {
            if (txt_password.Text == "كلمه المرور")
                txt_password.Text = null;
        }

        private void txt_password_MouseLeave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
                txt_password.Text = "كلمه المرور";
            if (txt_password.Text != "")
                txt_password.Text = txt_password.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
