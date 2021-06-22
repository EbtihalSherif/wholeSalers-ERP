namespace wholesaler_ERP
{
    partial class InoviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlInvoice = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblShip = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCustInf = new System.Windows.Forms.Label();
            this.PnlInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlInvoice
            // 
            this.PnlInvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlInvoice.Controls.Add(this.listView1);
            this.PnlInvoice.Controls.Add(this.lblShip);
            this.PnlInvoice.Controls.Add(this.lbl_Total);
            this.PnlInvoice.Controls.Add(this.label2);
            this.PnlInvoice.Controls.Add(this.lblDate);
            this.PnlInvoice.Controls.Add(this.lblCompany);
            this.PnlInvoice.Controls.Add(this.lblCustInf);
            this.PnlInvoice.Location = new System.Drawing.Point(-1, 0);
            this.PnlInvoice.Name = "PnlInvoice";
            this.PnlInvoice.Size = new System.Drawing.Size(979, 913);
            this.PnlInvoice.TabIndex = 0;
            this.PnlInvoice.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlInvoice_Paint);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.quantity,
            this.uPrice,
            this.tPrice});
            this.listView1.Enabled = false;
            this.listView1.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 250);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(936, 572);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "الصنف";
            this.Id.Width = 109;
            // 
            // quantity
            // 
            this.quantity.Text = "الكميه";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantity.Width = 84;
            // 
            // uPrice
            // 
            this.uPrice.Text = "سعر البيع";
            this.uPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uPrice.Width = 108;
            // 
            // tPrice
            // 
            this.tPrice.Text = "الاجمالي";
            this.tPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tPrice.Width = 109;
            // 
            // lblShip
            // 
            this.lblShip.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShip.Location = new System.Drawing.Point(613, 118);
            this.lblShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShip.Name = "lblShip";
            this.lblShip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblShip.Size = new System.Drawing.Size(295, 117);
            this.lblShip.TabIndex = 19;
            this.lblShip.Text = "Shipment information";
            this.lblShip.Click += new System.EventHandler(this.lblShip_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(702, 826);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(114, 36);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = ":الصافي";
            this.lbl_Total.Click += new System.EventHandler(this.lbl_Total_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 826);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = ":الصافي";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(113, 50);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(187, 28);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(675, 21);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(281, 78);
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = "فاتوره مبيعات";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCompany.Click += new System.EventHandler(this.lblCompany_Click_1);
            // 
            // lblCustInf
            // 
            this.lblCustInf.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustInf.Location = new System.Drawing.Point(182, 118);
            this.lblCustInf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustInf.Name = "lblCustInf";
            this.lblCustInf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustInf.Size = new System.Drawing.Size(300, 117);
            this.lblCustInf.TabIndex = 16;
            this.lblCustInf.Text = "Customer information";
            // 
            // InoviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 915);
            this.Controls.Add(this.PnlInvoice);
            this.Name = "InoviceForm";
            this.Text = "InoviceForm";
            this.Load += new System.EventHandler(this.InoviceForm_Load);
            this.PnlInvoice.ResumeLayout(false);
            this.PnlInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlInvoice;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader uPrice;
        private System.Windows.Forms.ColumnHeader tPrice;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustInf;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCompany;

    }
}