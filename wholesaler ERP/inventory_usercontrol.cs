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
    public partial class inventory_usercontrol : UserControl
    {
        static int index;
        public inventory_usercontrol()
        {
            InitializeComponent();

        }
        public void load_inv()
        {
            Program.db.OpenConnection();
            dataGridView1.Rows.Clear();
            string query = "select product.product_code,product.product_ID,product.product_name,product.purchase_price,inventory.quantity," +
                "product.selling_price,product.discounted_price" +
                " from inventory INNER JOIN product ON product.product_ID=inventory.product_ID";
            string query2 = "select p_group_name From product_group INNER JOIN product ON" +
                " product_group.p_group_ID=product.p_group_id order by product.product_code ASC";
            MySqlDataReader row1;
            row1 = Program.db.ExecuteReader(query);
            while (row1.Read())
            {

                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow roww = dataGridView1.Rows[rowId];
                roww.Cells[0].Value = row1["product_code"].ToString();
                roww.Cells[1].Value = row1["product_name"].ToString();
                roww.Cells[2].Value = row1["purchase_price"].ToString();
                roww.Cells[3].Value = row1["quantity"].ToString();
                roww.Cells[4].Value = (Convert.ToDouble(row1["quantity"].ToString()) * Convert.ToDouble(row1["purchase_price"].ToString())).ToString();

                roww.Cells[5].Value = row1["selling_price"].ToString();
                roww.Cells[6].Value = row1["discounted_price"].ToString();
                cmb_product.Items.Add(row1["product_name"].ToString());


            }
            row1.Close();
            string query3 = "select * from product_group";
            MySqlDataReader dr = Program.db.ExecuteReader(query3);
            while (dr.Read())
            {
                cmb_product_grp.Items.Add(dr["p_group_name"].ToString());
            }
            dr.Close();
            Program.db.CloseConnection();

        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void inventory_usercontrol_Load(object sender, EventArgs e)
        {
            load_inv();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            //MessageBox.Show(index.ToString());
            //Program.db.OpenConnection();
            //string query3 = "select p_group_name From product_group INNER JOIN products ON product_group.p_group_ID=products.p_group_id AND products.product_code='" + dataGridView1.Rows[index].Cells[0].Value.ToString() + "'";
            //MySqlDataReader row3;
            //row3 = Program.db.ExecuteReader(query3);
            //if (row3.Read())
            //{
            //    cmb_product_grp.Text = row3["p_group_name"].ToString();

            //}
            //row3.Close();
            //Program.db.CloseConnection();
            //txt_product_ID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //cmb_product.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();

        }

        private void cmb_product_grp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_product_grp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Program.db.OpenConnection() == true)
            {
                Program.db.CloseConnection();
            }

            string prod_gr_id = "";
            dataGridView1.Rows.Clear();
            Program.db.OpenConnection();
            string temp_query = "select p_group_ID From product_group where p_group_name='" + cmb_product_grp.SelectedItem.ToString() + "'";
            MySqlDataReader p_ID;
            p_ID = Program.db.ExecuteReader(temp_query);
            while (p_ID.Read())
            {
                prod_gr_id = p_ID["p_group_ID"].ToString();
                MessageBox.Show(prod_gr_id);
            }
            p_ID.Close();


            string query4 = "select product.product_code,product.product_ID,product.product_name,product.purchase_price,inventory.quantity,product.selling_price,product.discounted_price" +
                " from inventory INNER JOIN product ON product.product_ID=inventory.product_ID where product.p_group_id='" + prod_gr_id + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query4);
            while (row.Read())
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow roww = dataGridView1.Rows[rowId];
                roww.Cells[0].Value = row["product_code"].ToString();
                roww.Cells[1].Value = row["product_name"].ToString();
                roww.Cells[2].Value = row["purchase_price"].ToString();
                roww.Cells[3].Value = row["quantity"].ToString();
                roww.Cells[4].Value = (Convert.ToDouble(row["quantity"].ToString()) * Convert.ToDouble(row["purchase_price"].ToString())).ToString();
                roww.Cells[5].Value = row["selling_price"].ToString();
                roww.Cells[6].Value = row["discounted_price"].ToString();
            }
            row.Close();
            Program.db.CloseConnection();
        }


        private void cmb_product_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.db.OpenConnection() == true)
            {
                Program.db.CloseConnection();
            }

            dataGridView1.Rows.Clear();
            Program.db.OpenConnection();
            string query4 = "select product.product_code,product.product_ID,product.product_name,product.purchase_price,inventory.quantity,product.selling_price,product.discounted_price" +
            " from inventory INNER JOIN product ON product.product_ID=inventory.product_ID where product_name='" + cmb_product.SelectedItem.ToString() + "'";
            MySqlDataReader row4;
            row4 = Program.db.ExecuteReader(query4);

            while (row4.Read())
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow roww = dataGridView1.Rows[rowId];
                roww.Cells[0].Value = row4["product_code"].ToString();
                roww.Cells[1].Value = row4["product_name"].ToString();
                roww.Cells[2].Value = row4["purchase_price"].ToString();
                roww.Cells[3].Value = row4["quantity"].ToString();
                roww.Cells[4].Value = (Convert.ToDouble(row4["quantity"].ToString()) * Convert.ToDouble(row4["purchase_price"].ToString())).ToString();

                roww.Cells[5].Value = row4["selling_price"].ToString();
                roww.Cells[6].Value = row4["discounted_price"].ToString();


            }
            row4.Close();
            Program.db.CloseConnection();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == " مجموعه الصنف")
            {
                bunifuCustomLabel10.Enabled = true;
                cmb_product_grp.Enabled = true;
                bunifuCustomLabel8.Enabled = false;
                cmb_product.Enabled = false;
            }
            else
            {
                bunifuCustomLabel8.Enabled = true;
                cmb_product.Enabled = true;
                bunifuCustomLabel10.Enabled = false;
                cmb_product_grp.Enabled = false;
            }
        }
    }
}
