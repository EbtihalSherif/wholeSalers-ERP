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
    public partial class InoviceForm : Form
    {

        string Customer_name = "";
        public InoviceForm(string bill,string customer_name, string date, string total, string final, string disc, string paid, string rest, string bill_type, List<DataGridViewRow> list)
        {
            InitializeComponent();
            lblCompany.Text = bill;
            lblDate.Text = date;
            Customer_name = customer_name;
            foreach (DataGridViewRow r in list)
            {
                ListViewItem l_item = new ListViewItem();

                l_item.Text = r.Cells[2].Value.ToString();
                // l_item.SubItems.Add(r.Cells[2].Value.ToString());
                l_item.SubItems.Add(r.Cells[3].Value.ToString());
                l_item.SubItems.Add(r.Cells[4].Value.ToString());
                l_item.SubItems.Add(r.Cells[5].Value.ToString());
                //   l_item.SubItems.Add(r.Cells["Total Price"].Value.ToString());

                listView1.Items.Add(l_item);
            }

            lblCustInf.Text ="اسم العميل :"+ customer_name ;
            if(bill_type == "نقدي")
             {
                lblShip.Text = "خصم :" + disc + "\n" + 
                               "نوع الفاتوره :"+bill_type + "\n" + "اجمالي الفاتوره:" + total + "\n";
                lbl_Total.Text = final;
              }
            else if (bill_type == "اجل")
            {
                lblShip.Text = "خصم :" + disc + "\n" + 
                    "نوع الفاتوره :" + bill_type + "\n" +
                    "اجمالي الفاتوره:" + total + "\n" +"المدفوع :"+paid+"\n"
                    +"المتبقي:"+rest;
                lbl_Total.Text = paid;
                label2.Text = ": المدفوع";
            }


            System.Drawing.Printing.PrintDocument myPrintDocument2 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog2 = new PrintDialog();
            myPrintDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument1_PrintPage);
            myPrinDialog2.Document = myPrintDocument2;

            if (myPrinDialog2.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument2.Print();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
        private void myPrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            Bitmap myBitmap2 = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
          //  this.PnlInvoice.DrawToBitmap(myBitmap2, e.PageBounds);

             this.PnlInvoice.DrawToBitmap(myBitmap2, new Rectangle(0, 0, myBitmap2.Width, myBitmap2.Height));
            e.Graphics.DrawImage(myBitmap2, 0, 0);
            myBitmap2.Dispose();
        }

       
        private void InoviceForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument myPrintDocument2 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog2 = new PrintDialog();
            myPrintDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument1_PrintPage);
            myPrinDialog2.Document = myPrintDocument2;
            
            if (myPrinDialog2.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument2.Print();
            }


            //using (var bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height))
            //{
            //    this.PnlInvoice.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
              
            //    //  System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Resources\Invoices\");
            //    //  bitmap.Save(Application.StartupPath + @"\Resources\Invoices\" + Customer_name+ ".png");

            //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //    saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            //    saveFileDialog1.Title = "Save an Image File";
            //    saveFileDialog1.ShowDialog();

            //    // If the file name is not an empty string open it for saving.
            //    if (saveFileDialog1.FileName != "")
            //    {
            //        // Saves the Image via a FileStream created by the OpenFile method.
            //        System.IO.FileStream fs =
            //            (System.IO.FileStream)saveFileDialog1.OpenFile();
            //        // Saves the Image in the appropriate ImageFormat based upon the
            //        // File type selected in the dialog box.
            //        // NOTE that the FilterIndex property is one-based.
            //        switch (saveFileDialog1.FilterIndex)
            //        {
            //            case 1:
            //                bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);

            //                //  this.button2.Image.Save(fs,
            //                //  System.Drawing.Imaging.ImageFormat.Jpeg);
            //                break;

            //            case 2:
            //                bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);

            //                // this.button2.Image.Save(fs,
            //                // System.Drawing.Imaging.ImageFormat.Bmp);
            //                break;

            //            case 3:
            //                bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);

            //                //  this.button2.Image.Save(fs,
            //                //  System.Drawing.Imaging.ImageFormat.Gif);
            //                break;
            //        }

            //        fs.Close();
            //    }
            //}
        }

        private void lblCompany_Click(object sender, EventArgs e)
        {

        }

        private void lblShip_Click(object sender, EventArgs e)
        {

        }

        private void lblCompany_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void PnlInvoice_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
