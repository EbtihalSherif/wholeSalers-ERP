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
       DBconnect db_con =new DBconnect();

        public login_form()
        {
            InitializeComponent();
        }
        public static mainForm mform = new mainForm();

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            string emp_id="";
            try
            {
                if (txtbox_userName.Text != "" && bunifuMaterialTextbox2.Text != "")
                {

                    db_con.OpenConnection();
                    string query = "select user_ID from users WHERE user_name ='" + txtbox_userName.Text + "' AND password ='" + bunifuMaterialTextbox2.Text + "'";
                    MySqlDataReader row;
                    row = db_con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                           emp_id = row["user_ID"].ToString();


                        }
                        MessageBox.Show("تم تسجيل الدخول بنجاح");
                        mainForm mf = new mainForm();
                        mf.Show();
                    }
                    else
                    {
                        MessageBox.Show("خطأ في اسم المستخدم او كلمة المرور");
                    }
                }
                else
                {
                    MessageBox.Show("ادخل اسم المستخدم و كلمة المرور");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void txtbox_userName_OnValueChanged(object sender, EventArgs e)
        {
           


        }

        private void txtbox_userName_MouseHover(object sender, EventArgs e)
        {
      
        }

        private void bunifuMaterialTextbox2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void txtbox_userName_MouseClick(object sender, MouseEventArgs e)
        {
            txtbox_userName.Text = "";
        }

        private void bunifuMaterialTextbox2_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
        }
    }
}
