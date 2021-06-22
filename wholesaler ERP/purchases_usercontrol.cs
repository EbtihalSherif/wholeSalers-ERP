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
    public struct Product_det
    {
        public string product_ID, product_name, product_grp, product_code,
              product_selling_price, product_discounted_price, product_desc;
        public int avaliable_qty, current_quantity, alert_quantity;

    };
    public partial class purchases_usercontrol : UserControl
    {

        public static Dictionary<string, Product_det> products= new Dictionary<string, Product_det>();

        Dictionary<string, int> product_groups = new Dictionary<string, int>();
        public static Dictionary<string, string> productsIN_inventory = new Dictionary<string, string>();
        public static Dictionary<string, int> customers = new Dictionary<string, int>();

        List<int> quantities = new List<int>();

        bool new_customer = false;
        string product_ID, product_name, product_grp, product_code, product_selling_price, product_discounted_price, product_desc;
        int avaliable_qty, current_qty;
        int new_quantity, previous_quantity, returned_qty;
        int new_bill_ID, old_bill_ID;
        double customer_credit = 0;
        double total_sales_price, final_price, paid_amount, rest_amount;
        public purchases_usercontrol()
        {
            InitializeComponent();

            Program.treasury_count();
            txt_treasur.Text = Program.treasury_amount.ToString();

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }
        public void get_customer_credit(int customer_ID)
        {
            //               Program.db.OpenConnection();
            string query = "SELECT credit FROM customers where customer_type= 'مورد' and customer_ID='" + customer_ID + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                string cred = row[0].ToString();
                if (cred == "")
                    cred = "0";
                customer_credit = Convert.ToDouble(cred);
                txt_credit.Text = row[0].ToString();
            }
            row.Close();
            //  Program.db.CloseConnection();
        }
        public int get_product_group_ID(string category_name)
        {
            int cat_ID = 0;
            cat_ID = product_groups[category_name];
            return cat_ID;
        }
        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel20_Click(object sender, EventArgs e)
        {

        }
        public static void load_products_inventory()
        {

            products.Clear();
            Program.db.OpenConnection();
            MySqlDataReader row;
            string query = "select product.description,product.product_quantity, " +
                "product.product_name,product.product_ID,product.selling_price,product.discounted_price" +
                ",product.product_code,product.p_group_id" +
                    "from product";
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                
                Product_det prod = new Product_det();
                prod.product_ID = row["product_ID"].ToString();
                prod.product_name = row["product_name"].ToString();
                prod.product_selling_price = row["selling_price"].ToString();
                prod.product_code = row["product_code"].ToString();
                prod.product_discounted_price = row["discounted_price"].ToString();
                prod.product_grp = row["p_group_id"].ToString();
                prod.product_desc = row["description"].ToString();
         //      prod.avaliable_qty = Convert.ToInt32(row["quantity"].ToString());
          //     prod.alert_quantity = Convert.ToInt32(row["product_quantity"].ToString());
           //    prod.current_quantity = prod.avaliable_qty;

                products.Add(prod.product_name, prod);
               
            }
            row.Close();
            Program.db.CloseConnection();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox8_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            add_Customer cust = new add_Customer();
            cust.Show();


        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_product.Text = "";
            cmb_product.Items.Clear();
            Program.db.OpenConnection();
            int group_ID = 0;
            string p_id = "";
            string p_id_query = "select p_group_ID  FROM product_group where p_group_name ='" + cmb_prod_group.Text + "'";
            MySqlDataReader pr_id = Program.db.ExecuteReader(p_id_query);
            if (pr_id.Read())
            {
                p_id = pr_id["p_group_ID"].ToString();
            }

            pr_id.Close();
            string query = "SELECT product_name ,product.product_ID from product where product.p_group_id= '" + p_id + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {

                cmb_product.Items.Add(row["product_name"].ToString());


            }
            row.Close();
            Program.db.CloseConnection();
        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }
        //public void load_bill()
        //{
        //    //   try
        //    // {

        //    dgv_search.Rows.Clear();
        //    int customer_ID = get_customer_ID(cust_name.Text);

        //    Program.db.OpenConnection();
        //    MySqlDataReader row;
        //    string query = " select * from sales_bill " +
        //        "where bill_ID = '" + cmb_bill_num.Text + "'" +
        //        " AND bill_type = '" + bill_type.Text + "' " +
        //        // "AND bill_date = '" + Convert.ToDateTime(dtp_search.Value).ToString("yyyy-MM-dd ") + "' " +
        //        "AND customer_id = '" + customer_ID + "'";
        //    row = Program.db.ExecuteReader(query);
        //    while (row.Read())
        //    {
        //        bunifuMetroTextbox19.Text = row["total_price"].ToString();
        //        left.Text = row["left_money"].ToString();
        //        payed.Text = row["paid_money"].ToString();
        //        bunifuMetroTextbox20.Text = row["final_price"].ToString();
        //        discount.Text = row["discount_amount"].ToString();
        //        double disc_value = Convert.ToDouble(discount.Text);
        //        double disc_percent = (disc_value / Convert.ToDouble(bunifuMetroTextbox19.Text)) * 100.0;
        //        disc.Text = disc_percent.ToString();

        //        total_sales_price = Convert.ToDouble(bunifuMetroTextbox19.Text);
        //        final_price = Convert.ToDouble(bunifuMetroTextbox20.Text);
        //        paid_amount = Convert.ToDouble(payed.Text);
        //        rest_amount = Convert.ToDouble(left.Text);


        //    }
        //    row.Close();

        //    quantities.Clear();
        //    MySqlDataReader reader;
        //    string query1 = " select product.product_name, customers.customer_name, sales_bill_product.bill_id,sales_bill_product.product_id,sales_bill_product.product_quantity,sales_bill_product.product_price from sales_bill inner JOIN sales_bill_product on sales_bill.bill_ID=sales_bill_product.bill_id " +
        //        "inner join customers on customers.customer_ID=sales_bill.customer_id  INNER join product on sales_bill_product.product_id = product.product_ID  " +
        //        "where sales_bill.bill_ID = '" + cmb_bill_num.Text + "'" +
        //        " AND sales_bill.bill_type = '" + bill_type.Text + "' " +

        //        "AND sales_bill.customer_id = '" + customer_ID + "'";
        //    reader = Program.db.ExecuteReader(query1);
        //    while (reader.Read())
        //    {

        //        int rowId = dgv_search.Rows.Add();
        //        DataGridViewRow roww = dgv_search.Rows[rowId];
        //        // cmb.Items.Add(row["customer_name"].ToString());
        //        roww.Cells[0].Value = reader["bill_id"].ToString();
        //        roww.Cells[1].Value = reader["customer_name"].ToString();
        //        roww.Cells[2].Value = reader["product_name"].ToString();
        //        roww.Cells[3].Value = reader["product_quantity"].ToString();
        //        quantities.Add(Convert.ToInt32(reader["product_quantity"].ToString()));
        //        roww.Cells[4].Value = reader["product_price"].ToString();
        //        double total_price = Convert.ToDouble(roww.Cells[3].Value) * Convert.ToDouble(roww.Cells[4].Value);
        //        roww.Cells[5].Value = total_price.ToString();

        //    }
        //    reader.Close();



        //    Program.db.CloseConnection();
        //    //}
        //    //  catch (Exception ex)
        //    // {
        //    //     MessageBox.Show(ex.ToString());
        //    // }

        //}

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];
            row.Cells[0].Value = Convert.ToDateTime(dtp_1.Value).ToString("yyyy-MM-dd ");
            row.Cells[1].Value = customer_name.SelectedItem.ToString();
            row.Cells[2].Value = cmb_product.SelectedItem.ToString();
            row.Cells[3].Value = txt_qty.Text;
            row.Cells[4].Value = txt_purch_price.Text;
            row.Cells[5].Value =Convert.ToDouble( txt_purch_price.Text)  * Int32.Parse(txt_qty.Text);
            update_total_price(dataGridView1);
            total_purchase.Text = total_sales_price.ToString();
            final_total.Text = final_price.ToString();
            txt_paid.Text = final_price.ToString();
            cmb_product.Text = "";
            txt_left.Text = "";
            cmb_prod_group.Text = "";
            txt_qty.Text = "";
            txt_purch_price.Text = "";
            if(cmb_bill_type.SelectedItem=="نقدى")
            {
                txt_paid.Text= total_sales_price.ToString();
                txt_left.Text = "0";
                txt_left.Enabled = false;
                txt_paid.Enabled = false;
            }
            

        }

        public void update_total_price(DataGridView sales)
        {

            total_sales_price = final_price = 0;
            for (int i = 0; i < sales.Rows.Count; i++)
            {
                total_sales_price += Convert.ToInt32(sales.Rows[i].Cells[5].Value);

            }
            //    total_sales_price += new_amount;
            final_price = total_sales_price;

        }
        public void get_product_details(string product_name)
        {

            MySqlDataReader row;
            string query = "select product.description,product.product_quantity, product.product_name,product.product_ID,product.selling_price,product.discounted_price,inventory.quantity,product.product_code,product.p_group_id" +
                " from product INNER join inventory on product.product_ID=inventory.product_ID where product_name = '" + product_name + "'";
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                product_ID = row["product_ID"].ToString();
                product_name = row["product_name"].ToString();
                product_selling_price = row["selling_price"].ToString();
                product_code = row["product_code"].ToString();
                product_discounted_price = row["discounted_price"].ToString();
                product_grp = row["p_group_id"].ToString();
                product_desc = row["description"].ToString();
                avaliable_qty = Convert.ToInt32(row["quantity"].ToString());

                if (Convert.ToInt32(avaliable_qty) <= Convert.ToInt32(row["product_quantity"].ToString()))
                {
                    MessageBox.Show(product_name + " : لقد وصلت للحد الادني من الكميه للصنف ", "تنبيه",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            row.Close();
        }
       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7 && e.RowIndex >= 0)
                {

                    total_sales_price = total_sales_price - Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    final_price = total_sales_price;
                    total_purchase.Text = total_sales_price.ToString();
                    final_total.Text = final_price.ToString();
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                }

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 6 && e.RowIndex >= 0)
                {

                    string quantity = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string productName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //    get_product_details(productName);
                //    avaliable_qty += Convert.ToInt32(quantity);

                    double edited_final_price = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value) * Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = edited_final_price.ToString();
                    update_total_price(dataGridView1);
                    final_price = total_sales_price;
                    total_purchase.Text = total_sales_price.ToString();
                    final_total.Text = final_price.ToString();
                    if((string)cmb_bill_type.SelectedItem=="نقدى")
                    {
                        txt_paid.Text = total_purchase.Text;
                        txt_paid.Enabled = false;
                        txt_left.Text = "0";
                        txt_left.Enabled = false;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

            Program.treasury_count();
            txt_treasury.Text = Program.treasury_amount.ToString();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();


        }
        public void load_customers()
        {


            try
            {
                customers.Clear();
               cust_name.Items.Clear();
               customer_name.Items.Clear();
                Program.db.OpenConnection();
                string query = "SELECT customer_name ,customer_ID FROM customers where customer_type= 'مورد'";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {

                    customer_name.Items.Add(row["customer_name"].ToString());
                   // cust_name.Items.Add(row["customer_name"].ToString());

                    customers.Add(row["customer_name"].ToString(), Convert.ToInt32(row["customer_ID"]));
                }
                Program.db.close_reader();
                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public string get_bill_ID(int customer_ID)
        {

            string bill_ID = "";
            string query = "SELECT max(bill_ID)FROM purchase_bill where customer_id= '" + customer_ID + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {

                bill_ID = row[0].ToString();

            }
            row.Close();

            return bill_ID;
        }
        public Double get_cust_credit(string customer_id)
        {
            string query = "select credit from customers where customer_ID='"+customer_id+"'";
            MySqlDataReader dr = Program.db.ExecuteReader(query);
           double credit = 0;
            if(dr.Read())
            {
                string s = dr["credit"].ToString();
                if(s=="")
                {
                    credit = 0;
                }
                else
                credit = Convert.ToDouble(dr["credit"].ToString());
            }
            dr.Close();
            return credit;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //////////purchase bill////////////////////////////////////////

            Program.db.OpenConnection();
            string customer_id = "";
            string cust_id_query = "select customer_ID FROM customers where customer_name='" + customer_name.SelectedItem.ToString() + "'";
            MySqlDataReader cust_id = Program.db.ExecuteReader(cust_id_query);
            if (cust_id.Read())
            {
                customer_id = cust_id["customer_ID"].ToString();
            }

            cust_id.Close();
            string insert_query = "Insert INTO purchase_bill( bill_type, bill_date, customer_id, total_price,payed_money,left_money,discount_amount,final_price) " +
                "Values( '" + cmb_bill_type.SelectedItem+ "', '" + Convert.ToDateTime(dtp_1.Value).ToString("yyyy-MM-dd ") + "', '" + customer_id + "', '" + total_purchase.Text + "', '"+txt_paid.Text+ "','" + txt_left.Text + "','" + txt_discount.Text + "','" + final_total.Text + "')";
            Program.db.ExecuteNonQuery(insert_query);
            string bill_ID = get_bill_ID(int.Parse(customer_id));

            Program.db.CloseConnection();

            ///////////////////purchased product bill/////////////////


            MessageBox.Show(dataGridView1.Rows.Count.ToString());
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Program.db.OpenConnection();
                string p_id = "";
                string p_id_query = "select product_ID FROM product where product_name='" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'";
                MySqlDataReader pr_id = Program.db.ExecuteReader(p_id_query);
                if (pr_id.Read())
                {
                    p_id = pr_id["product_ID"].ToString();
                }
                pr_id.Close();
                MessageBox.Show("!!!!!!!!!!!");
                Program.db.CloseConnection();
                Program.db.OpenConnection();
                string insert_query2 = "Insert INTO purchased_bill_product(bill_ID, product_ID,product_quantity, product_price,product_total_price) Values('" + bill_ID + "', '" + p_id + "',  '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "', '" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "')";
                Program.db.ExecuteNonQuery(insert_query2);
                Program.db.CloseConnection();

            }

           
        

            //////////////////////Inventory/////////////////////////
            Program.db.OpenConnection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string prod_id = "";
                string query = "select product_ID from product where product_name='" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'";
                MySqlDataReader reader = Program.db.ExecuteReader(query);
                if (reader.Read())
                {
                    prod_id = reader.GetString(0);

                }
                reader.Close();
                bool keyExists = productsIN_inventory.ContainsKey(prod_id);
                if (keyExists)
                {
                   
                    int old_qty=0;
                    string qty_query = "select quantity from inventory where product_ID='" + prod_id + "'";
                    MySqlDataReader drr = Program.db.ExecuteReader(qty_query);
                    if(drr.Read())
                    {
                        old_qty =Int32.Parse( drr["quantity"].ToString());
                    }
                    drr.Close();
                    int total_qty = old_qty + Int32.Parse( dataGridView1.Rows[i].Cells[3].Value.ToString());
                    string query1 = "UPDATE inventory Set quantity='" + total_qty.ToString()
                          + "'where product_ID ='" + prod_id + "'";
                    Program.db.ExecuteNonQuery(query1); 

                }
                else
                {
                    string quantity = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    MessageBox.Show(quantity);

                    string query2 = "INSERT INTO inventory (product_ID,quantity) Values('" + prod_id + "', '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "')";
                     Program.db.ExecuteNonQuery(query2);
                   
                   
                }


                double income_money = 0.0;

                if (cmb_bill_type.Text == "اجل")
                {


                    income_money += Convert.ToDouble(txt_paid.Text);
                    Double total_credit = get_cust_credit(customer_id) + Convert.ToDouble(txt_left.Text);
                    string query5 = "Update customers Set credit='" + total_credit+"'where customer_ID ='" + customer_id.ToString() + "'";
                    Program.db.ExecuteNonQuery(query5);
                }

                else
                {

                    income_money += Convert.ToDouble(final_total.Text);

                }



                string query6 = "Insert INTO treasury(date,operation_type,money_amount,money_for,notes,operator_ID,operator_type,bill_id ) " +
                  "Values ('" + Convert.ToDateTime(dtp_1.Value).ToString("yyyy-MM-dd") + "' , '" + "صرف خارجي" + "', '" + income_money + "', '" +
                  "فاتوره مشتريات" + "', '" + " " + "', '" + customer_name.Text + "', '" + "مورد" + "', '" + bill_ID + "'); ";

                Program.db.ExecuteNonQuery(query6);


                Program.db.CloseConnection();
                dataGridView1.Rows.Clear();
                MessageBox.Show("done");
                cmb_bill_type.Text = "";
                customer_name.Text = "";
                txt_credit.Text = "";
                cmb_product.Text = "";
                cmb_prod_group.Text = "";
                txt_qty.Text = "";
                txt_purch_price.Text = "";
                final_total.Text = "";
                txt_discount.Text = "";
                txt_left.Text = "0";
                txt_paid.Text = "";
                txt_disc_percent.Text = "";
                total_purchase.Text = "";
                Program.treasury_count();
                txt_treasur.Text = Program.treasury_amount.ToString();

            }
        }
       
        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox11_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox12_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox13_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox10_OnValueChanged(object sender, EventArgs e)
        {

        }
        public static int  get_customer_ID(string customer_name)
        {
            int cust_iD = 0;
            cust_iD = customers[customer_name];
            return cust_iD;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox14_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox22_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel32_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel33_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel34_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel36_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox15_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox16_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox17_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox18_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel27_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox19_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel28_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox20_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void rd_search_bydate_CheckedChanged(object sender, EventArgs e)
        {
            lbl_from_time.Enabled = true;
            lbl_to_time.Enabled = true;
            dtp1.Enabled = true;
            dtp2.Enabled = true;
            lbl_cust_name.Enabled = false;
            cust_name.Enabled = false;
            lbl_bill_type.Enabled = false;
            bill_type.Enabled =false;
        }

        private void rd_search_bucustomer_CheckedChanged(object sender, EventArgs e)
        {
            lbl_cust_name.Enabled = true;
            cust_name.Enabled = true;
            lbl_from_time.Enabled = false;
            lbl_to_time.Enabled = false;
            dtp1.Enabled = false;
            dtp2.Enabled = false;
            lbl_bill_type.Enabled = false;
            bill_type.Enabled = false;
        }

        private void rd_search_bytype_CheckedChanged(object sender, EventArgs e)
        {
            lbl_bill_type.Enabled = true;
            bill_type.Enabled = true;
            lbl_cust_name.Enabled = false;
            cust_name.Enabled = false;
            lbl_from_time.Enabled = false;
            lbl_to_time.Enabled = false;
            dtp1.Enabled = false;
            dtp2.Enabled = false;
        }

        private void rd_billState_CheckedChanged(object sender, EventArgs e)
        {
            cmb_bill_state.Enabled = true;
            lbl_bill_state.Enabled = true;
            lbl_bill_type.Enabled = false;
            bill_type.Enabled = false;
            lbl_cust_name.Enabled = false;
            cust_name.Enabled = false;
            lbl_from_time.Enabled = false;
            lbl_to_time.Enabled = false;
            dtp1.Enabled = false;
            dtp2.Enabled = false;
        }

        private void bunifuCustomLabel29_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox11_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bunifuMetroTextbox11_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try { 
            double pre = 0;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_disc_percent.Text != "")
                {
                    double disc_percent = Convert.ToDouble(txt_disc_percent.Text);
                    double disc_value = total_sales_price * (disc_percent / 100.0);
                    txt_discount.Text = disc_value.ToString();
                    if (txt_paid.Text == final_price.ToString())
                    {

                        final_price = total_sales_price - disc_value;
                        final_total.Text = final_price.ToString();
                        txt_paid.Text = final_price.ToString();

                    }
                    else
                    {
                        final_price = total_sales_price - disc_value;
                        final_total.Text = final_price.ToString();
                        txt_left.Text = (final_price - Convert.ToDouble(txt_paid.Text)).ToString();

                    }
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void dgv_purch_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            var senderGrid = (DataGridView)sender;

            //  int previous_quantity=Convert.ToInt32( dgv_sales_search.Rows[e.RowIndex].Cells[3].Value.ToString());

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 5 && e.RowIndex >= 0)
            {

                int bill_id = Convert.ToInt32(dgv_purch_search.Rows[e.RowIndex].Cells[0].Value.ToString());
                string bill_cust_name = dgv_purch_search.Rows[e.RowIndex].Cells[1].Value.ToString();
                string bill_type = dgv_purch_search.Rows[e.RowIndex].Cells[2].Value.ToString();
                purchase_bill_details newone = new purchase_bill_details(bill_id, bill_cust_name, bill_type);

                newone.Show();

            }


        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Program.db.CloseConnection();
            }
}

        private void tabControl1_Click(object sender, EventArgs e)
        {
          txt_treasur.Text= Program.treasury_amount.ToString();
          txt_treasury.Text = Program.treasury_amount.ToString();
        }
        
        private void txt_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (txt_paid.Text != "")
                    {
                        double paid_money = Convert.ToDouble(txt_paid.Text);
                        double left_to_be_paid_later = final_price - paid_money;
                        txt_left.Text = left_to_be_paid_later.ToString();
                        paid_amount = paid_money;
                        rest_amount = left_to_be_paid_later;
                        txt_credit.Text = (Double.Parse(txt_credit.Text) + Double.Parse(txt_left.Text)).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (txt_discount.Text != "")
                    {
                        double disc_value = Convert.ToDouble(txt_discount.Text);
                        double disc_percent = (disc_value / total_sales_price) * 100.0;
                        txt_disc_percent.Text = Math.Floor(disc_percent).ToString();
                        if (txt_paid.Text == final_price.ToString())
                        {

                            final_price = total_sales_price - disc_value;
                            final_total.Text = final_price.ToString();
                            txt_paid.Text = final_price.ToString();

                        }
                        else
                        {
                            final_price = total_sales_price - disc_value;
                            final_total.Text = final_price.ToString();
                            txt_left.Text = (final_price - Convert.ToDouble(txt_paid.Text)).ToString();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void bunifuMetroTextbox21_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel30_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuCustomLabel31_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {

        }
        public void load_bills()
        {
            Program.db.OpenConnection();
            dataGridView1.Rows.Clear();
            string query = "select purchased_bill_product.bill_ID,customers.customer_name,product.product_name,purchased_bill_product.product_quantity,purchased_bill_product.product_price,purchased_bill_product.product_total_price FROM purchased_bill_product INNER JOIN purchase_bill ON purchased_bill_product.bill_ID=purchase_bill.bill_ID INNER JOIN customers ON purchase_bill.customer_id=customers.customer_ID INNER JOIN product ON purchased_bill_product.product_ID=product.product_ID ";
            MySqlDataReader dr = Program.db.ExecuteReader(query);

            while (dr.Read())
            {

                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow roww = dataGridView1.Rows[rowId];
                roww.Cells[0].Value = dr["bill_ID"].ToString();
                roww.Cells[1].Value = dr["customer_name"].ToString();
                roww.Cells[2].Value = dr["product_name"].ToString();
                roww.Cells[3].Value = dr["product_quantity"].ToString();
                roww.Cells[4].Value = dr["product_price"].ToString();
                roww.Cells[5].Value = dr["product_total_price"].ToString();
            }
            dr.Close();
            Program.db.CloseConnection();
        }
        public void fill_dictionary()
        {
            Program.db.OpenConnection();
            string query = "select inventory.product_ID,product.product_name from inventory INNER JOIN product ON inventory.product_ID=product.product_ID";
            MySqlDataReader reader = Program.db.ExecuteReader(query);
            while(reader.Read())
            {
                productsIN_inventory.Add(reader["product_ID"].ToString(), reader["product_name"].ToString());
            }
            reader.Close();
            Program.db.CloseConnection();
        }
        private void purchases_usercontrol_Load(object sender, EventArgs e)
        {
            ///////////////////Fill dictionary//////////////////
            fill_dictionary();

            ///////////user_control_loads//////////////
            // load_bills();
       //     purchases_usercontrol.load_products_inventory();
            load_customers();
            dataGridView1.Rows.Clear();
            Program.db.OpenConnection();

            ////////////////Fill comboboxxx////////////////
            string query2 = "select customers.customer_name FROM customers where customer_type='" + "مورد" + "'";
            MySqlDataReader dr2 = Program.db.ExecuteReader(query2);

            while (dr2.Read())
            {

               // customer_name.Items.Add(dr2["customer_name"].ToString());
                cust_name.Items.Add(dr2["customer_name"].ToString());
            }
            dr2.Close();
            /////////second combobox////////////
            string query3 = "select p_group_name from product_group ";
            MySqlDataReader dr3 = Program.db.ExecuteReader(query3);
            while (dr3.Read())
            {
                cmb_prod_group.Items.Add(dr3["p_group_name"].ToString());
                // p_group.Items.Add(dr3["p_group_name"].ToString());
            }
            dr3.Close();
            /////////second combobox////////////
            string query4 = "select product_name from product";
            MySqlDataReader dr4 = Program.db.ExecuteReader(query4);
            while (dr4.Read())
            {
                cmb_product.Items.Add(dr4["product_name"].ToString());
                //comb_product.Items.Add(dr4["product_name"].ToString());
            }
            dr4.Close();
            Program.db.CloseConnection();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.db.OpenConnection();

            //////////////////Fill comboboxxx////////////////
            //اسم_المورد.Items.Clear();
            //esm_lmwrd.Items.Clear();
            string cust_ID = "";

            string query2 = "select customers.customer_ID FROM customers where customer_type='" + "مورد" + "'AND customer_name='"+customer_name.Text+"'";
            MySqlDataReader dr2 = Program.db.ExecuteReader(query2);

            while (dr2.Read())
            {

                cust_ID = dr2["customer_ID"].ToString();
            }
            dr2.Close();
            string query3 = "select customers.credit FROM customers where customer_ID='" + cust_ID + "'";
            MySqlDataReader dr3 = Program.db.ExecuteReader(query3);

            while (dr3.Read())
            {

                txt_credit.Text=dr3["credit"].ToString();

                if (txt_credit.Text == "") 
                {
                    txt_credit.Text = "0";
                }
            }
            dr3.Close();
            Program.db.CloseConnection();

        }

        private void esm_lmwrd_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            Program.db.OpenConnection();
          //  cmb_bill_num.Items.Clear();
            string supp_id = "";
            string supp_id_query = "select customer_ID FROM customers where customer_name='" + cust_name.SelectedItem.ToString() + "'";
            MySqlDataReader dr = Program.db.ExecuteReader(supp_id_query);
            if (dr.Read())
            {
                supp_id = dr["customer_ID"].ToString();
                MessageBox.Show(supp_id);
            }
            dr.Close();
            string return_bill_num = "select bill_ID FROM purchase_bill where customer_id='" + supp_id + "'";
            MySqlDataReader dr2 = Program.db.ExecuteReader(return_bill_num);
            while (dr2.Read())
            {
                //cmb_bill_num.Items.Add(dr2["bill_ID"].ToString());
            }
            dr2.Close();
            Program.db.CloseConnection();
        }
     
        public void load_purch_bills()
        {
           
            dgv_purch_search.Rows.Clear();
            Program.db.OpenConnection();
            MySqlDataReader row;
            if (rd_search_bucustomer.Checked)
            {

                if (cust_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم المورد");

                }
                else
                {
                    int customer_ID = get_customer_ID(cust_name.Text);
                    MessageBox.Show(customer_ID.ToString());
                    string query8 = "SELECT purchase_bill.bill_ID,purchase_bill.bill_type,purchase_bill.bill_date,purchase_bill.final_price,customers.customer_name FROM purchase_bill INNER join customers where customers.customer_ID = purchase_bill.customer_id and purchase_bill.customer_id = '" + customer_ID + "' order by purchase_bill.bill_ID";
                    row = Program.db.ExecuteReader(query8);
                    while (row.Read())
                    {                

                        int rowId = dgv_purch_search.Rows.Add();
                        DataGridViewRow roww = dgv_purch_search.Rows[rowId];
                        roww.Cells[0].Value = row["bill_ID"].ToString();
                        roww.Cells[1].Value = row["customer_name"].ToString();
                        roww.Cells[2].Value = row["bill_type"].ToString();
                        roww.Cells[3].Value = row["bill_date"].ToString();
                        // double total_price = Convert.ToDouble(roww.Cells[3].Value) * Convert.ToDouble(roww.Cells[4].Value);
                        roww.Cells[4].Value = row["final_price"].ToString();


                    }
                    row.Close();
                }

            }
            if (rd_billState.Checked)
            {


                if (cmb_bill_state.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل حاله الفاتوره ");

                }
                else
                {
                    // int customer_ID = get_customer_ID(cmb_cust_name_search.Text);
                    string query8 = "";
                    if (cmb_bill_state.Text == "منتهيه")
                    {
                        query8 = "SELECT purchase_bill.bill_ID,purchase_bill.bill_type,purchase_bill.bill_date,purchase_bill.final_price,customers.customer_name FROM purchase_bill INNER join customers where customers.customer_ID = purchase_bill.customer_id and( purchase_bill.left_money = 0  or purchase_bill.payed_money =purchase_bill.final_price ) order by purchase_bill.bill_ID";

                    }
                    else if (cmb_bill_state.Text == "غير منتهيه")
                    {
                        query8 = "SELECT purchase_bill.bill_ID,purchase_bill.bill_type,purchase_bill.bill_date,purchase_bill.final_price,customers.customer_name FROM purchase_bill INNER join customers where customers.customer_ID = purchase_bill.customer_id and purchase_bill.left_money > 0  order by purchase_bill.bill_ID";

                    }
                    row = Program.db.ExecuteReader(query8);
                    while (row.Read())
                    {
                        int rowId = dgv_purch_search.Rows.Add();
                        DataGridViewRow roww = dgv_purch_search.Rows[rowId];
                        // cmb.Items.Add(row["customer_name"].ToString());
                        roww.Cells[0].Value = row["bill_ID"].ToString();
                        roww.Cells[1].Value = row["customer_name"].ToString();
                        roww.Cells[2].Value = row["bill_type"].ToString();
                        // roww.Cells[3].Value = row["product_quantity"].ToString();
                        //    quantities.Add(Convert.ToInt32(row["product_quantity"].ToString()));
                        roww.Cells[3].Value = row["bill_date"].ToString();
                        // double total_price = Convert.ToDouble(roww.Cells[3].Value) * Convert.ToDouble(roww.Cells[4].Value);
                        roww.Cells[4].Value = row["final_price"].ToString();


                    }
                    row.Close();

                }
            }


            if (rd_search_bydate.Checked)
            {
                string query8 = "SELECT purchase_bill.bill_ID,purchase_bill.bill_type,purchase_bill.bill_date,purchase_bill.bill_type,purchase_bill.final_price,customers.customer_name FROM purchase_bill INNER join customers on customers.customer_ID = purchase_bill.customer_id where bill_date >= '" + Convert.ToDateTime(dtp1.Value).ToString("yyyy-MM-dd ") + "' and bill_date <= '" + Convert.ToDateTime(dtp2.Value).ToString("yyyy-MM-dd ") + "' order by purchase_bill.bill_ID";
                row = Program.db.ExecuteReader(query8);
                while (row.Read())
                {
                    int rowId = dgv_purch_search.Rows.Add();
                    DataGridViewRow roww = dgv_purch_search.Rows[rowId];
                    // cmb.Items.Add(row["customer_name"].ToString());
                    roww.Cells[0].Value = row["bill_ID"].ToString();
                    roww.Cells[1].Value = row["customer_name"].ToString();
                    roww.Cells[2].Value = row["bill_type"].ToString();
                    // roww.Cells[3].Value = row["product_quantity"].ToString();
                    //    quantities.Add(Convert.ToInt32(row["product_quantity"].ToString()));
                    roww.Cells[3].Value = row["bill_date"].ToString();
                    // double total_price = Convert.ToDouble(roww.Cells[3].Value) * Convert.ToDouble(roww.Cells[4].Value);
                    roww.Cells[4].Value = row["final_price"].ToString();


                }
                row.Close();


            }

            if (rd_search_bytype.Checked)
            {

                if (bill_type.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل نوع الفاتوره  ");

                }
                else
                {
                    MessageBox.Show(bill_type.Text);

                    string query8 = "SELECT purchase_bill.bill_ID,purchase_bill.bill_type,purchase_bill.bill_date,purchase_bill.final_price,customers.customer_name FROM purchase_bill INNER join customers on customers.customer_ID = purchase_bill.customer_id WHERE purchase_bill.bill_type='" + bill_type.Text + "'";
                    row = Program.db.ExecuteReader(query8);
                    while (row.Read())
                    {

                        int rowId = dgv_purch_search.Rows.Add();
                        DataGridViewRow roww = dgv_purch_search.Rows[rowId];
                        // cmb.Items.Add(row["customer_name"].ToString());
                        roww.Cells[0].Value = row["bill_ID"].ToString();
                        roww.Cells[1].Value = row["customer_name"].ToString();
                        roww.Cells[2].Value = row["bill_type"].ToString();
                        // roww.Cells[3].Value = row["product_quantity"].ToString();
                        //    quantities.Add(Convert.ToInt32(row["product_quantity"].ToString()));
                        roww.Cells[3].Value = row["bill_date"].ToString();
                        // double total_price = Convert.ToDouble(roww.Cells[3].Value) * Convert.ToDouble(roww.Cells[4].Value);
                        roww.Cells[4].Value = row["final_price"].ToString();


                    }
                    row.Close();

                }
            }
            //string query = " select * from sales_bill " +
            //    "where bill_ID = '" + cmb_bill_IDS.Text + "'" +
            //    " AND bill_type = '" + cmb_bill_type_search.Text + "' " +
            //    // "AND bill_date = '" + Convert.ToDateTime(dtp_search.Value).ToString("yyyy-MM-dd ") + "' " +
            //    "AND customer_id = '" + customer_ID + "'";
            //row = Program.db.ExecuteReader(query);
            //while (row.Read())
            //{
            //    txt_total_search.Text = row["total_price"].ToString();
            //    txt_left_search.Text = row["left_money"].ToString();
            //    txt_paid_search.Text = row["paid_money"].ToString();
            //    txt_final_search.Text = row["final_price"].ToString();
            //    ttxt_disc_amount_search.Text = row["discount_amount"].ToString();
            //    double disc_value = Convert.ToDouble(ttxt_disc_amount_search.Text);
            //    double disc_percent = (disc_value / Convert.ToDouble(txt_total_search.Text)) * 100.0;
            //    txt_disc_percent_search.Text = disc_percent.ToString();

            //    total_sales_price = Convert.ToDouble(txt_total_search.Text);
            //    final_price = Convert.ToDouble(txt_final_search.Text);
            //    paid_amount = Convert.ToDouble(txt_paid_search.Text);
            //    rest_amount = Convert.ToDouble(txt_left_search.Text);


            //}
            //row.Close();

            //quantities.Clear();
            //MySqlDataReader reader;
            //string query1 = " select product.product_name, customers.customer_name, sales_bill_product.bill_id,sales_bill_product.product_id,sales_bill_product.product_quantity,sales_bill_product.product_price from sales_bill inner JOIN sales_bill_product on sales_bill.bill_ID=sales_bill_product.bill_id " +
            //    "inner join customers on customers.customer_ID=sales_bill.customer_id  INNER join product on sales_bill_product.product_id = product.product_ID  " +
            //    "where sales_bill.bill_ID = '" + cmb_bill_IDS.Text + "'" +
            //    " AND sales_bill.bill_type = '" + cmb_bill_type_search.Text + "' " +
            //    "AND sales_bill.bill_date = '" + Convert.ToDateTime(dtp_search.Value).ToString("yyyy-MM-dd") + "'" +
            //    "AND sales_bill.customer_id = '" + customer_ID + "'";
            //reader = Program.db.ExecuteReader(query1);
            //while (reader.Read())
            //{

            //    int rowId = dgv_sales_search.Rows.Add();
            //    DataGridViewRow roww = dgv_sales_search.Rows[rowId];
            //    // cmb.Items.Add(row["customer_name"].ToString());
            //    roww.Cells[0].Value = reader["bill_id"].ToString();
            //    roww.Cells[1].Value = reader["customer_name"].ToString();
            //    roww.Cells[2].Value = reader["product_name"].ToString();
            //    roww.Cells[3].Value = reader["product_quantity"].ToString();
            //    quantities.Add(Convert.ToInt32(reader["product_quantity"].ToString()));
            //    roww.Cells[4].Value = reader["product_price"].ToString();
            //    double total_price = Convert.ToDouble(roww.Cells[3].Value) * Convert.ToDouble(roww.Cells[4].Value);
            //    roww.Cells[5].Value = total_price.ToString();

            //}
            //reader.Close();



            Program.db.CloseConnection();
            //}
            //  catch (Exception ex)
            // {
            //     MessageBox.Show(ex.ToString());
            // }

        }
        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            load_purch_bills();
        }
    }
}
