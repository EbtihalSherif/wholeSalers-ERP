using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace wholesaler_ERP
{
    public partial class Excel_info : Form
    {
        public Excel_info()
        {
            InitializeComponent();
        }

        private void browseExelBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select File";
            fd.FileName = ExelPathTXT.Text;
            fd.Filter = "Excel Sheet (*.xls)|*.xls|All Files(*.*)|*.*";
            fd.FilterIndex = 1;
            fd.RestoreDirectory = true;
            if(fd.ShowDialog()==DialogResult.OK)
            {
                ExelPathTXT.Text = fd.FileName;
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ExelPathTXT.Text != "")
            {
                try
                {
                    OleDbConnection con = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + ExelPathTXT.Text + "';  Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1\"");
                    con.Open();
                    OleDbDataAdapter sda = new OleDbDataAdapter("select * from [Sheet1$]", con);
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    this.dgv_excel.DataSource = dt.DefaultView;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("برجاء اختيار الملف");
            }
            }

        private void Excel_info_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_add_to_db_Click(object sender, EventArgs e)
        {
            Program.db.OpenConnection();
            for (int i = 0; i < dgv_excel.Rows.Count ; i++)
            {
                if (i > 0)
                {
                    //string query1 = "select product_ID from product where product_name='" + dgv_excel.Rows[i].Cells[0].Value.ToString() + "'";
                    string query2 = "select p_group_ID from product_group where p_group_name='" + dgv_excel.Rows[i].Cells[2].Value.ToString() + "'";
                    // string product_ID = "";
                    string product_group_ID = "";
                    //MySqlDataReader dr = Program.db.ExecuteReader(query1);
                    //if (dr.Read())
                    //{
                    //    product_ID = dr.GetString(0);
                    //}
                    //dr.Close();
                    MySqlDataReader dr2 = Program.db.ExecuteReader(query2);
                    if (dr2.Read())
                    {
                        product_group_ID = dr2.GetString(0);
                    }
                    dr2.Close();
                    string query3 = "Insert Into product(product_name,product_code,purchase_price,selling_price,discounted_price,product_quantity,p_group_id,description) Values( '" + dgv_excel.Rows[i].Cells[0].Value.ToString() + "', '" + dgv_excel.Rows[i].Cells[1].Value.ToString() + "','" + dgv_excel.Rows[i].Cells[3].Value.ToString() + "','" + dgv_excel.Rows[i].Cells[4].Value.ToString() + "','" + dgv_excel.Rows[i].Cells[6].Value.ToString() + "','" + dgv_excel.Rows[i].Cells[5].Value.ToString() + "','" + product_group_ID + "','" + dgv_excel.Rows[i].Cells[7].Value.ToString() + "');";
                    Program.db.ExecuteNonQuery(query3);

                }
                else
                {
                    continue;
                }
            }
            MessageBox.Show("تم ادخال البيانات");

            Program.db.CloseConnection();

        }

        private void ExelPathTXT_MouseHover(object sender, EventArgs e)
        {
            ExelPathTXT.Text = "";
        }
    }
    }

