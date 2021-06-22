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
    public partial class products_group : Form
    {
        static int index;
        public products_group()
        {
            InitializeComponent();
        }
        public void load_groups()
        {
            dataGridView1.Rows.Clear();
            Program.db.OpenConnection();
            string query = "select * from product_group";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow roww = dataGridView1.Rows[rowId];
                roww.Cells[0].Value = row["p_group_ID"].ToString();
                roww.Cells[1].Value = row["p_group_name"].ToString();
            }
            Program.db.CloseConnection();
        }

        private void products_group_Load(object sender, EventArgs e)
        {
            load_groups();

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMetroTextbox1.Text != "")
                {
                    Program.db.OpenConnection();
                    string query = "Insert INTO product_group(p_group_name) Values('" + bunifuMetroTextbox1.Text  + "'); ";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    MessageBox.Show("تم التسجيل ");
                    load_groups();
                    bunifuMetroTextbox1.Text = "";
                }
                else
                {
                    MessageBox.Show("برجاء ادخال المجموعة");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
            string query = "Update product_group Set p_group_name='" + bunifuMetroTextbox1.Text + "'where p_group_ID ='" + dataGridView1.SelectedRows[index].Cells[0].Value.ToString() + "'";
            Program.db.ExecuteNonQuery(query);
            Program.db.CloseConnection();
            MessageBox.Show("تم التعديل بنجاح");
            load_groups();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuMetroTextbox1.Text = dataGridView1.SelectedRows[index].Cells[1].Value.ToString();
           // bunifuMetroTextbox2.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();

        }

        private void delete_Click(object sender, EventArgs e)
        {

            try
            {

                string group_id = dataGridView1.SelectedRows[index].Cells[0].Value.ToString();
                Program.db.OpenConnection();
                string query = "Delete From product_group where p_group_ID='" + group_id + "'";
                Program.db.ExecuteNonQuery(query);
                Program.db.CloseConnection();
                MessageBox.Show("تم الحذف بنجاح");
                bunifuMetroTextbox1.Text = "";
                load_groups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            bunifuMetroTextbox1.Text = dataGridView1.SelectedRows[index].Cells[1].Value.ToString();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
