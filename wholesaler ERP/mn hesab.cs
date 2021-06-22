using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wholesaler_ERP
{
    public partial class mn_hesab : Form
    {
        public mn_hesab()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_hesab_type.Text != "")
                {
                    Program.db.OpenConnection();
                    string query = "Insert INTO salary_type(Name) Values('" + txt_hesab_type.Text + "'); ";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    MessageBox.Show("تم التسجيل ");
                    load_groups();
                    txt_hesab_type.Text = "";
                }
                else
                {
                    MessageBox.Show("برجاء ادخال اسم الحساب");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            Program.db.OpenConnection();
            string query = "Update salary_type Set Name='" + txt_hesab_type.Text + "'where ID ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            Program.db.ExecuteNonQuery(query);
            Program.db.CloseConnection();
            MessageBox.Show("تم التعديل بنجاح");
            load_groups();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Program.db.OpenConnection();
                    string query = "Delete From salary_type where ID='" + id + "'";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    MessageBox.Show("تم الحذف بنجاح");
                    txt_hesab_type.Text = "";
                    load_groups();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void load_groups()
        {
            dataGridView1.Rows.Clear();
            Program.db.OpenConnection();
            string query = "select * from salary_type order by ID";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow roww = dataGridView1.Rows[rowId];
                roww.Cells[0].Value = row["ID"].ToString();
                roww.Cells[1].Value = row["Name"].ToString();
            }
            Program.db.CloseConnection();
        }

        private void mn_hesab_Load(object sender, EventArgs e)
        {
            load_groups();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_hesab_type.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
