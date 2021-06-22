namespace wholesaler_ERP
{
    partial class form_bill_details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_bill_details));
            this.txt_paid_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel21 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_left_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel26 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_disc_amount_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel27 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_total_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel28 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_final_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel29 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_disc_percent_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel30 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgv_sales_search = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_update_bill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_delete_bill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_bill_type = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_search)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_paid_search
            // 
            this.txt_paid_search.BackColor = System.Drawing.Color.White;
            this.txt_paid_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_paid_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_paid_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_paid_search.BorderThickness = 3;
            this.txt_paid_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_paid_search.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paid_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_paid_search.isPassword = false;
            this.txt_paid_search.Location = new System.Drawing.Point(414, 454);
            this.txt_paid_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_paid_search.Name = "txt_paid_search";
            this.txt_paid_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_paid_search.Size = new System.Drawing.Size(221, 38);
            this.txt_paid_search.TabIndex = 75;
            this.txt_paid_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_paid_search.OnValueChanged += new System.EventHandler(this.txt_paid_search_OnValueChanged);
            this.txt_paid_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paid_search_KeyPress);
            // 
            // bunifuCustomLabel21
            // 
            this.bunifuCustomLabel21.AutoSize = true;
            this.bunifuCustomLabel21.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel21.Location = new System.Drawing.Point(672, 461);
            this.bunifuCustomLabel21.Name = "bunifuCustomLabel21";
            this.bunifuCustomLabel21.Size = new System.Drawing.Size(70, 22);
            this.bunifuCustomLabel21.TabIndex = 74;
            this.bunifuCustomLabel21.Text = "المدفوع";
            this.bunifuCustomLabel21.Click += new System.EventHandler(this.bunifuCustomLabel21_Click);
            // 
            // txt_left_search
            // 
            this.txt_left_search.BackColor = System.Drawing.Color.White;
            this.txt_left_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_left_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_left_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_left_search.BorderThickness = 3;
            this.txt_left_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_left_search.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_left_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_left_search.isPassword = false;
            this.txt_left_search.Location = new System.Drawing.Point(39, 454);
            this.txt_left_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_left_search.Name = "txt_left_search";
            this.txt_left_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_left_search.Size = new System.Drawing.Size(221, 38);
            this.txt_left_search.TabIndex = 73;
            this.txt_left_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_left_search.OnValueChanged += new System.EventHandler(this.txt_left_search_OnValueChanged);
            this.txt_left_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_left_search_KeyPress);
            // 
            // bunifuCustomLabel22
            // 
            this.bunifuCustomLabel22.AutoSize = true;
            this.bunifuCustomLabel22.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel22.Location = new System.Drawing.Point(277, 461);
            this.bunifuCustomLabel22.Name = "bunifuCustomLabel22";
            this.bunifuCustomLabel22.Size = new System.Drawing.Size(68, 22);
            this.bunifuCustomLabel22.TabIndex = 72;
            this.bunifuCustomLabel22.Text = "المتبقي";
            this.bunifuCustomLabel22.Click += new System.EventHandler(this.bunifuCustomLabel22_Click);
            // 
            // bunifuCustomLabel26
            // 
            this.bunifuCustomLabel26.AutoSize = true;
            this.bunifuCustomLabel26.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel26.Location = new System.Drawing.Point(842, 402);
            this.bunifuCustomLabel26.Name = "bunifuCustomLabel26";
            this.bunifuCustomLabel26.Size = new System.Drawing.Size(24, 22);
            this.bunifuCustomLabel26.TabIndex = 71;
            this.bunifuCustomLabel26.Text = "%";
            this.bunifuCustomLabel26.Click += new System.EventHandler(this.bunifuCustomLabel26_Click);
            // 
            // txt_disc_amount_search
            // 
            this.txt_disc_amount_search.BackColor = System.Drawing.Color.White;
            this.txt_disc_amount_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_disc_amount_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_disc_amount_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_disc_amount_search.BorderThickness = 3;
            this.txt_disc_amount_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_disc_amount_search.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_disc_amount_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_disc_amount_search.isPassword = false;
            this.txt_disc_amount_search.Location = new System.Drawing.Point(875, 454);
            this.txt_disc_amount_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_disc_amount_search.Name = "txt_disc_amount_search";
            this.txt_disc_amount_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_disc_amount_search.Size = new System.Drawing.Size(187, 38);
            this.txt_disc_amount_search.TabIndex = 70;
            this.txt_disc_amount_search.Text = "0";
            this.txt_disc_amount_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_disc_amount_search.OnValueChanged += new System.EventHandler(this.ttxt_disc_amount_search_OnValueChanged);
            this.txt_disc_amount_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttxt_disc_amount_search_KeyPress);
            // 
            // bunifuCustomLabel27
            // 
            this.bunifuCustomLabel27.AutoSize = true;
            this.bunifuCustomLabel27.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel27.Location = new System.Drawing.Point(1060, 461);
            this.bunifuCustomLabel27.Name = "bunifuCustomLabel27";
            this.bunifuCustomLabel27.Size = new System.Drawing.Size(107, 22);
            this.bunifuCustomLabel27.TabIndex = 69;
            this.bunifuCustomLabel27.Text = " قيمه الخصم  ";
            this.bunifuCustomLabel27.Click += new System.EventHandler(this.bunifuCustomLabel27_Click);
            // 
            // txt_total_search
            // 
            this.txt_total_search.BackColor = System.Drawing.Color.White;
            this.txt_total_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_total_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_total_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_total_search.BorderThickness = 3;
            this.txt_total_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_total_search.Enabled = false;
            this.txt_total_search.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_total_search.isPassword = false;
            this.txt_total_search.Location = new System.Drawing.Point(414, 395);
            this.txt_total_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total_search.Name = "txt_total_search";
            this.txt_total_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_total_search.Size = new System.Drawing.Size(221, 38);
            this.txt_total_search.TabIndex = 68;
            this.txt_total_search.Text = "0";
            this.txt_total_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_total_search.OnValueChanged += new System.EventHandler(this.txt_total_search_OnValueChanged);
            // 
            // bunifuCustomLabel28
            // 
            this.bunifuCustomLabel28.AutoSize = true;
            this.bunifuCustomLabel28.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel28.Location = new System.Drawing.Point(663, 402);
            this.bunifuCustomLabel28.Name = "bunifuCustomLabel28";
            this.bunifuCustomLabel28.Size = new System.Drawing.Size(131, 22);
            this.bunifuCustomLabel28.TabIndex = 67;
            this.bunifuCustomLabel28.Text = "اجمالي المبيعات";
            this.bunifuCustomLabel28.Click += new System.EventHandler(this.bunifuCustomLabel28_Click);
            // 
            // txt_final_search
            // 
            this.txt_final_search.BackColor = System.Drawing.Color.White;
            this.txt_final_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_final_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_final_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_final_search.BorderThickness = 3;
            this.txt_final_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_final_search.Enabled = false;
            this.txt_final_search.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_final_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_final_search.isPassword = false;
            this.txt_final_search.Location = new System.Drawing.Point(39, 395);
            this.txt_final_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_final_search.Name = "txt_final_search";
            this.txt_final_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_final_search.Size = new System.Drawing.Size(221, 38);
            this.txt_final_search.TabIndex = 66;
            this.txt_final_search.Text = "0";
            this.txt_final_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_final_search.OnValueChanged += new System.EventHandler(this.txt_final_search_OnValueChanged);
            // 
            // bunifuCustomLabel29
            // 
            this.bunifuCustomLabel29.AutoSize = true;
            this.bunifuCustomLabel29.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel29.Location = new System.Drawing.Point(277, 402);
            this.bunifuCustomLabel29.Name = "bunifuCustomLabel29";
            this.bunifuCustomLabel29.Size = new System.Drawing.Size(66, 22);
            this.bunifuCustomLabel29.TabIndex = 65;
            this.bunifuCustomLabel29.Text = "الصافي";
            this.bunifuCustomLabel29.Click += new System.EventHandler(this.bunifuCustomLabel29_Click);
            // 
            // txt_disc_percent_search
            // 
            this.txt_disc_percent_search.BackColor = System.Drawing.Color.White;
            this.txt_disc_percent_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_disc_percent_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_disc_percent_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_disc_percent_search.BorderThickness = 3;
            this.txt_disc_percent_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_disc_percent_search.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_disc_percent_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_disc_percent_search.isPassword = false;
            this.txt_disc_percent_search.Location = new System.Drawing.Point(875, 395);
            this.txt_disc_percent_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_disc_percent_search.Name = "txt_disc_percent_search";
            this.txt_disc_percent_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_disc_percent_search.Size = new System.Drawing.Size(187, 38);
            this.txt_disc_percent_search.TabIndex = 64;
            this.txt_disc_percent_search.Text = "0";
            this.txt_disc_percent_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_disc_percent_search.OnValueChanged += new System.EventHandler(this.txt_disc_percent_search_OnValueChanged);
            this.txt_disc_percent_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_disc_percent_search_KeyPress);
            // 
            // bunifuCustomLabel30
            // 
            this.bunifuCustomLabel30.AutoSize = true;
            this.bunifuCustomLabel30.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel30.Location = new System.Drawing.Point(1108, 402);
            this.bunifuCustomLabel30.Name = "bunifuCustomLabel30";
            this.bunifuCustomLabel30.Size = new System.Drawing.Size(55, 22);
            this.bunifuCustomLabel30.TabIndex = 63;
            this.bunifuCustomLabel30.Text = "الخصم";
            this.bunifuCustomLabel30.Click += new System.EventHandler(this.bunifuCustomLabel30_Click);
            // 
            // dgv_sales_search
            // 
            this.dgv_sales_search.AllowUserToAddRows = false;
            this.dgv_sales_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sales_search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_sales_search.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sales_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sales_search.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_sales_search.Location = new System.Drawing.Point(18, 68);
            this.dgv_sales_search.Name = "dgv_sales_search";
            this.dgv_sales_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_sales_search.RowHeadersWidth = 56;
            this.dgv_sales_search.RowTemplate.Height = 24;
            this.dgv_sales_search.Size = new System.Drawing.Size(1149, 287);
            this.dgv_sales_search.TabIndex = 62;
            this.dgv_sales_search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_search_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "رقم الفاتوره";
            this.Column8.MinimumWidth = 7;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "اسم العميل";
            this.Column9.MinimumWidth = 7;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "اسم الصنف";
            this.Column10.MinimumWidth = 7;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "الكميه";
            this.Column11.MinimumWidth = 7;
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "سعر البيع";
            this.Column12.MinimumWidth = 7;
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "الاجمالي";
            this.Column13.MinimumWidth = 7;
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "";
            this.Column14.MinimumWidth = 7;
            this.Column14.Name = "Column14";
            this.Column14.Text = "تحديث";
            this.Column14.UseColumnTextForButtonValue = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "";
            this.Column15.MinimumWidth = 7;
            this.Column15.Name = "Column15";
            this.Column15.Text = "مرتجع";
            this.Column15.UseColumnTextForButtonValue = true;
            // 
            // btn_update_bill
            // 
            this.btn_update_bill.ActiveBorderThickness = 1;
            this.btn_update_bill.ActiveCornerRadius = 20;
            this.btn_update_bill.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_update_bill.ActiveForecolor = System.Drawing.Color.White;
            this.btn_update_bill.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_update_bill.BackColor = System.Drawing.Color.White;
            this.btn_update_bill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update_bill.BackgroundImage")));
            this.btn_update_bill.ButtonText = " حفظ التعديلات";
            this.btn_update_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_bill.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_bill.ForeColor = System.Drawing.Color.Black;
            this.btn_update_bill.IdleBorderThickness = 1;
            this.btn_update_bill.IdleCornerRadius = 20;
            this.btn_update_bill.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btn_update_bill.IdleForecolor = System.Drawing.Color.White;
            this.btn_update_bill.IdleLineColor = System.Drawing.Color.Black;
            this.btn_update_bill.Location = new System.Drawing.Point(630, 540);
            this.btn_update_bill.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_bill.Name = "btn_update_bill";
            this.btn_update_bill.Size = new System.Drawing.Size(181, 41);
            this.btn_update_bill.TabIndex = 77;
            this.btn_update_bill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_bill.Click += new System.EventHandler(this.btn_update_bill_Click);
            // 
            // btn_delete_bill
            // 
            this.btn_delete_bill.ActiveBorderThickness = 1;
            this.btn_delete_bill.ActiveCornerRadius = 20;
            this.btn_delete_bill.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_delete_bill.ActiveForecolor = System.Drawing.Color.White;
            this.btn_delete_bill.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_delete_bill.BackColor = System.Drawing.Color.White;
            this.btn_delete_bill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete_bill.BackgroundImage")));
            this.btn_delete_bill.ButtonText = "حذف";
            this.btn_delete_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_bill.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_bill.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_bill.IdleBorderThickness = 1;
            this.btn_delete_bill.IdleCornerRadius = 20;
            this.btn_delete_bill.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btn_delete_bill.IdleForecolor = System.Drawing.Color.White;
            this.btn_delete_bill.IdleLineColor = System.Drawing.Color.Black;
            this.btn_delete_bill.Location = new System.Drawing.Point(389, 540);
            this.btn_delete_bill.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete_bill.Name = "btn_delete_bill";
            this.btn_delete_bill.Size = new System.Drawing.Size(181, 41);
            this.btn_delete_bill.TabIndex = 76;
            this.btn_delete_bill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete_bill.Click += new System.EventHandler(this.btn_delete_bill_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1060, 33);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 22);
            this.bunifuCustomLabel1.TabIndex = 78;
            this.bunifuCustomLabel1.Text = "نوع الفاتوره  ";
            // 
            // lbl_bill_type
            // 
            this.lbl_bill_type.AutoSize = true;
            this.lbl_bill_type.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bill_type.Location = new System.Drawing.Point(973, 33);
            this.lbl_bill_type.Name = "lbl_bill_type";
            this.lbl_bill_type.Size = new System.Drawing.Size(78, 22);
            this.lbl_bill_type.TabIndex = 79;
            this.lbl_bill_type.Text = "bill_type";
            // 
            // form_bill_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 626);
            this.Controls.Add(this.lbl_bill_type);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_paid_search);
            this.Controls.Add(this.bunifuCustomLabel21);
            this.Controls.Add(this.txt_left_search);
            this.Controls.Add(this.bunifuCustomLabel22);
            this.Controls.Add(this.bunifuCustomLabel26);
            this.Controls.Add(this.txt_disc_amount_search);
            this.Controls.Add(this.bunifuCustomLabel27);
            this.Controls.Add(this.txt_total_search);
            this.Controls.Add(this.bunifuCustomLabel28);
            this.Controls.Add(this.txt_final_search);
            this.Controls.Add(this.bunifuCustomLabel29);
            this.Controls.Add(this.txt_disc_percent_search);
            this.Controls.Add(this.bunifuCustomLabel30);
            this.Controls.Add(this.dgv_sales_search);
            this.Controls.Add(this.btn_update_bill);
            this.Controls.Add(this.btn_delete_bill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_bill_details";
            this.Text = "بيانات الفاتوره";
            this.Load += new System.EventHandler(this.form_bill_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txt_paid_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel21;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_left_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel26;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_disc_amount_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel27;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_total_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel28;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_final_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel29;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_disc_percent_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel30;
        private System.Windows.Forms.DataGridView dgv_sales_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn Column14;
        private System.Windows.Forms.DataGridViewButtonColumn Column15;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_update_bill;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_delete_bill;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_bill_type;
    }
}