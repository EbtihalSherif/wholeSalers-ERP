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
    public partial class form_bill_details : Form
    {

        public int Bill_ID;
        public string customer_name, Bill_type;
        List<int> quantities = new List<int>();

        string product_ID, product_name, product_grp, product_code, product_selling_price, product_discounted_price, product_desc;
        int avaliable_qty, current_qty;
        int new_quantity, previous_quantity, returned_qty;
        int new_bill_ID, old_bill_ID;
        double customer_credit = 0;
        double total_sales_price, final_price, paid_amount, rest_amount;
        public form_bill_details()
        {
            InitializeComponent();
        }

        public form_bill_details(int bill_ID, string cust_name, string bill_type)
        {
            InitializeComponent();
            Bill_ID = bill_ID;
            customer_name = cust_name;
            Bill_type = bill_type;

            if (Bill_type == "نقدي")
            {
                txt_paid_search.Enabled = false;
                txt_left_search.Enabled = false;
            }
            load_bill_details();
        }

        private void form_bill_details_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel21_Click(object sender, EventArgs e)
        {

        }

        private void txt_left_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel26_Click(object sender, EventArgs e)
        {

        }

        private void ttxt_disc_amount_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ttxt_disc_amount_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (txt_disc_amount_search.Text != "")
                    {
                        double disc_value = Convert.ToDouble(txt_disc_amount_search.Text);
                        double disc_percent = (disc_value / total_sales_price) * 100.0;
                        txt_disc_percent_search.Text = Math.Floor(disc_percent).ToString();
                        if (txt_paid_search.Text == final_price.ToString())
                        {

                            final_price = total_sales_price - disc_value;
                            txt_final_search.Text = final_price.ToString();
                            txt_paid_search.Text = final_price.ToString();
                            paid_amount = final_price;
                        }
                        else
                        {
                            final_price = total_sales_price - disc_value;
                            txt_final_search.Text = final_price.ToString();
                            txt_left_search.Text = (final_price - Convert.ToDouble(txt_paid_search.Text)).ToString();
                            rest_amount = final_price - Convert.ToDouble(txt_paid_search.Text);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void txt_disc_percent_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                double pre = 0;
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txt_disc_percent_search.Text != "")
                    {
                        double disc_percent = Convert.ToDouble(txt_disc_percent_search.Text);
                        double disc_value = total_sales_price * (disc_percent / 100.0);
                        txt_disc_amount_search.Text = disc_value.ToString();
                        if (txt_paid_search.Text == final_price.ToString())
                        {

                            final_price = total_sales_price - disc_value;
                            txt_final_search.Text = final_price.ToString();
                            txt_paid_search.Text = final_price.ToString();
                            paid_amount = final_price;
                        }
                        else
                        {
                            final_price = total_sales_price - disc_value;
                            txt_final_search.Text = final_price.ToString();
                            txt_left_search.Text = (final_price - Convert.ToDouble(txt_paid_search.Text)).ToString();
                            rest_amount = final_price - Convert.ToDouble(txt_paid_search.Text);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void txt_paid_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (txt_paid_search.Text != "")
                    {
                        double paid_money = Convert.ToDouble(txt_paid_search.Text);
                        double left_to_be_paid_later = final_price - paid_money;
                        txt_left_search.Text = left_to_be_paid_later.ToString();
                        //  paid_amount = paid_money;
                        //  rest_amount = left_to_be_paid_later;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void txt_left_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (txt_left_search.Text != "")
                    {
                        double left_money = Convert.ToDouble(txt_left_search.Text);
                        double paid_money = final_price - left_money;
                        txt_paid_search.Text = paid_money.ToString();
                        //   paid_amount = paid_money;
                        //   rest_amount = left_money;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بشكل صحيح");
            }
        }

        private void bunifuCustomLabel27_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel28_Click(object sender, EventArgs e)
        {

        }

        private void txt_final_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel29_Click(object sender, EventArgs e)
        {

        }

        private void txt_disc_percent_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel30_Click(object sender, EventArgs e)
        {

        }

        private void txt_paid_search_OnValueChanged(object sender, EventArgs e)
        {

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
            }
            row.Close();
            //  Program.db.CloseConnection();
        }
        private void btn_update_bill_Click(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
            string query = "Update sales_bill Set total_price='" + total_sales_price
                          + "', discount_amount='" + txt_disc_amount_search.Text
                          + "', final_price ='" + final_price
                          + "', paid_money ='" + txt_paid_search.Text
                          + "', left_money ='" + txt_left_search.Text

                          + "'where bill_ID ='" + Bill_ID + "'";
            Program.db.ExecuteNonQuery(query);


            for (int i = 0; i < dgv_sales_search.Rows.Count; i++)
            {
                // int returned_qty = Convert.ToInt32(dgv_sales.Rows[i].Cells[3].Value);
                string product_name = dgv_sales_search.Rows[i].Cells[2].Value.ToString();
                // get_product_details(product_name);
                string prodName = dgv_sales_search.Rows[i].Cells[2].Value.ToString();
                Product_details prod = salesusercontrol.products_inventory[prodName];

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
                Product_details prod = salesusercontrol.products_inventory[prodName];


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

                    salesusercontrol.products_inventory[prodName] = prod; ;
                    Program.db.ExecuteNonQuery(query4);

                }
                //   MessageBox.Show("تم تعديل البيانات");


            }

            int customer_ID = salesusercontrol.get_customer_ID(customer_name);

            double income_money = 0;
            if (Bill_type == "اجل")
            {
                get_customer_credit(customer_ID);

                income_money = Convert.ToDouble(txt_paid_search.Text);

                double temp_credit = Convert.ToDouble(txt_left_search.Text);
                customer_credit -= rest_amount;
                customer_credit += temp_credit;


                rest_amount = Convert.ToDouble(txt_left_search.Text);
                paid_amount = Convert.ToDouble(txt_paid_search.Text);

                string query5 = "Update customers Set credit='" + customer_credit
                                   + "'where customer_ID ='" + customer_ID.ToString() + "'";
                Program.db.ExecuteNonQuery(query5);
                // income_money += Convert.ToDouble(txt_paid_search.Text);

                //if (txt_paid_search.Text == txt_final_search.Text)
                //{
                //    double current_credit = income_money - paid_amount;
                //    double new_credit = customer_credit - current_credit;
                //    string query5 = "Update customers Set credit='" + new_credit
                //                   + "'where customer_ID ='" + customer_ID.ToString() + "'";
                //    Program.db.ExecuteNonQuery(query5);
                //}
                //else if(rest_amount<Convert.ToDouble(txt_left_search.Text) )
                //{
                //    double new_credit = customer_credit - Convert.ToDouble(txt_left_search.Text);
                //    string query5 = "Update customers Set credit='" + new_credit
                //                   + "'where customer_ID ='" + customer_ID.ToString() + "'";
                //    Program.db.ExecuteNonQuery(query5);
                //}
            }

            else
            {
                income_money += Convert.ToDouble(txt_final_search.Text);


            }


            string query6 = "Update treasury Set money_amount='" + income_money
                        + "'where bill_id ='" + Bill_ID + "' and money_for='فاتوره مبيعات'";
            Program.db.ExecuteNonQuery(query6);

            Program.db.CloseConnection();

            Program.treasury_count();


            MessageBox.Show("تم تعديل البيانات");

            //dgv_sales_search.Rows.Clear();
            //txt_disc_percent_search.Text = "";
            //txt_final_search.Text = "";
            //txt_paid_search.Text = "";
            //txt_left_search.Text = "";
            //txt_total_search.Text = "";
            //Program.treasury_count();
            //txt_treasury_search.Text = Program.treasury_amount.ToString();
            //txt_treasuty_amount.Text = Program.treasury_amount.ToString();


            salesusercontrol.load_products_inventory();

        }

        private void btn_delete_bill_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int customer_ID = salesusercontrol.get_customer_ID(customer_name);

                if (Bill_type == "اجل")
                {

                    get_customer_credit(customer_ID);
                    double new_credit = customer_credit - Convert.ToDouble(txt_left_search.Text);
                    string query5 = "Update customers Set credit='" + new_credit
                                   + "'where customer_ID ='" + customer_ID.ToString() + "'";
                    Program.db.ExecuteNonQuery(query5);

                }
                Program.db.OpenConnection();
                string query = "Delete from sales_bill where bill_ID='" + Bill_ID + "'";
                Program.db.ExecuteNonQuery(query);

                string query1 = "Delete from treasury where bill_id='" + Bill_ID + "' and money_for='فاتوره مبيعات'";
                Program.db.ExecuteNonQuery(query1);




                Program.db.CloseConnection();




                dgv_sales_search.Rows.Clear();
                txt_disc_percent_search.Text = "";
                txt_final_search.Text = "";
                txt_paid_search.Text = "";
                txt_left_search.Text = "";
                txt_total_search.Text = "";
                Program.treasury_count();

                this.Close();
            }

        }

        private void dgv_sales_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            var senderGrid = (DataGridView)sender;



            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7 && e.RowIndex >= 0)
            {

                string box_msg = " هل تريد التأكيد علي عمليه المرتجعات";

                string box_title = "تحذير ";

                var selected = MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo);

                if (selected == DialogResult.Yes)
                {
                    int returned_before = 0, avaliable_to_return = 0;
                    Program.db.OpenConnection();
                    string prodName = dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString();

                    if (salesusercontrol.products_inventory.ContainsKey(prodName))
                    {
                        Product_details prod = salesusercontrol.products_inventory[prodName];
                        MySqlDataReader reader;

                        string query_returned_before = "SELECT SUM(product_quantity) FROM returned where bill_id= '" + Bill_ID
                            + "'and product_ID= '" + prod.product_ID + "' and returned_type	='مبيعات'";
                        reader = Program.db.ExecuteReader(query_returned_before);
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader[0].ToString() != "")
                                    returned_before += Convert.ToInt32(reader[0].ToString());
                            }
                        }
                        reader.Close();

                        avaliable_to_return = quantities[e.RowIndex] - returned_before;


                        string returned_type = "مبيعات";
                        string quantity = dgv_sales_search.Rows[e.RowIndex].Cells[3].Value.ToString();

                        if (avaliable_to_return >= Convert.ToInt32(quantity))

                        {

                            string price = dgv_sales_search.Rows[e.RowIndex].Cells[4].Value.ToString();
                            string total_price_returned = (Convert.ToInt32(quantity) * Convert.ToDouble(price)).ToString();

                            if (txt_disc_amount_search.Text != " " || txt_disc_amount_search.Text != "0")
                            {

                                double temp = Convert.ToDouble(total_price_returned);
                                temp -= Convert.ToDouble(txt_disc_amount_search.Text);
                                total_price_returned = temp.ToString();
                            }
                            int customer_ID = salesusercontrol.get_customer_ID(customer_name);

                            //  get_product_details(dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString());

                            string bill_ID = dgv_sales_search.Rows[e.RowIndex].Cells[0].Value.ToString();

                            string query3 = "Insert INTO returned (product_ID,product_quantity ,customer_ID ,date,price,returned_type,total_price,bill_id) " +
                            "Values ('" + prod.product_ID + "' , '" + quantity + "', '" + customer_ID + "', '"
                            + Convert.ToDateTime(DateTime.UtcNow.ToString("yyyy-MM-dd h:mm:ss tt"))
                                 + "', '" + price + "', '" + returned_type + "', '" + total_price_returned + "', '" + bill_ID + "'); ";
                            Program.db.ExecuteNonQuery(query3);

                            returned_qty = Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[3].Value.ToString());

                            prod.avaliable_qty += returned_qty;

                            string query4 = "Update inventory Set quantity='" + prod.avaliable_qty
                                              + "'where product_ID ='" + prod.product_ID + "'";
                            Program.db.ExecuteNonQuery(query4);


                            salesusercontrol.products_inventory[prodName] = prod;


                            if (Bill_type == "اجل")
                            {

                                if (Convert.ToDouble(total_price_returned) <= rest_amount)
                                {
                                    rest_amount -= Convert.ToDouble(total_price_returned);

                                    string query = "Update sales_bill Set left_money='" + rest_amount
                                                 + "'where bill_ID ='" + Bill_ID + "'";
                                    Program.db.ExecuteNonQuery(query);

                                }

                                else if (Convert.ToDouble(total_price_returned) > rest_amount && Convert.ToDouble(total_price_returned) <= final_price)
                                {
                                    double giveTo = Convert.ToDouble(total_price_returned) - rest_amount;
                                    paid_amount -= giveTo;
                                    rest_amount = 0;
                                    Program.treasury_amount -= giveTo;
                                    string query6 = "Insert INTO treasury(date,operation_type,money_amount,money_for,notes,operator_ID,operator_type,bill_id ) " +
                                       "Values ('" + Convert.ToDateTime(DateTime.UtcNow.ToString("yyyy-MM-dd h:mm:ss tt"))
                                              + "' , '" + "صرف خارجي" + "', '" + giveTo + "', '" +
                                       "فاتوره مرتجعات" + "', '" + " " + "', '" + customer_name + "', '" + "عميل" + "', '" + Bill_ID + "'); ";

                                    Program.db.ExecuteNonQuery(query6);



                                    string query = "Update sales_bill Set left_money='" + rest_amount

                                                //   + "', paid_money ='" + paid_amount
                                                + "'where bill_ID ='" + Bill_ID + "'";
                                    Program.db.ExecuteNonQuery(query);


                                }
                                txt_left_search.Text = rest_amount.ToString();
                                //txt_paid_search.Text = paid_amount.ToString();




                            }

                            else if (Bill_type == "نقدي")
                            {
                                Program.treasury_amount -= Convert.ToDouble(total_price_returned);
                                string query6 = "Insert INTO treasury(date,operation_type,money_amount,money_for,notes,operator_ID,operator_type,bill_id ) " +
                                   "Values ('" + Convert.ToDateTime(DateTime.UtcNow.ToString("yyyy-MM-dd h:mm:ss tt"))
                                          + "' , '" + "صرف خارجي" + "', '" + total_price_returned + "', '" +
                                   "فاتوره مرتجعات" + "', '" + " " + "', '" + customer_name + "', '" + "عميل" + "', '" + Bill_ID + "'); ";

                                Program.db.ExecuteNonQuery(query6);
                            }


                            //previous_quantity = quantities[e.RowIndex];
                            //new_quantity = previous_quantity - returned_qty;

                            //total_sales_price = total_sales_price - Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[5].Value);


                            //quantities[e.RowIndex] = new_quantity;

                            //dgv_sales_search.Rows[e.RowIndex].Cells[3].Value = new_quantity.ToString();
                            //dgv_sales_search.Rows[e.RowIndex].Cells[5].Value = (new_quantity * Convert.ToDouble(dgv_sales_search.Rows[e.RowIndex].Cells[4].Value)).ToString();

                            txt_disc_amount_search.Text = (total_sales_price * (Convert.ToDouble(txt_disc_percent_search.Text) / 100.0)).ToString();
                            final_price = total_sales_price - Convert.ToDouble(txt_disc_amount_search.Text);

                            txt_total_search.Text = total_sales_price.ToString();
                            txt_final_search.Text = final_price.ToString();

                        }
                        else
                        {

                            MessageBox.Show("عفوا ! الكميه التي نحاول ارجاعها اكثر من المتاح ارجاعه من الفاتوره");
                        }
                        Program.db.CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("عفوا ! بيانات هذا الصنف غير متوفره");


                    }
                }
                else
                {

                    load_bill_details();

                }
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                string prodName = dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (salesusercontrol.products_inventory.ContainsKey(prodName))
                {
                    bool alert = false;

                    Product_details prod = salesusercontrol.products_inventory[prodName];
                    double edited_final_price = Convert.ToDouble(dgv_sales_search.Rows[e.RowIndex].Cells[3].Value) * Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[4].Value);

                    dgv_sales_search.Rows[e.RowIndex].Cells[5].Value = edited_final_price.ToString();
                    update_total_price(dgv_sales_search);

                    int quantity = Convert.ToInt32(dgv_sales_search.Rows[e.RowIndex].Cells[3].Value.ToString());
                    string productName = dgv_sales_search.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                                MessageBox.Show("الكميه المتاحه في المخزن لا تكفي ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgv_sales_search.Rows[e.RowIndex].Cells[3].Value = prev_qty;
                            }
                        }
                        else
                        {
                            alert = true;
                            MessageBox.Show("لقد انتهي هذا الصنف من المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgv_sales_search.Rows[e.RowIndex].Cells[3].Value = prev_qty;

                        }

                    }

                    else if (prev_qty > quantity)
                    {

                        new_qty = prev_qty - quantity;
                        prod.current_quantity += new_qty;



                    }

                    if (alert == false)
                    {
                        //  quantities[e.RowIndex] = quantity;
                        // get_product_details(productName);

                        dgv_sales_search.Rows[e.RowIndex].Cells[5].Value = edited_final_price.ToString();
                        update_total_price(dgv_sales_search);
                        //lbl_available_qty.Text = prod.current_quantity.ToString();

                        salesusercontrol.products_inventory[prodName] = prod;
                        final_price = total_sales_price;
                        txt_total_search.Text = total_sales_price.ToString();
                        txt_final_search.Text = final_price.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("عفوا ! بيانات هذا الصنف غير متوفره");


                }

            }



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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
        public void load_bill_details()

        {
            dgv_sales_search.Rows.Clear();
            Program.db.OpenConnection();
            quantities.Clear();

            lbl_bill_type.Text = Bill_type;

            int customer_ID = salesusercontrol.get_customer_ID(customer_name);
            MySqlDataReader reader;
            string query1 = " select product.product_name, customers.customer_name, sales_bill_product.bill_id,sales_bill_product.product_id,sales_bill_product.product_quantity,sales_bill_product.product_price from sales_bill inner JOIN sales_bill_product on sales_bill.bill_ID=sales_bill_product.bill_id " +
                "inner join customers on customers.customer_ID=sales_bill.customer_id  INNER join product on sales_bill_product.product_id = product.product_ID  " +
                "where sales_bill.bill_ID = '" + Bill_ID + "'" +
                " AND sales_bill.bill_type = '" + Bill_type + "' " +
                // "AND sales_bill.bill_date = '" + Convert.ToDateTime(dtp_search.Value).ToString("yyyy-MM-dd") + "'" +
                "AND sales_bill.customer_id = '" + customer_ID +
                "'";
            reader = Program.db.ExecuteReader(query1);
            while (reader.Read())
            {

                int rowId = dgv_sales_search.Rows.Add();
                DataGridViewRow roww = dgv_sales_search.Rows[rowId];
                // cmb.Items.Add(row["customer_name"].ToString());
                roww.Cells[0].Value = reader["bill_id"].ToString();
                roww.Cells[1].Value = reader["customer_name"].ToString();
                roww.Cells[2].Value = reader["product_name"].ToString();
                roww.Cells[3].Value = reader["product_quantity"].ToString();
                quantities.Add(Convert.ToInt32(reader["product_quantity"].ToString()));
                roww.Cells[4].Value = reader["product_price"].ToString();
                double total_price = Convert.ToDouble(roww.Cells[3].Value) * Convert.ToDouble(roww.Cells[4].Value);
                roww.Cells[5].Value = total_price.ToString();

            }
            reader.Close();

            MySqlDataReader row;

            string query = " select * from sales_bill " +
                "where bill_ID = '" + Bill_ID + "'" +
                " AND bill_type = '" + Bill_type + "' " +
                // "AND bill_date = '" + Convert.ToDateTime(dtp_search.Value).ToString("yyyy-MM-dd ") + "' " +
                "AND customer_id = '" + customer_ID + "'";
            row = Program.db.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    txt_total_search.Text = row["total_price"].ToString();
                    txt_left_search.Text = row["left_money"].ToString();
                    txt_paid_search.Text = row["paid_money"].ToString();
                    txt_final_search.Text = row["final_price"].ToString();
                    txt_disc_amount_search.Text = row["discount_amount"].ToString();
                    double disc_value = Convert.ToDouble(txt_disc_amount_search.Text);
                    double disc_percent = (disc_value / Convert.ToDouble(txt_total_search.Text)) * 100.0;
                    txt_disc_percent_search.Text = disc_percent.ToString();

                    total_sales_price = Convert.ToDouble(txt_total_search.Text);
                    final_price = Convert.ToDouble(txt_final_search.Text);
                    paid_amount = Convert.ToDouble(txt_paid_search.Text);
                    rest_amount = Convert.ToDouble(txt_left_search.Text);

                }
            }

            Program.db.CloseConnection();

        }

        public void get_product_data_from_inven(string product_name)
        {


        }
    }
}
