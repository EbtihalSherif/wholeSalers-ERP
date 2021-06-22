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
    public partial class add_job : Form
    {
        DBconnect db = new DBconnect();
        static int index;
        public add_job()
        {
            InitializeComponent();
        }
        public void load_jobs()
        {
           dataGridView1.Rows.Clear();
            db.OpenConnection();
            string query = "select * from job_titles";
            MySqlDataReader row;
            row = db.ExecuteReader(query);
            while (row.Read())
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow roww = dataGridView1.Rows[rowId];
                roww.Cells[0].Value = row["job_ID"].ToString();
                roww.Cells[1].Value = row["job_name"].ToString();
             
            }
            db.CloseConnection();
        }

        private void add_job_Load(object sender, EventArgs e)
        {
            load_jobs();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMetroTextbox1.Text != "")
                {
                    db.OpenConnection();
                    string query = "Insert INTO job_titles(job_name) Values('" + bunifuMetroTextbox1.Text + "'); ";
                    db.ExecuteNonQuery(query);
                    db.CloseConnection();
                    MessageBox.Show("تم تسجيل الوظيفة");
                    load_jobs();
                    bunifuMetroTextbox1.Text = "";
                }
                else
                {
                    MessageBox.Show("برجاء ادخال الوظيفة");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Visible = true;
            bunifuMetroTextbox2.Visible = true;
            bunifuThinButton23.Visible = true;
            bunifuThinButton21.Visible = false;
            bunifuThinButton22.Visible = false;
            bunifuMetroTextbox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string job_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    db.OpenConnection();
                    string query = "Delete From job_titles where job_ID='" + job_id + "'";
                    db.ExecuteNonQuery(query);
                    db.CloseConnection();
                    MessageBox.Show("تم الحذف بنجاح");
                    load_jobs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                bunifuCustomLabel1.Visible = false;
                bunifuMetroTextbox2.Visible = false;
                bunifuThinButton23.Visible = false;
                bunifuThinButton21.Visible = true;
                bunifuThinButton22.Visible = true;
                string job_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                db.OpenConnection();
                string query = "Update job_titles Set job_name='" + bunifuMetroTextbox2.Text + "'where job_ID ='" + Convert.ToInt32(job_id) + "'";
                db.ExecuteNonQuery(query);
                db.CloseConnection();
                MessageBox.Show("تم التعديل بنجاح");
                load_jobs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
