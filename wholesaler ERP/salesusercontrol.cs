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
    public struct Product_details
    {
        public string product_ID, product_name, product_grp, product_code,
              product_selling_price, product_discounted_price, product_desc;
        public int avaliable_qty, current_quantity, alert_quantity;

    };
    public partial class salesusercontrol : UserControl
    {
        public static Dictionary<string, Product_details> products_inventory = new Dictionary<string, Product_details>();

        Dictionary<string, int> product_groups = new Dictionary<string, int>();
        
        public static Dictionary<string, int> customers_sales = new Dictionary<string, int>();

        List<int> quantities = new List<int>();

        bool new_customer = false;
        string product_ID, product_name, product_grp, product_code, product_selling_price, product_discounted_price, product_desc;
        int avaliable_qty, current_qty;
        int new_quantity, previous_quantity, returned_qty;
        int new_bill_ID, old_bill_ID;
        double customer_credit = 0;
        double total_sales_price, final_price, paid_amount, rest_amount;
        bool done=false;
        public salesusercontrol()
        {
            InitializeComponent();


        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        public static void load_products_inventory()
        {

            products_inventory.Clear();
            Program.db.OpenConnection();
            MySqlDataReader row;
            string query = "select product.description,product.product_quantity, product.product_name,product.product_ID,product.selling_price,product.discounted_price,inventory.quantity,product.product_code,product.p_group_id" +
                " from product INNER join inventory on product.product_ID=inventory.product_ID ";
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {

                Product_details prod = new Product_details();
                prod.product_ID = row["product_ID"].ToString();
                prod.product_name = row["product_name"].ToString();
                prod.product_selling_price = row["selling_price"].ToString();
                prod.product_code = row["product_Code"].ToString();
                prod.product_discounted_price = row["discounted_price"].ToString();
                prod.product_grp = row["p_group_id"].ToString();
                prod.product_desc = row["description"].ToString();
                prod.avaliable_qty = Convert.ToInt32(row["quantity"].ToString());
                prod.alert_quantity = Convert.ToInt32(row["product_quantity"].ToString());
                prod.current_quantity = prod.avaliable_qty;

                products_inventory.Add(prod.product_name, prod);
                //if (Convert.ToInt32(avaliable_qty) <= Convert.ToInt32(row["product_quantity"].ToString()))
                //{
                //    MessageBox.Show(product_name + " : لقد وصلت للحد الادني من الكميه للصنف ", "تنبيه",
                //       MessageBoxButtons.OK, MessageBoxIcon.Error);



                //}
            }
            row.Close();
            Program.db.CloseConnection();
        }
        private void salesusercontrol_Load(object sender, EventArgs e)
        {




            load_customers();
            load_product_groups();
            load_products_inventory();
            txt_paid_amount.Visible = false;
            txt_rest.Visible = false;
            lbl_paid.Visible = false;
            lbl_rest.Visible = false;
            Program.treasury_count();
            txt_treasuty_amount.Text = Program.treasury_amount.ToString();
            Program.db.OpenConnection();
            set_bill_ID();
            Program.db.CloseConnection();
        }







        private void tabPage1_Click(object sender, EventArgs e)
        {
            Program.treasury_count();
            txt_treasury_search.Text = Program.treasury_amount.ToString();
            txt_treasuty_amount.Text = Program.treasury_amount.ToString();
        }


        public string  get_bill_ID( int customer_ID)
        {
            string bill_ID = "";
            string query = "SELECT max(bill_ID)FROM sales_bill where customer_id= '"+customer_ID +"'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {

              bill_ID=row[0].ToString();

            }
            row.Close();

            return bill_ID;
        }


        public void Add_Bill()
        {
            try
            {

                int customer_ID = 0;
                customer_ID = get_customer_ID(cmb_customer_name.Text);
                if (cmb_bill_type.Text != "")
                {

                    if (cmb_customer_name.Text != "")
                    {
                        Program.db.OpenConnection();
                        string query = "Insert INTO sales_bill(bill_type,bill_date,customer_id ,total_price,discount_amount,final_price,paid_money	,left_money	) " +
                            "Values ('" + cmb_bill_type.Text + "' , '" + Convert.ToDateTime(dtp_bill_date.Value).ToString("yyyy-MM-dd ") + "', '" + customer_ID.ToString() + "', '" + txt_total_sales.Text + "', '" + txt_disc_value.Text + "', '" + txt_final_total.Text + "', '" + txt_paid_amount.Text + "', '" + txt_rest.Text + "'); ";
                        Program.db.ExecuteNonQuery(query);



                        string bill_ID = get_bill_ID(customer_ID);



                        for (int i = 0; i < dgv_sales.Rows.Count; i++)
                        {

                            //  string bill_ID = txt_bill_ID.Text;
                            string product_name = dgv_sales.Rows[i].Cells[2].Value.ToString();
                            //   get_product_details(product_name);
                           
                            Product_details prod = products_inventory[product_name];

                            string quantity = dgv_sales.Rows[i].Cells[3].Value.ToString();
                            int price = Convert.ToInt32(dgv_sales.Rows[i].Cells[4].Value);
                            string query3 = "Insert INTO sales_bill_product(bill_id,product_id ,product_quantity ,product_price) " +
                              "Values ('" + bill_ID + "' , '" + prod.product_ID + "', '" + quantity + "', '" + price + "'); ";
                            Program.db.ExecuteNonQuery(query3);


                        }
                        for (int i = 0; i < dgv_sales.Rows.Count; i++)
                        {
                            int selling_qty = Convert.ToInt32(dgv_sales.Rows[i].Cells[3].Value);
                            string prod_name = dgv_sales.Rows[i].Cells[2].Value.ToString();
                            

                                Product_details prod = products_inventory[prod_name];
                            
                            prod.avaliable_qty -= selling_qty;
                            string query4 = "Update inventory Set quantity='" + prod.avaliable_qty
                                          + "'where product_ID ='" + prod.product_ID + "'";
                            Program.db.ExecuteNonQuery(query4);

                            products_inventory[prod_name] = prod;
                           // MessageBox.Show("تم تعديل البيانات");


                        }


                        double income_money = 0.0;

                        if (cmb_bill_type.Text == "اجل")
                        {


                            income_money += Convert.ToDouble(txt_paid_amount.Text);
                            get_customer_credit(customer_ID);


                            double new_credit = customer_credit + rest_amount;
                            string query5 = "Update customers Set credit='" + new_credit
                                           + "'where customer_ID ='" + customer_ID.ToString() + "'";
                            Program.db.ExecuteNonQuery(query5);
                        }

                        else
                        {
                            income_money += Convert.ToDouble(txt_final_total.Text);

                        }



                        string query6 = "Insert INTO treasury(date,operation_type,money_amount,money_for,notes,operator_ID,operator_type,bill_id ) " +
                          "Values ('" + Convert.ToDateTime(dtp_bill_date.Value).ToString("yyyy-MM-dd") + "' , '" + "قبض خارجي" + "', '" + income_money + "', '" +
                          "فاتوره مبيعات" + "', '" + " " + "', '" + cmb_customer_name.Text + "', '" + "عميل" + "', '" + txt_bill_ID.Text + "'); ";

                        Program.db.ExecuteNonQuery(query6);


                        //  set_bill_ID();
                        Program.db.CloseConnection();

                        Program.treasury_count();
                        txt_treasuty_amount.Text = Program.treasury_amount.ToString();
                        txt_treasury_search.Text = Program.treasury_amount.ToString();

                        MessageBox.Show("تم تسجيل الفاتوره بنجاح");
                        done = true;

                        load_products_inventory();

              
                        Program.sales_close = true;

                    }
                    else
                    {
                        MessageBox.Show("الرجاء ادخال اسم العميل ");
                    }
                }
                else
                {
                    if (cmb_bill_type.Text == "")
                    { MessageBox.Show("الرجاء ادخال نوع الفاتوره "); }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("من فضلك اكمل ادخال جميع البيانات");
                Program.db.CloseConnection();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            Add_Bill();
            cmb_bill_type.Text = "";
            cmb_customer_name.Text = "";
            cmb_price_tybe.Text = "";
            cmb_products.Text = "";
            cmb_product_category.Text = "";
            txt_disc_value.Text = "";
            txt_disc_percent.Text = "";
            txt_customer_credit.Text = "";
            txt_final_total.Text = "";
            txt_paid_amount.Text = "";
            txt_p_code.Text = "";
            txt_total_sales.Text = "";
            txt_rest.Text = "";
            txt_quantity.Text = "";
            txt_product_price.Text = "";
            dgv_sales.Rows.Clear();
            lbl_available_qty.Text = "0";
            lbl_available_qty.Visible = false;
            lbl_qtyavaliable_name.Visible = false;

        }

        public void set_bill_ID()
        {
            try
            {
                string query2 = "select max(bill_id) from sales_bill";
                MySqlDataReader reader = Program.db.ExecuteReader(query2);
                while (reader.Read())
                {
                    old_bill_ID = Convert.ToInt32(reader[0].ToString());
                    new_bill_ID = old_bill_ID + 1;
                    txt_bill_ID.Text = new_bill_ID.ToString();
                }

                reader.Close();
            }
            catch
            {
                new_bill_ID = 1;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string prod_name = cmb_products.Text;
                Product_details prod = products_inventory[prod_name];


                if (cmb_price_tybe.Text == "عادي")
                {
                    txt_product_price.Text = prod.product_selling_price;
                    txt_product_price.Enabled = false;
                }
                else if (cmb_price_tybe.Text == "خاص")
                {
                    txt_product_price.Text = prod.product_discounted_price;
                    txt_product_price.Enabled = false;

                }
                else
                {
                    txt_product_price.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }



        private void cmb_bill_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_bill_type.Text == "اجل")
            {
                txt_paid_amount.Visible = true;
                txt_rest.Visible = true;
                lbl_paid.Visible = true;
                lbl_rest.Visible = true;
            }
            else
            {
                txt_paid_amount.Visible = false;
                txt_rest.Visible = false;
                lbl_paid.Visible = false;
                lbl_rest.Visible = false;
            }
        }



        private void btn_add_to_dgv_Click(object sender, EventArgs e)
        {
            try
            {
                bool added_before = false;
                string prodName = cmb_products.Text;
                Product_details prod = products_inventory[prodName];

                int row_index_before=-1;

                if (prod.current_quantity > 0)
                {
                    if (Convert.ToInt32(txt_quantity.Text) <= prod.current_quantity)
                    {
                        for (int i = 0; i < dgv_sales.Rows.Count; i++)
                        {


                            if (cmb_products.Text == dgv_sales.Rows[i].Cells[2].Value.ToString())
                            {
                                row_index_before = i;
                                added_before = true;
                                break;
                            }


                        }

                        if (added_before == false)
                        {
                            int rowId = dgv_sales.Rows.Add();
                            DataGridViewRow roww = dgv_sales.Rows[rowId];
                            roww.Cells[0].Value = dtp_bill_date.Value.ToString();
                            roww.Cells[1].Value = cmb_customer_name.Text;
                            roww.Cells[2].Value = cmb_products.Text;
                            roww.Cells[3].Value = txt_quantity.Text;

                            quantities.Add(Convert.ToInt32(txt_quantity.Text));

                            roww.Cells[4].Value = txt_product_price.Text;
                            double total_price = Convert.ToDouble(txt_quantity.Text) * Convert.ToDouble(txt_product_price.Text);
                            roww.Cells[5].Value = total_price.ToString();
                            update_total_price(dgv_sales);
                        }
                        else if(added_before==true)
                        {

                            int before = Convert.ToInt32(dgv_sales.Rows[row_index_before].Cells[3].Value.ToString());
                            before += Convert.ToInt32(txt_quantity.Text);
                            dgv_sales.Rows[row_index_before].Cells[3].Value=before.ToString();

                            double edited_final_price = Convert.ToDouble(dgv_sales.Rows[row_index_before].Cells[3].Value) * Convert.ToInt32(dgv_sales.Rows[row_index_before].Cells[4].Value);
                            dgv_sales.Rows[row_index_before].Cells[5].Value = edited_final_price.ToString();
                            update_total_price(dgv_sales);

                            quantities[row_index_before] = before;

                        }
                        
                        
                        txt_total_sales.Text = total_sales_price.ToString();
                        txt_final_total.Text = total_sales_price.ToString();
                        txt_paid_amount.Text = total_sales_price.ToString();
                        prod.current_quantity -= Convert.ToInt32(txt_quantity.Text);

                        if (Convert.ToInt32(prod.current_quantity) <= prod.alert_quantity)
                        {
                            MessageBox.Show(product_name + " : لقد وصلت للحد الادني من الكميه للصنف ", "تنبيه",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                            lbl_available_qty.BackColor = Color.Red;
                        }
                        lbl_available_qty.Text = prod.current_quantity.ToString();


                        products_inventory[prodName] = prod;

                        //Program.db.OpenConnection();
                        //string query5 = "Update inventory Set quantity='" + avaliable_qty
                        //             + "'where product_ID ='" + product_ID + "'";
                        //Program.db.ExecuteNonQuery(query5);
                        //Program.db.CloseConnection();

                    }
                    else
                    {

                        MessageBox.Show(cmb_products.Text + "الكميه المتاحه في المخزن لا تكفي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show(cmb_products.Text + "لقد انتهي هذا الصنف من المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("من فضلك اكمل ادخال جميع البيانات ");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                //  int previous_quantity=Convert.ToInt32( dgv_sales_search.Rows[e.RowIndex].Cells[3].Value.ToString());

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 5 && e.RowIndex >= 0)
                {

                    int bill_id = Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string bill_cust_name = dgv_sales_search.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string bill_type = dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString();
                    form_bill_details newone = new form_bill_details(bill_id, bill_cust_name, bill_type);
                    newone.Show();

                }
                //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7 && e.RowIndex >= 0)
                //{

                //    string box_msg = " هل تريد التأكيد علي عمليه المرتجعات";

                //    string box_title = "تحذير ";

                //    var selected = MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo);

                //    if (selected == DialogResult.Yes)
                //    {
                //        Program.db.OpenConnection();

                //        string returned_type = "مبيعات";
                //        string quantity = dgv_sales_search.Rows[e.RowIndex].Cells[3].Value.ToString();
                //        string price = (Convert.ToDouble(quantity) * Convert.ToDouble(dgv_sales_search.Rows[e.RowIndex].Cells[4].Value.ToString())).ToString();
                //        //  string price = dgv_sales_search.Rows[e.RowIndex].Cells[4].Value.ToString();
                //        string total_price_returned = (Convert.ToInt32(quantity) * Convert.ToDouble(price)).ToString();
                //        //  string total_price_returned = dgv_sales_search.Rows[e.RowIndex].Cells[5].Value.ToString();
                //        int customer_ID = get_customer_ID(cmb_cust_name_search.Text);


                //        string prodName = dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString();
                //        Product_details prod = products_inventory[prodName];


                //        //  get_product_details(dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString());

                //        string bill_ID = dgv_sales_search.Rows[e.RowIndex].Cells[0].Value.ToString();

                //        string query3 = "Insert INTO returned (product_ID,product_quantity ,customer_ID ,date,price,returned_type,total_price,bill_id) " +
                //        "Values ('" + prod.product_ID + "' , '" + quantity + "', '" + customer_ID + "', '"
                //        + Convert.ToDateTime(DateTime.UtcNow.ToString("yyyy-MM-dd h:mm:ss tt"))
                //             + "', '" + price + "', '" + returned_type + "', '" + total_price_returned + "', '" + bill_ID + "'); ";
                //        Program.db.ExecuteNonQuery(query3);

                //        returned_qty = Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[3].Value.ToString());

                //        prod.avaliable_qty += returned_qty;

                //        string query4 = "Update inventory Set quantity='" + prod.avaliable_qty
                //                          + "'where product_ID ='" + prod.product_ID + "'";
                //        Program.db.ExecuteNonQuery(query4);


                //        products_inventory[prodName] = prod;
                //        Program.treasury_amount -= Convert.ToDouble(total_price_returned);
                //        string query6 = "Insert INTO treasury(date,operation_type,money_amount,money_for,notes,operator_ID,operator_type,bill_id ) " +
                //           "Values ('" + Convert.ToDateTime(DateTime.UtcNow.ToString("yyyy-MM-dd h:mm:ss tt"))
                //                  + "' , '" + "صرف خارجي" + "', '" + total_price_returned + "', '" +
                //           "فاتوره مرتجعات" + "', '" + " " + "', '" + cmb_customer_name.Text + "', '" + "عميل" + "', '" + cmb_bill_IDS.Text + "'); ";

                //        Program.db.ExecuteNonQuery(query6);



                //        //previous_quantity = quantities[e.RowIndex];
                //        //new_quantity = previous_quantity - returned_qty;

                //        //total_sales_price = total_sales_price - Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[5].Value);


                //        //quantities[e.RowIndex] = new_quantity;

                //        //dgv_sales_search.Rows[e.RowIndex].Cells[3].Value = new_quantity.ToString();
                //        //dgv_sales_search.Rows[e.RowIndex].Cells[5].Value = (new_quantity * Convert.ToDouble(dgv_sales_search.Rows[e.RowIndex].Cells[4].Value)).ToString();

                //        ttxt_disc_amount_search.Text = (total_sales_price * (Convert.ToDouble(txt_disc_percent_search.Text) / 100.0)).ToString();
                //        final_price = total_sales_price - Convert.ToDouble(ttxt_disc_amount_search.Text);

                //        txt_total_search.Text = total_sales_price.ToString();
                //        txt_final_search.Text = final_price.ToString();
                //        Program.db.CloseConnection();
                //    }
                //    else
                //    {
                //        load_bill();

                //    }
                //}

                //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 6 && e.RowIndex >= 0)
                //{
                //    bool alert = false;
                //    string prodName = dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString();
                //    Product_details prod = products_inventory[prodName];
                //    double edited_final_price = Convert.ToDouble(dgv_sales_search.Rows[e.RowIndex].Cells[3].Value) * Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[4].Value);

                //    dgv_sales_search.Rows[e.RowIndex].Cells[5].Value = edited_final_price.ToString();
                //    update_total_price(dgv_sales_search);

                //    int quantity = Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[3].Value.ToString());
                //    string productName = dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString();
                //    int prev_qty = quantities[e.RowIndex];
                //    int new_qty = 0;
                //    if (prev_qty < quantity)
                //    {
                //        if (prod.current_quantity > 0)
                //        {
                //            new_qty = quantity - prev_qty;

                //            if (Convert.ToInt32(new_qty) <= prod.current_quantity)
                //            {
                //                prod.current_quantity -= new_qty;
                //            }
                //            else
                //            {
                //                alert = true;
                //                MessageBox.Show(cmb_products.Text + "الكميه المتاحه في المخزن لا تكفي ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //                dgv_sales_search.Rows[e.RowIndex].Cells[3].Value = prev_qty;
                //            }
                //        }
                //        else
                //        {
                //            alert = true;
                //            MessageBox.Show(cmb_products.Text + "لقد انتهي هذا الصنف من المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            dgv_sales_search.Rows[e.RowIndex].Cells[3].Value = prev_qty;

                //        }

                //    }

                //    else if (prev_qty > quantity)
                //    {

                //        new_qty = prev_qty - quantity;
                //        prod.current_quantity += new_qty;



                //    }

                //    if (alert == false)
                //    {
                //        //  quantities[e.RowIndex] = quantity;
                //        // get_product_details(productName);

                //        dgv_sales_search.Rows[e.RowIndex].Cells[5].Value = edited_final_price.ToString();
                //        update_total_price(dgv_sales_search);
                //        lbl_available_qty.Text = prod.current_quantity.ToString();

                //        products_inventory[prodName] = prod;
                //        final_price = total_sales_price;
                //        txt_total_search.Text = total_sales_price.ToString();
                //        txt_final_search.Text = final_price.ToString();
                //    }

            



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Program.db.CloseConnection();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            add_Customer cust = new add_Customer();
            cust.Show();

            new_customer = true;

           // load_customers();
        }

        public void load_bill()
        {
            //   try
            // {

            dgv_sales_search.Rows.Clear();

            Program.db.OpenConnection();
            MySqlDataReader row;


            if (rd_search_bucustomer.Checked)
            {

                if (cmb_customer_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم العميل");

                }
                else
                {
                    int customer_ID = get_customer_ID(cmb_cust_name_search.Text);

                    string query8 = "SELECT sales_bill.bill_ID,sales_bill.bill_type,sales_bill.bill_date,sales_bill.final_price,customers.customer_name FROM sales_bill INNER join customers where customers.customer_ID = sales_bill.customer_id and sales_bill.customer_id = '" + customer_ID + "' order by sales_bill.bill_ID";
                    row = Program.db.ExecuteReader(query8);
                    while (row.Read())
                    {


                        //txt_total_search.Text = row["total_price"].ToString();
                        //txt_left_search.Text = row["left_money"].ToString();
                        //txt_paid_search.Text = row["paid_money"].ToString();
                        //txt_final_search.Text = row["final_price"].ToString();
                        //ttxt_disc_amount_search.Text = row["discount_amount"].ToString();
                        //double disc_value = Convert.ToDouble(ttxt_disc_amount_search.Text);
                        //double disc_percent = (disc_value / Convert.ToDouble(txt_total_search.Text)) * 100.0;
                        //txt_disc_percent_search.Text = disc_percent.ToString();

                        //total_sales_price = Convert.ToDouble(txt_total_search.Text);
                        //final_price = Convert.ToDouble(txt_final_search.Text);
                        //paid_amount = Convert.ToDouble(txt_paid_search.Text);
                        //rest_amount = Convert.ToDouble(txt_left_search.Text);



                        int rowId = dgv_sales_search.Rows.Add();
                        DataGridViewRow roww = dgv_sales_search.Rows[rowId];
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
                        query8 = "SELECT sales_bill.bill_ID,sales_bill.bill_type,sales_bill.bill_date,sales_bill.final_price,customers.customer_name FROM sales_bill INNER join customers where customers.customer_ID = sales_bill.customer_id and (sales_bill.left_money = 0  or sales_bill.paid_money =sales_bill.final_price) order by sales_bill.bill_ID";

                    }
                    else if (cmb_bill_state.Text == "غير منتهيه")
                    {
                        query8 = "SELECT sales_bill.bill_ID,sales_bill.bill_type,sales_bill.bill_date,sales_bill.final_price,customers.customer_name FROM sales_bill INNER join customers where customers.customer_ID = sales_bill.customer_id and sales_bill.left_money > 0  order by sales_bill.bill_ID";

                    }
                    row = Program.db.ExecuteReader(query8);
                    while (row.Read())
                    {


                        //txt_total_search.Text = row["total_price"].ToString();
                        //txt_left_search.Text = row["left_money"].ToString();
                        //txt_paid_search.Text = row["paid_money"].ToString();
                        //txt_final_search.Text = row["final_price"].ToString();
                        //ttxt_disc_amount_search.Text = row["discount_amount"].ToString();
                        //double disc_value = Convert.ToDouble(ttxt_disc_amount_search.Text);
                        //double disc_percent = (disc_value / Convert.ToDouble(txt_total_search.Text)) * 100.0;
                        //txt_disc_percent_search.Text = disc_percent.ToString();

                        //total_sales_price = Convert.ToDouble(txt_total_search.Text);
                        //final_price = Convert.ToDouble(txt_final_search.Text);
                        //paid_amount = Convert.ToDouble(txt_paid_search.Text);
                        //rest_amount = Convert.ToDouble(txt_left_search.Text);



                        int rowId = dgv_sales_search.Rows.Add();
                        DataGridViewRow roww = dgv_sales_search.Rows[rowId];
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
                string query8 = "SELECT sales_bill.bill_ID,sales_bill.bill_type,sales_bill.bill_date,sales_bill.bill_type,sales_bill.final_price,customers.customer_name FROM sales_bill INNER join customers on customers.customer_ID = sales_bill.customer_id where bill_date >= '" + Convert.ToDateTime(dtp_search.Value).ToString("yyyy-MM-dd ") + "' and bill_date <= '"+ Convert.ToDateTime(dtp_end.Value).ToString("yyyy-MM-dd ") + "' order by sales_bill.bill_ID";
                row = Program.db.ExecuteReader(query8);
                while (row.Read())
                {






                    int rowId = dgv_sales_search.Rows.Add();
                    DataGridViewRow roww = dgv_sales_search.Rows[rowId];
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

                if (cmb_customer_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل نوع الفاتوره  ");

                }
                else
                {
                    string query8 = "SELECT sales_bill.bill_ID,sales_bill.bill_type,sales_bill.bill_date,sales_bill.final_price,customers.customer_name FROM sales_bill INNER join customers on customers.customer_ID = sales_bill.customer_id WHERE sales_bill.bill_type='" + cmb_bill_type_search.Text + "' order by sales_bill.bill_ID";
                    row = Program.db.ExecuteReader(query8);
                    while (row.Read())
                    {






                        int rowId = dgv_sales_search.Rows.Add();
                        DataGridViewRow roww = dgv_sales_search.Rows[rowId];
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

        private void btn_view_search_Click(object sender, EventArgs e)
        {
            load_bill();

        }



        private void txt_disc_percent_KeyPress(object sender, KeyPressEventArgs e)
        {
            double pre = 0;

            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txt_disc_percent.Text != "")
                    {
                        double disc_percent = Convert.ToDouble(txt_disc_percent.Text);
                        double disc_value = total_sales_price * (disc_percent / 100.0);
                        txt_disc_value.Text = disc_value.ToString();
                        if (txt_paid_amount.Text == final_price.ToString())
                        {

                            final_price = total_sales_price - disc_value;
                            txt_final_total.Text = final_price.ToString();
                            txt_paid_amount.Text = final_price.ToString();

                        }
                        else
                        {
                            final_price = total_sales_price - disc_value;
                            txt_final_total.Text = final_price.ToString();
                            txt_rest.Text = (final_price - Convert.ToDouble(txt_paid_amount.Text)).ToString();

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void txt_disc_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            try { 
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_disc_value.Text != "")
                {
                    double disc_value = Convert.ToDouble(txt_disc_value.Text);
                    double disc_percent = (disc_value / total_sales_price) * 100.0;
                    txt_disc_percent.Text = Math.Floor(disc_percent).ToString();
                    if (txt_paid_amount.Text == final_price.ToString())
                    {

                        final_price = total_sales_price - disc_value;
                        txt_final_total.Text = final_price.ToString();
                        txt_paid_amount.Text = final_price.ToString();

                    }
                    else
                    {
                        final_price = total_sales_price - disc_value;
                        txt_final_total.Text = final_price.ToString();
                        txt_rest.Text = (final_price - Convert.ToDouble(txt_paid_amount.Text)).ToString();

                    }

                }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void txt_paid_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (txt_paid_amount.Text != "")
                    {
                        double paid_money = Convert.ToDouble(txt_paid_amount.Text);
                        double left_to_be_paid_later = final_price - paid_money;
                        txt_rest.Text = left_to_be_paid_later.ToString();
                        paid_amount = paid_money;
                        rest_amount = left_to_be_paid_later;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void txt_rest_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                bool alert = false;
                string prodName = dgv_sales.Rows[e.RowIndex].Cells[2].Value.ToString();
                Product_details prod = products_inventory[prodName];
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7 && e.RowIndex >= 0)
                {

                    prod.current_quantity += Convert.ToInt32(dgv_sales.Rows[e.RowIndex].Cells[3].Value);
                    lbl_available_qty.Text = prod.current_quantity.ToString();

                    products_inventory[prodName] = prod;


                    total_sales_price = total_sales_price - Convert.ToInt32(dgv_sales.Rows[e.RowIndex].Cells[5].Value);
                    final_price = total_sales_price;

                    txt_total_sales.Text = total_sales_price.ToString();
                    txt_final_total.Text = final_price.ToString();

                    if (total_sales_price == 0)
                    {
                        txt_paid_amount.Text = "0";
                        txt_rest.Text = "0";

                    }
                    if (txt_paid_amount.Text == final_price.ToString() && final_price != 0)
                    {

                        txt_final_total.Text = final_price.ToString();
                        txt_paid_amount.Text = final_price.ToString();

                    }

                    else
                    {
                        txt_final_total.Text = final_price.ToString();
                        txt_rest.Text = (final_price - Convert.ToDouble(txt_paid_amount.Text)).ToString();

                    }

                    dgv_sales.Rows.RemoveAt(e.RowIndex);

                }

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 6 && e.RowIndex >= 0)
                {

                    int quantity = Convert.ToInt32(dgv_sales.Rows[e.RowIndex].Cells[3].Value.ToString());
                    string productName = dgv_sales.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int prev_qty = quantities[e.RowIndex];
                    int new_qty = 0;

                    if (prev_qty < quantity)
                    {
                        if (prod.current_quantity > 0)
                        {
                            new_qty = quantity - prev_qty;

                            if (Convert.ToInt32(new_qty) <= prod.current_quantity)
                            {
                                prod.current_quantity -= new_qty;
                            }
                            else
                            {
                                alert = true;
                                MessageBox.Show(cmb_products.Text + "الكميه المتاحه في المخزن لا تكفي ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgv_sales.Rows[e.RowIndex].Cells[3].Value = prev_qty;
                            }
                        }
                        else
                        {
                            alert = true;
                            MessageBox.Show(cmb_products.Text + "لقد انتهي هذا الصنف من المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgv_sales.Rows[e.RowIndex].Cells[3].Value = prev_qty;

                        }

                    }

                    else if (prev_qty > quantity)
                    {

                        new_qty = prev_qty - quantity;
                        prod.current_quantity += new_qty;



                    }

                    if (alert == false)
                    {
                        quantities[e.RowIndex] = quantity;
                        // get_product_details(productName);

                        double edited_final_price = Convert.ToDouble(dgv_sales.Rows[e.RowIndex].Cells[3].Value) * Convert.ToInt32(dgv_sales.Rows[e.RowIndex].Cells[4].Value);
                        dgv_sales.Rows[e.RowIndex].Cells[5].Value = edited_final_price.ToString();
                        update_total_price(dgv_sales);
                        lbl_available_qty.Text = prod.current_quantity.ToString();

                        products_inventory[prodName] = prod;

                        //   final_price = total_sales_price;
                        txt_total_sales.Text = total_sales_price.ToString();
                        txt_final_total.Text = final_price.ToString();
                        //  txt_paid_amount.Text = total_sales_price.ToString();

                        if (total_sales_price == 0)
                        {
                            txt_paid_amount.Text = "0";
                            txt_rest.Text = "0";

                        }
                        if (txt_paid_amount.Text == final_price.ToString() && final_price != 0)
                        {

                            txt_final_total.Text = final_price.ToString();
                            txt_paid_amount.Text = final_price.ToString();

                        }

                        else
                        {
                            txt_final_total.Text = final_price.ToString();
                            txt_rest.Text = (final_price - Convert.ToDouble(txt_paid_amount.Text)).ToString();

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_bill_Click(object sender, EventArgs e)
        {
            int customer_ID = get_customer_ID(cmb_cust_name_search.Text);

            if (cmb_bill_type_search.Text == "اجل")
            {

                get_customer_credit(customer_ID);
                double new_credit = customer_credit - Convert.ToDouble(txt_left_search.Text);
                string query5 = "Update customers Set credit='" + new_credit
                               + "'where customer_ID ='" + customer_ID.ToString() + "'";
                Program.db.ExecuteNonQuery(query5);

            }
            Program.db.OpenConnection();
            string query = "Delete from sales_bill where bill_ID='" + cmb_bill_IDS.Text + "'";
            Program.db.ExecuteNonQuery(query);

            string query1 = "Delete from treasury where bill_id='" + cmb_bill_IDS.Text + "' and money_for='فاتوره مبيعات'";
            Program.db.ExecuteNonQuery(query1);




            Program.db.CloseConnection();



            cmb_bill_type_search.Text = "";
            cmb_cust_name_search.Text = "";
            dgv_sales_search.Rows.Clear();
            txt_disc_percent_search.Text = "";
            txt_final_search.Text = "";
            txt_paid_search.Text = "";
            txt_left_search.Text = "";
            txt_total_search.Text = "";
            cmb_bill_IDS.Text = "";
            Program.treasury_count();
            txt_treasury_search.Text = Program.treasury_amount.ToString();
            txt_treasuty_amount.Text = Program.treasury_amount.ToString();

            set_bill_ID();

        }

        private void txt_disc_percent_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_disc_percent.Text != "")
                {
                    double disc_percent = Convert.ToDouble(txt_disc_percent_search.Text);
                    double disc_value = total_sales_price * (disc_percent / 100.0);
                    ttxt_disc_amount_search.Text = disc_value.ToString();
                    final_price = total_sales_price - disc_value;
                    txt_final_search.Text = final_price.ToString();

                }
            }
        }

        private void ttxt_disc_amount_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ttxt_disc_amount_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_disc_value.Text != "")
                {
                    double disc_value = Convert.ToDouble(ttxt_disc_amount_search.Text);
                    double disc_percent = (disc_value / total_sales_price) * 100.0;
                    txt_disc_percent_search.Text = disc_percent.ToString();
                    final_price = total_sales_price - disc_value;
                    txt_final_search.Text = final_price.ToString();
                }
            }
        }

        private void txt_paid_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_paid_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_paid_amount.Text != "")
                {
                    double paid_money = Convert.ToDouble(txt_paid_search.Text);
                    double left_to_be_paid_later = final_price - paid_money;
                    txt_left_search.Text = left_to_be_paid_later.ToString();
                    paid_amount = paid_money;
                }
            }
        }

        private void btn_update_bill_Click(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
            string query = "Update sales_bill Set total_price='" + total_sales_price
                          + "', discount_amount='" + ttxt_disc_amount_search.Text
                          + "', final_price ='" + final_price
                          + "', paid_money ='" + paid_amount
                          + "', left_money ='" + rest_amount

                          + "'where bill_ID ='" + cmb_bill_IDS.Text + "'";
            Program.db.ExecuteNonQuery(query);


            for (int i = 0; i < dgv_sales_search.Rows.Count; i++)
            {
                // int returned_qty = Convert.ToInt32(dgv_sales.Rows[i].Cells[3].Value);
                string product_name = dgv_sales_search.Rows[i].Cells[2].Value.ToString();
                get_product_details(product_name);
                string prodName = dgv_sales_search.Rows[i].Cells[2].Value.ToString();
                Product_details prod = products_inventory[prodName];

                string query4 = "Update sales_bill_product Set product_quantity='" + dgv_sales_search.Rows[i].Cells[3].Value.ToString()
                              + "'where product_id ='" + prod.product_ID + "'and bill_id='" + dgv_sales_search.Rows[i].Cells[0].Value.ToString() + "'";
                Program.db.ExecuteNonQuery(query4);
                //   MessageBox.Show("تم تعديل البيانات");
                // quantities[i] = new_quantity;

            }

            for (int i = 0; i < dgv_sales_search.Rows.Count; i++)
            {
                //  int returned_qty = Convert.ToInt32(dgv_sales.Rows[i].Cells[3].Value);
                string product_name = dgv_sales_search.Rows[i].Cells[2].Value.ToString();
                int pro_new_qty = Convert.ToInt32(dgv_sales_search.Rows[i].Cells[3].Value.ToString());

                string prodName = dgv_sales_search.Rows[i].Cells[2].Value.ToString();
                Product_details prod = products_inventory[prodName];


                // get_product_details(product_name);
                string query4 = "";
                if (pro_new_qty != quantities[i])
                {
                    if (pro_new_qty > quantities[i])
                    {

                        int qty_removed_from_inventory = pro_new_qty - quantities[i];
                        query4 = "Update inventory Set quantity='" + (Convert.ToInt32(prod.avaliable_qty) - qty_removed_from_inventory).ToString()
                                     + "'where product_ID ='" + Convert.ToInt32(prod.product_ID) + "'";

                    }
                    else if (pro_new_qty < quantities[i])
                    {
                        int qty_back_to_inventory = quantities[i] - pro_new_qty;
                        query4 = "Update inventory Set quantity='" + (Convert.ToInt32(prod.avaliable_qty) + qty_back_to_inventory).ToString()
                                     + "'where product_ID ='" + Convert.ToInt32(prod.product_ID) + "'";


                    }
                    quantities[i] = pro_new_qty;

                    products_inventory[prodName] = prod; ;
                    Program.db.ExecuteNonQuery(query4);

                }
                //   MessageBox.Show("تم تعديل البيانات");


            }

            int customer_ID = get_customer_ID(cmb_cust_name_search.Text);

            double income_money = 0;
            if (cmb_bill_type_search.Text == "اجل")
            {
                get_customer_credit(customer_ID);
                income_money += Convert.ToDouble(txt_paid_search.Text);
                if (txt_paid_search.Text == txt_final_search.Text)
                {

                    double new_credit = customer_credit - rest_amount;
                    string query5 = "Update customers Set credit='" + new_credit
                                   + "'where customer_ID ='" + customer_ID.ToString() + "'";
                    Program.db.ExecuteNonQuery(query5);
                }
                else
                {
                    double new_credit = customer_credit - Convert.ToDouble(txt_left_search.Text);
                    string query5 = "Update customers Set credit='" + new_credit
                                   + "'where customer_ID ='" + customer_ID.ToString() + "'";
                    Program.db.ExecuteNonQuery(query5);
                }
            }

            else
            {
                income_money += Convert.ToDouble(txt_final_search.Text);


            }


            string query6 = "Update treasury Set money_amount='" + income_money
                        + "'where bill_id ='" + cmb_bill_IDS.Text + "' and money_for='فاتوره مبيعات'";
            Program.db.ExecuteNonQuery(query6);

            Program.db.CloseConnection();

            Program.treasury_count();
            txt_treasury_search.Text = Program.treasury_amount.ToString();


            MessageBox.Show("تم تعديل البيانات");

            cmb_bill_type_search.Text = "";
            cmb_cust_name_search.Text = "";
            dgv_sales_search.Rows.Clear();
            txt_disc_percent_search.Text = "";
            txt_final_search.Text = "";
            txt_paid_search.Text = "";
            txt_left_search.Text = "";
            txt_total_search.Text = "";
            cmb_bill_IDS.Text = "";
            //Program.treasury_count();
            //txt_treasury_search.Text = Program.treasury_amount.ToString();
            //txt_treasuty_amount.Text = Program.treasury_amount.ToString();


            load_products_inventory();

        }

        private void txt_bill_ID_seach_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cust_name_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmb_bill_IDS.Items.Clear();
            //int customer_ID = get_customer_ID(cmb_cust_name_search.Text);

            //Program.db.OpenConnection();
            //MySqlDataReader row;
            //string query = "select * from sales_bill where customer_id= '" + customer_ID + "'";
            //row = Program.db.ExecuteReader(query);
            //while (row.Read())
            //{
            //    cmb_bill_IDS.Items.Add(row["bill_ID"].ToString());


            //}
            //Program.db.close_reader();
            //Program.db.CloseConnection();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_sales_search_Enter(object sender, EventArgs e)
        {


        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

            Program.treasury_count();
            txt_treasury_search.Text = Program.treasury_amount.ToString();
            txt_treasuty_amount.Text = Program.treasury_amount.ToString();

           // load_customers();
        }

        private void cmb_customer_name_SelectedIndexChanged(object sender, EventArgs e)
        {
           // load_customers();
            int customer_ID = get_customer_ID(cmb_customer_name.Text);

            Program.db.OpenConnection();
            get_customer_credit(customer_ID);
            Program.db.CloseConnection();
        }


        private void dgv_sales_search_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            //{
            //    double edited_final_price = Convert.ToDouble(dgv_sales_search.Rows[e.RowIndex].Cells[3].Value) * Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[4].Value);
            //    dgv_sales_search.Rows[e.RowIndex].Cells[5].Value = edited_final_price.ToString();

            //}
        }

        private void txt_left_search_OnValueChanged(object sender, EventArgs e)
        {
            //rest_amount =Convert.ToDouble( txt_left_search.Text);
        }

        private void txt_rest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_rest.Text != "")
                {
                    double left_money = Convert.ToDouble(txt_rest.Text);
                    double paid_money = final_price - left_money;
                    txt_paid_amount.Text = paid_money.ToString();
                    paid_amount = paid_money;
                    rest_amount = left_money;
                }
            }
        }

        private void txt_left_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_left_search.Text != "")
                {
                    double left_money = Convert.ToDouble(txt_left_search.Text);
                    double paid_money = final_price - left_money;
                    txt_paid_search.Text = paid_money.ToString();
                    // rest_amount = left_money;
                }
            }
        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void txt_disc_percent_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_final_total_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_disc_value_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_paid_amount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cust_name_search_Click(object sender, EventArgs e)
        {
            //load_customers();
        }

        private void cmb_customer_name_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void rd_search_bydate_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_search_bydate.Checked == true)
            {
                dtp_search.Enabled = true;
                dtp_end.Enabled = true;
                cmb_cust_name_search.Enabled = false;
                cmb_bill_type_search.Enabled = false;
                cmb_bill_state.Enabled = false;

            }
        }

        private void rd_search_bucustomer_CheckedChanged(object sender, EventArgs e)
        {
            if(rd_search_bucustomer.Checked==true)
            {
                dtp_search.Enabled = false;
                dtp_end.Enabled = false;
                cmb_cust_name_search.Enabled = true;
                cmb_bill_type_search.Enabled = false;
                cmb_bill_state.Enabled = false;

            }
        }

        private void rd_search_bytype_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_search_bytype.Checked == true)
            {
                dtp_search.Enabled = false;
                dtp_end.Enabled = false;
                cmb_cust_name_search.Enabled = false;
                cmb_bill_type_search.Enabled = true;
                cmb_bill_state.Enabled = false;

            }
        }

        private void rd_billState_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_billState.Checked == true)
            {
                dtp_search.Enabled = false;
                dtp_end.Enabled = false;
                cmb_cust_name_search.Enabled = false;
                cmb_bill_type_search.Enabled = false;
                cmb_bill_state.Enabled = true;

            }
        }

        private void cmb_customer_name_MouseEnter(object sender, EventArgs e)
        {
            //load_customers();
            if (new_customer == true)
            {
                load_customers();
                new_customer = false;
            }
        }

        private void btn_save_print_Click(object sender, EventArgs e)
        {

           //  done = false;

            
            Add_Bill();
            if (done == true)
            {
                List<DataGridViewRow> bill_products = new List<DataGridViewRow>();
                foreach (DataGridViewRow item in dgv_sales.Rows)
                {
                    DataGridViewRow r = (DataGridViewRow)item.Clone();

                    for (int i = 0; i < item.Cells.Count - 2; i++)
                    {
                        r.Cells[i].Value = item.Cells[i].Value;
                    }
                    bill_products.Add(r);



                }

                InoviceForm f = new InoviceForm("فاتوره مبيعات", cmb_customer_name.Text, Convert.ToDateTime(dtp_bill_date.Value).ToString(), txt_total_sales.Text, txt_final_total.Text, txt_disc_percent.Text, txt_paid_amount.Text, txt_rest.Text, cmb_bill_type.Text, bill_products);
                 ///  f.ShowDialog();


                cmb_bill_type.Text = "";
                cmb_customer_name.Text = "";
                cmb_price_tybe.Text = "";
                cmb_products.Text = "";
                cmb_product_category.Text = "";
                txt_disc_value.Text = "";
                txt_disc_percent.Text = "";
                txt_customer_credit.Text = "";
                txt_final_total.Text = "";
                txt_paid_amount.Text = "";
                txt_p_code.Text = "";
                txt_total_sales.Text = "";
                txt_rest.Text = "";
                txt_quantity.Text = "";
                txt_product_price.Text = "";
                dgv_sales.Rows.Clear();
                lbl_available_qty.Text = "0";
                lbl_available_qty.Visible = false;
                lbl_qtyavaliable_name.Visible = false;
                done = false;
            }
        }

        private void cmb_customer_name_Click(object sender, EventArgs e)
        {
           
        }

        private void cmb_product_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_products(cmb_product_category.Text);
        }

      

        private void cmb_bill_type_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void cmb_products_SelectedIndexChanged(object sender, EventArgs e)
        {

            get_product_data(cmb_products.Text);

            lbl_available_qty.Visible = true;
            lbl_qtyavaliable_name.Visible = true;

            // Program.db.OpenConnection();

            // get_product_details(cmb_products.Text);
            // Program.db.CloseConnection();

        }

        public void get_product_data(string prod_name)
        {

            lbl_available_qty.BackColor = Color.Transparent;

            if (products_inventory.ContainsKey(prod_name))
            {
                Product_details prod = products_inventory[prod_name];


                txt_p_code.Text = prod.product_code;

                txt_product_price.Text = prod.product_selling_price;
                cmb_price_tybe.Text = "عادي";
                if (Convert.ToInt32(prod.current_quantity) <= prod.alert_quantity)
                {
                    MessageBox.Show(product_name + " : لقد وصلت للحد الادني من الكميه للصنف ", "تنبيه",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lbl_available_qty.BackColor = Color.Red;
                }
                lbl_available_qty.Text = prod.current_quantity.ToString();
            }
            else
            {
                MessageBox.Show("بيانات الصنف غير متوفره");
            }
        }
        public void get_product_details(string product_name)
        {

            //   try
            // {

            MySqlDataReader row;
            string query = "select product.description,product.product_quantity, product.product_name,product.product_ID,product.selling_price,product.discounted_price,inventory.quantity,product.product_code,product.p_group_id" +
                " from product INNER join inventory on product.product_ID=inventory.product_ID where product_name = '" + product_name + "'";
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                product_ID = row["product_ID"].ToString();
                product_name = row["product_name"].ToString();
                product_selling_price = row["selling_price"].ToString();
                product_code = row["product_ID"].ToString();
                product_discounted_price = row["discounted_price"].ToString();
                product_grp = row["p_group_id"].ToString();
                product_desc = row["description"].ToString();
                avaliable_qty = Convert.ToInt32(row["quantity"].ToString());
                lbl_available_qty.Text = avaliable_qty.ToString();

                if (Convert.ToInt32(avaliable_qty) <= Convert.ToInt32(row["product_quantity"].ToString()))
                {
                    MessageBox.Show(product_name + " : لقد وصلت للحد الادني من الكميه للصنف ", "تنبيه",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            row.Close();


            //  Program.db.close_reader();
            //}
            // catch (Exception ex)
            // {
            //    MessageBox.Show(ex.ToString());
            // }
        }

        public static int get_customer_ID(string customer_name)
        {
            int cust_iD = 0;
            cust_iD = customers_sales[customer_name];
            return cust_iD;
        }
        public void load_products(string group_name)
        {
            try
            {
                cmb_products.Text = "";
                cmb_products.Items.Clear();
                Program.db.OpenConnection();
                int group_ID = get_product_group_ID(group_name);
                //  string query = "SELECT product_name ,product.product_ID from product INNER join inventory on product.product_ID=inventory.product_ID where product.p_group_id= '" + group_ID.ToString() + "'";
                //MySqlDataReader row;
                //row = Program.db.ExecuteReader(query);
                //while (row.Read())
                //{

                //    cmb_products.Items.Add(row["product_name"].ToString());


                //}
                //Program.db.close_reader();
                foreach (var kvp in products_inventory)
                { // Could also do KeyValuePair<int, FrmData> instead of var
                    if (Convert.ToInt32(kvp.Value.product_grp) == group_ID)
                    {
                        string productName = kvp.Key;
                        cmb_products.Items.Add(productName);
                        // Do something with the key
                    }
                }

                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void load_customers()
        {


            try
            {
                customers_sales.Clear();
                cmb_customer_name.Items.Clear();
                cmb_cust_name_search.Items.Clear();
                Program.db.OpenConnection();
                string query = "SELECT customer_name ,customer_ID FROM customers where customer_type= 'عميل'";
                MySqlDataReader row;
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {

                    cmb_customer_name.Items.Add(row["customer_name"].ToString());
                    cmb_cust_name_search.Items.Add(row["customer_name"].ToString());

                    customers_sales.Add(row["customer_name"].ToString(), Convert.ToInt32(row["customer_ID"]));
                }
                Program.db.close_reader();
                Program.db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        public void load_product_groups()
        {



            try
            {
                product_groups.Clear();
                cmb_product_category.Items.Clear();

                Program.db.OpenConnection();
                MySqlDataReader row;
                string query = "select * from product_group ";
                row = Program.db.ExecuteReader(query);
                while (row.Read())
                {
                    cmb_product_category.Items.Add(row[1].ToString());


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

        public int get_product_group_ID(string category_name)
        {
            int cat_ID = 0;
            cat_ID = product_groups[category_name];
            return cat_ID;
        }

        public void get_customer_credit(int customer_ID)
        {
            //               Program.db.OpenConnection();
            string query = "SELECT credit FROM customers where customer_type= 'عميل' and customer_ID='" + customer_ID + "'";
            MySqlDataReader row;
            row = Program.db.ExecuteReader(query);
            while (row.Read())
            {
                string cred = row[0].ToString();
                if (cred == "")
                    cred = "0";
                customer_credit = Convert.ToDouble(cred);
                txt_customer_credit.Text = row[0].ToString();
            }
            row.Close();
            //  Program.db.CloseConnection();
        }

    }
}
