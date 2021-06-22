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
    public partial class purchased_bill_details : Form
    {
        public purchased_bill_details()
        {
            InitializeComponent();
        }

        private void purchased_bill_details_Load(object sender, EventArgs e)
        {
            
            reports_usercontrol rep_uc = new reports_usercontrol();
            Program.db.OpenConnection();
            if (Program.bill_type=="مشتريات")
            {
               // MessageBox.Show(reports_usercontrol.bill_id);
                string query = "select purchased_bill_product.bill_ID ,purchased_bill_product.product_quantity,purchased_bill_product.product_price," +
                "product.product_name FROM purchased_bill_product INNER JOIN product ON purchased_bill_product.product_ID=product.product_ID where " +
                "purchased_bill_product.bill_ID='" + reports_usercontrol.bill_id + "'";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {
                    int rowId = dgv_bills_details.Rows.Add();
                    DataGridViewRow roww = dgv_bills_details.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_ID"].ToString();
                    roww.Cells[1].Value = dr["product_name"].ToString();
                    roww.Cells[2].Value = dr["product_quantity"].ToString();
                    roww.Cells[3].Value = dr["product_price"].ToString();
                }
                dr.Close();
                Program.db.CloseConnection();
            }
            else if(Program.bill_type== "مبيعات")
            {
                string query = "select sales_bill_product.bill_id ,sales_bill_product.product_quantity,sales_bill_product.product_price," +
               "product.product_name FROM sales_bill_product INNER JOIN product ON sales_bill_product.product_ID=product.product_ID where " +
               "sales_bill_product.bill_id='" + reports_usercontrol.bill_id + "'";
                MySqlDataReader dr = Program.db.ExecuteReader(query);
                while (dr.Read())
                {
                    int rowId = dgv_bills_details.Rows.Add();
                    DataGridViewRow roww = dgv_bills_details.Rows[rowId];
                    roww.Cells[0].Value = dr["bill_id"].ToString();
                    roww.Cells[1].Value = dr["product_name"].ToString();
                    roww.Cells[2].Value = dr["product_quantity"].ToString();
                    roww.Cells[3].Value = dr["product_price"].ToString();
                }
                dr.Close();
                Program.db.CloseConnection();
            }
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.db.CloseConnection();
        }
    }
}
