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
    public partial class add_products : UserControl
    {

        Dictionary<string, int> product_groups = new Dictionary<string, int>();

        public add_products()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            products_group newgroup = new products_group();
            newgroup.Show();
        }

        private void add_products_Load(object sender, EventArgs e)
        {

            load_products();
            load_product_groups();


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //try
            //{

            // string product_ID = dgv_productNames.CurrentRow.Cells[0].Value.ToString();
            string grp_name = cmb_category.Text;
            int category_ID = get_product_group_ID(grp_name);
            Program.db.OpenConnection();
                    string query = "Insert INTO product(product_name,product_code,purchase_price,selling_price,discounted_price,product_quantity,p_group_id,description) Values ('" + txt_name.Text + "' , '" + txt_code.Text + "', '" + txt_paying_price.Text + "', '" + txt_selling_price.Text + "', '" + txt_discounted.Text + "', '" + txt_quantity.Text + "', '" + category_ID.ToString()+ "', '" + txt_description.Text + "'); ";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    MessageBox.Show("تم تسجيل الصنف بنجاح");
                      load_products();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }


        public void load_products()
        {
            try
            {
                dgv_productNames.Rows.Clear();
                Program.db.OpenConnection();
                string query = "SELECT p.product_ID,p.product_name,p.product_code,p.purchase_price,p.selling_price,p.discounted_price,p.description,c.p_group_name FROM product p INNER JOIN product_group c ON p.p_group_id=c.p_group_ID";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    int rowId = dgv_productNames.Rows.Add();
                    DataGridViewRow roww = dgv_productNames.Rows[rowId];
                    // cmb.Items.Add(row["customer_name"].ToString());
                    roww.Cells[0].Value = row["product_ID"].ToString();
                    roww.Cells[1].Value = row["product_name"].ToString();
                    roww.Cells[2].Value = row["description"].ToString();

                    roww.Cells[3].Value = row["product_code"].ToString();
                    roww.Cells[4].Value = row["p_group_name"].ToString();

                    roww.Cells[5].Value = row["purchase_price"].ToString();
                    roww.Cells[6].Value = row["selling_price"].ToString();
                    roww.Cells[7].Value = row["discounted_price"].ToString();

                }
                Program.db.close_reader();
                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void dgv_productNames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_productNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_productNames.CurrentRow.Cells[1].Value.ToString();
            txt_description.Text = dgv_productNames.CurrentRow.Cells[2].Value.ToString();
            txt_code.Text = dgv_productNames.CurrentRow.Cells[3].Value.ToString();
            cmb_category.Text = dgv_productNames.CurrentRow.Cells[4].Value.ToString();
            txt_paying_price.Text = dgv_productNames.CurrentRow.Cells[5].Value.ToString();
            txt_selling_price.Text = dgv_productNames.CurrentRow.Cells[6].Value.ToString();
            txt_discounted.Text = dgv_productNames.CurrentRow.Cells[7].Value.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string product_ID = dgv_productNames.CurrentRow.Cells[0].Value.ToString();
                string grp_name = cmb_category.Text;
                int category_ID = get_product_group_ID(grp_name);
                Program.db.OpenConnection();
                string query = "Update product Set product_name='" + txt_name.Text
                              + "', p_group_id='" + category_ID.ToString()
                              + "', product_code ='" + txt_code.Text
                              + "', purchase_price ='" + txt_paying_price.Text
                              + "', selling_price ='" + txt_selling_price.Text
                              + "', discounted_price ='" + txt_discounted.Text
                              + "', product_quantity ='" + txt_quantity.Text
                              + "', description ='" + txt_description.Text

                              + "'where product_ID ='" + Convert.ToInt32(product_ID) + "'";
                Program.db.ExecuteNonQuery(query);
                Program.db.CloseConnection();
                load_products();
                MessageBox.Show("تم تعديل البيانات");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string product_ID = dgv_productNames.CurrentRow.Cells[0].Value.ToString();


                    Program.db.OpenConnection();
                    string query = "Delete from product where product_ID='" + product_ID + "'";
                    Program.db.ExecuteNonQuery(query);
                    Program.db.CloseConnection();
                    txt_code.Text = "";
                    txt_description.Text = "";
                    txt_discounted.Text = "";
                    txt_name.Text = "";
                    txt_paying_price.Text = "";
                    txt_quantity.Text = "";
                    txt_paying_price.Text = "";
                    cmb_category.Text = "";


                    load_products();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        public void load_product_groups()
        {



            try
            {
                product_groups.Clear();
                cmb_category.Items.Clear();
              
                Program.db.OpenConnection();
                MySqlDataReader row;
                string query = "select * from product_group ";
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    cmb_category.Items.Add(row[1].ToString());
                    

                    product_groups.Add(row[1].ToString(), Convert.ToInt32(row[0]));
                }
                Program.db.close_reader();
                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public int get_product_group_ID(string cat_name)
        {
            int cat_ID = 0;
            cat_ID = product_groups[cat_name];
            return cat_ID;
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_category_MouseClick(object sender, MouseEventArgs e)
        {
            load_product_groups();

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Excel_info ex = new Excel_info();
            ex.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            load_product_groups();
            load_products();
        }
    }

}

