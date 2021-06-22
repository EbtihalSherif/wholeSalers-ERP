namespace wholesaler_ERP
{
    partial class add_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_Customer));
            this.tab_customers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_save_customers = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_customer_notes = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_customer_phone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_customer_natID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_customer_address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RD_supplier = new System.Windows.Forms.RadioButton();
            this.rd_customer = new System.Windows.Forms.RadioButton();
            this.txt_customer_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmb_search_customer = new System.Windows.Forms.ComboBox();
            this.btn_update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgv_search_customers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rd_supplier_search = new System.Windows.Forms.RadioButton();
            this.Rd_customer_search = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tab_customers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_customers
            // 
            this.tab_customers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_customers.Controls.Add(this.tabPage1);
            this.tab_customers.Controls.Add(this.tabPage2);
            this.tab_customers.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_customers.Location = new System.Drawing.Point(5, 0);
            this.tab_customers.Margin = new System.Windows.Forms.Padding(2);
            this.tab_customers.Name = "tab_customers";
            this.tab_customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tab_customers.RightToLeftLayout = true;
            this.tab_customers.SelectedIndex = 0;
            this.tab_customers.Size = new System.Drawing.Size(689, 404);
            this.tab_customers.TabIndex = 0;
            this.tab_customers.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tab_customers.Click += new System.EventHandler(this.tab_customers_Click);
            this.tab_customers.DoubleClick += new System.EventHandler(this.tab_customers_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btn_save_customers);
            this.tabPage1.Controls.Add(this.txt_customer_notes);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel5);
            this.tabPage1.Controls.Add(this.txt_customer_phone);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel4);
            this.tabPage1.Controls.Add(this.txt_customer_natID);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage1.Controls.Add(this.txt_customer_address);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage1.Controls.Add(this.RD_supplier);
            this.tabPage1.Controls.Add(this.rd_customer);
            this.tabPage1.Controls.Add(this.txt_customer_Name);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(681, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "جديد";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_save_customers
            // 
            this.btn_save_customers.ActiveBorderThickness = 1;
            this.btn_save_customers.ActiveCornerRadius = 20;
            this.btn_save_customers.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_save_customers.ActiveForecolor = System.Drawing.Color.White;
            this.btn_save_customers.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save_customers.BackColor = System.Drawing.Color.White;
            this.btn_save_customers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save_customers.BackgroundImage")));
            this.btn_save_customers.ButtonText = "حفظ";
            this.btn_save_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_customers.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_customers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save_customers.IdleBorderThickness = 1;
            this.btn_save_customers.IdleCornerRadius = 20;
            this.btn_save_customers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btn_save_customers.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_customers.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save_customers.Location = new System.Drawing.Point(271, 308);
            this.btn_save_customers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save_customers.Name = "btn_save_customers";
            this.btn_save_customers.Size = new System.Drawing.Size(136, 33);
            this.btn_save_customers.TabIndex = 13;
            this.btn_save_customers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save_customers.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txt_customer_notes
            // 
            this.txt_customer_notes.BackColor = System.Drawing.Color.White;
            this.txt_customer_notes.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_customer_notes.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_notes.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_notes.BorderThickness = 3;
            this.txt_customer_notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_notes.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_notes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_customer_notes.isPassword = false;
            this.txt_customer_notes.Location = new System.Drawing.Point(201, 220);
            this.txt_customer_notes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_notes.Name = "txt_customer_notes";
            this.txt_customer_notes.Size = new System.Drawing.Size(362, 44);
            this.txt_customer_notes.TabIndex = 12;
            this.txt_customer_notes.Text = " ";
            this.txt_customer_notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_customer_notes.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox5_OnValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(604, 220);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(60, 17);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "ملاحظات";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // txt_customer_phone
            // 
            this.txt_customer_phone.BackColor = System.Drawing.Color.White;
            this.txt_customer_phone.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_customer_phone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_phone.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_phone.BorderThickness = 3;
            this.txt_customer_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_phone.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_customer_phone.isPassword = false;
            this.txt_customer_phone.Location = new System.Drawing.Point(404, 88);
            this.txt_customer_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_phone.Name = "txt_customer_phone";
            this.txt_customer_phone.Size = new System.Drawing.Size(159, 32);
            this.txt_customer_phone.TabIndex = 10;
            this.txt_customer_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_customer_phone.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox4_OnValueChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(594, 98);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(77, 17);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "رقم التليفون";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // txt_customer_natID
            // 
            this.txt_customer_natID.BackColor = System.Drawing.Color.White;
            this.txt_customer_natID.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_customer_natID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_natID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_natID.BorderThickness = 3;
            this.txt_customer_natID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_natID.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_natID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_customer_natID.isPassword = false;
            this.txt_customer_natID.Location = new System.Drawing.Point(46, 88);
            this.txt_customer_natID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_natID.Name = "txt_customer_natID";
            this.txt_customer_natID.Size = new System.Drawing.Size(217, 32);
            this.txt_customer_natID.TabIndex = 8;
            this.txt_customer_natID.Text = " ";
            this.txt_customer_natID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_customer_natID.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox3_OnValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(267, 98);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 17);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "الرقم القومي";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // txt_customer_address
            // 
            this.txt_customer_address.BackColor = System.Drawing.Color.White;
            this.txt_customer_address.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_customer_address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_address.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_address.BorderThickness = 3;
            this.txt_customer_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_address.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_customer_address.isPassword = false;
            this.txt_customer_address.Location = new System.Drawing.Point(374, 138);
            this.txt_customer_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_address.Name = "txt_customer_address";
            this.txt_customer_address.Size = new System.Drawing.Size(190, 64);
            this.txt_customer_address.TabIndex = 6;
            this.txt_customer_address.Text = " ";
            this.txt_customer_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_customer_address.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox2_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(614, 157);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(49, 17);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "العنوان";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // RD_supplier
            // 
            this.RD_supplier.AutoSize = true;
            this.RD_supplier.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RD_supplier.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_supplier.Location = new System.Drawing.Point(199, 46);
            this.RD_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.RD_supplier.Name = "RD_supplier";
            this.RD_supplier.Size = new System.Drawing.Size(53, 21);
            this.RD_supplier.TabIndex = 4;
            this.RD_supplier.Text = "مورد";
            this.RD_supplier.UseVisualStyleBackColor = true;
            this.RD_supplier.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd_customer
            // 
            this.rd_customer.AutoSize = true;
            this.rd_customer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rd_customer.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_customer.Location = new System.Drawing.Point(271, 46);
            this.rd_customer.Margin = new System.Windows.Forms.Padding(2);
            this.rd_customer.Name = "rd_customer";
            this.rd_customer.Size = new System.Drawing.Size(54, 21);
            this.rd_customer.TabIndex = 3;
            this.rd_customer.Text = "عميل";
            this.rd_customer.UseVisualStyleBackColor = true;
            this.rd_customer.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txt_customer_Name
            // 
            this.txt_customer_Name.BackColor = System.Drawing.Color.White;
            this.txt_customer_Name.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_customer_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_Name.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_customer_Name.BorderThickness = 3;
            this.txt_customer_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_Name.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_customer_Name.isPassword = false;
            this.txt_customer_Name.Location = new System.Drawing.Point(404, 37);
            this.txt_customer_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customer_Name.Name = "txt_customer_Name";
            this.txt_customer_Name.Size = new System.Drawing.Size(159, 32);
            this.txt_customer_Name.TabIndex = 2;
            this.txt_customer_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_customer_Name.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(567, 46);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(112, 17);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "اسم العميل/المورد";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel7);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.bunifuThinButton21);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel9);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel8);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.cmb_search_customer);
            this.tabPage2.Controls.Add(this.btn_update);
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.dgv_search_customers);
            this.tabPage2.Controls.Add(this.Rd_supplier_search);
            this.tabPage2.Controls.Add(this.Rd_customer_search);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(681, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "بحث";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "عميل",
            "مورد"});
            this.comboBox1.Location = new System.Drawing.Point(346, 331);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 24);
            this.comboBox1.TabIndex = 76;
            this.comboBox1.Text = "عميل";
            this.comboBox1.Visible = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(236, 307);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel7.TabIndex = 75;
            this.bunifuCustomLabel7.Text = "المبلغ";
            this.bunifuCustomLabel7.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 23);
            this.textBox1.TabIndex = 74;
            this.textBox1.Visible = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "حفظ";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(64, 319);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(101, 35);
            this.bunifuThinButton21.TabIndex = 73;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Visible = false;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(372, 307);
            this.bunifuCustomLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(89, 17);
            this.bunifuCustomLabel9.TabIndex = 72;
            this.bunifuCustomLabel9.Text = "طبيعة الشخص";
            this.bunifuCustomLabel9.Visible = false;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(582, 307);
            this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel8.TabIndex = 71;
            this.bunifuCustomLabel8.Text = "الأسم";
            this.bunifuCustomLabel8.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(537, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 23);
            this.textBox3.TabIndex = 69;
            this.textBox3.Visible = false;
            // 
            // cmb_search_customer
            // 
            this.cmb_search_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_search_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_search_customer.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search_customer.FormattingEnabled = true;
            this.cmb_search_customer.Location = new System.Drawing.Point(338, 18);
            this.cmb_search_customer.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_search_customer.Name = "cmb_search_customer";
            this.cmb_search_customer.Size = new System.Drawing.Size(159, 24);
            this.cmb_search_customer.TabIndex = 66;
            this.cmb_search_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_search_customer_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.ActiveBorderThickness = 1;
            this.btn_update.ActiveCornerRadius = 20;
            this.btn_update.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_update.ActiveForecolor = System.Drawing.Color.White;
            this.btn_update.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.ButtonText = "تعديل";
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.IdleBorderThickness = 1;
            this.btn_update.IdleCornerRadius = 20;
            this.btn_update.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btn_update.IdleForecolor = System.Drawing.Color.White;
            this.btn_update.IdleLineColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(413, 248);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(136, 33);
            this.btn_update.TabIndex = 65;
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveBorderThickness = 1;
            this.btn_delete.ActiveCornerRadius = 20;
            this.btn_delete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_delete.ActiveForecolor = System.Drawing.Color.White;
            this.btn_delete.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.ButtonText = "حذف";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.IdleBorderThickness = 1;
            this.btn_delete.IdleCornerRadius = 20;
            this.btn_delete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btn_delete.IdleForecolor = System.Drawing.Color.White;
            this.btn_delete.IdleLineColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(138, 248);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(136, 33);
            this.btn_delete.TabIndex = 64;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_search_customers
            // 
            this.dgv_search_customers.AllowUserToAddRows = false;
            this.dgv_search_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_search_customers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_search_customers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_search_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_search_customers.Location = new System.Drawing.Point(82, 55);
            this.dgv_search_customers.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_search_customers.Name = "dgv_search_customers";
            this.dgv_search_customers.RowHeadersWidth = 56;
            this.dgv_search_customers.RowTemplate.Height = 24;
            this.dgv_search_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_search_customers.Size = new System.Drawing.Size(567, 187);
            this.dgv_search_customers.TabIndex = 9;
            this.dgv_search_customers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_customers_CellContentClick);
            this.dgv_search_customers.SelectionChanged += new System.EventHandler(this.dgv_search_customers_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم الشخص";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الاسم";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "طبيعه الشخص";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "المبلغ المتبقي";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            // 
            // Rd_supplier_search
            // 
            this.Rd_supplier_search.AutoSize = true;
            this.Rd_supplier_search.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Rd_supplier_search.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_supplier_search.Location = new System.Drawing.Point(112, 18);
            this.Rd_supplier_search.Margin = new System.Windows.Forms.Padding(2);
            this.Rd_supplier_search.Name = "Rd_supplier_search";
            this.Rd_supplier_search.Size = new System.Drawing.Size(53, 21);
            this.Rd_supplier_search.TabIndex = 8;
            this.Rd_supplier_search.Text = "مورد";
            this.Rd_supplier_search.UseVisualStyleBackColor = true;
            this.Rd_supplier_search.CheckedChanged += new System.EventHandler(this.Rd_supplier_search_CheckedChanged);
            // 
            // Rd_customer_search
            // 
            this.Rd_customer_search.AutoSize = true;
            this.Rd_customer_search.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Rd_customer_search.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_customer_search.Location = new System.Drawing.Point(184, 18);
            this.Rd_customer_search.Margin = new System.Windows.Forms.Padding(2);
            this.Rd_customer_search.Name = "Rd_customer_search";
            this.Rd_customer_search.Size = new System.Drawing.Size(54, 21);
            this.Rd_customer_search.TabIndex = 7;
            this.Rd_customer_search.Text = "عميل";
            this.Rd_customer_search.UseVisualStyleBackColor = true;
            this.Rd_customer_search.CheckedChanged += new System.EventHandler(this.Rd_customer_search_CheckedChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Neo Sans Arabic", 9.96923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(501, 18);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(112, 17);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "اسم المورد/العميل";
            // 
            // add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 439);
            this.Controls.Add(this.tab_customers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "add_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه عميل/مورد";
            this.Load += new System.EventHandler(this.add_Customer_Load);
            this.tab_customers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_customers;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_customer_Name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_customer_notes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_customer_phone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_customer_natID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_customer_address;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.RadioButton RD_supplier;
        private System.Windows.Forms.RadioButton rd_customer;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_save_customers;
        private System.Windows.Forms.DataGridView dgv_search_customers;
        private System.Windows.Forms.RadioButton Rd_supplier_search;
        private System.Windows.Forms.RadioButton Rd_customer_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.ComboBox cmb_search_customer;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_update;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.TextBox textBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}