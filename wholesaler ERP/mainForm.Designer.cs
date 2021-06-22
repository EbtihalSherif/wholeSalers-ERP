namespace wholesaler_ERP
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel_main = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_products = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_grpProducts = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_userAttendance = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_users = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_locker = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_employees = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_reports = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_customers = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_purchases = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_inventory = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_sales = new Bunifu.Framework.UI.BunifuTileButton();
            this.salesusercontrol1 = new wholesaler_ERP.salesusercontrol();
            this.admin_controller1 = new wholesaler_ERP.admin_controller();
            this.purchases_usercontrol1 = new wholesaler_ERP.purchases_usercontrol();
            this.add_products1 = new wholesaler_ERP.add_products();
            this.reports_usercontrol1 = new wholesaler_ERP.reports_usercontrol();
            this.inventory_usercontrol2 = new wholesaler_ERP.inventory_usercontrol();
            this.system_admins1 = new wholesaler_ERP.system_admins();
            this.panel_main.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.Controls.Add(this.bunifuGradientPanel1);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.salesusercontrol1);
            this.panel_main.Controls.Add(this.admin_controller1);
            this.panel_main.Controls.Add(this.purchases_usercontrol1);
            this.panel_main.Controls.Add(this.add_products1);
            this.panel_main.Controls.Add(this.reports_usercontrol1);
            this.panel_main.Controls.Add(this.inventory_usercontrol2);
            this.panel_main.Controls.Add(this.system_admins1);
            this.panel_main.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_main.GradientBottomRight = System.Drawing.Color.White;
            this.panel_main.GradientTopLeft = System.Drawing.Color.White;
            this.panel_main.GradientTopRight = System.Drawing.Color.White;
            this.panel_main.Location = new System.Drawing.Point(3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Quality = 10;
            this.panel_main.Size = new System.Drawing.Size(1350, 762);
            this.panel_main.TabIndex = 13;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_products);
            this.bunifuGradientPanel1.Controls.Add(this.btn_grpProducts);
            this.bunifuGradientPanel1.Controls.Add(this.btn_userAttendance);
            this.bunifuGradientPanel1.Controls.Add(this.btn_users);
            this.bunifuGradientPanel1.Controls.Add(this.btn_locker);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(35, 34);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1294, 144);
            this.bunifuGradientPanel1.TabIndex = 12;
            // 
            // btn_products
            // 
            this.btn_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_products.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_products.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_products.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.Color.White;
            this.btn_products.Image = global::wholesaler_ERP.Properties.Resources.delivery_time__1_;
            this.btn_products.ImagePosition = 17;
            this.btn_products.ImageZoom = 35;
            this.btn_products.LabelPosition = 32;
            this.btn_products.LabelText = "حركه الاصناف";
            this.btn_products.Location = new System.Drawing.Point(1056, 4);
            this.btn_products.Margin = new System.Windows.Forms.Padding(4);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(211, 123);
            this.btn_products.TabIndex = 13;
            this.btn_products.Click += new System.EventHandler(this.bunifuTileButton12_Click);
            // 
            // btn_grpProducts
            // 
            this.btn_grpProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_grpProducts.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_grpProducts.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_grpProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grpProducts.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grpProducts.ForeColor = System.Drawing.Color.White;
            this.btn_grpProducts.Image = global::wholesaler_ERP.Properties.Resources.shopping_list__1_;
            this.btn_grpProducts.ImagePosition = 17;
            this.btn_grpProducts.ImageZoom = 30;
            this.btn_grpProducts.LabelPosition = 32;
            this.btn_grpProducts.LabelText = "مجموعه الاصناف";
            this.btn_grpProducts.Location = new System.Drawing.Point(531, 4);
            this.btn_grpProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btn_grpProducts.Name = "btn_grpProducts";
            this.btn_grpProducts.Size = new System.Drawing.Size(219, 123);
            this.btn_grpProducts.TabIndex = 12;
            this.btn_grpProducts.Click += new System.EventHandler(this.btn_grpProducts_Click);
            // 
            // btn_userAttendance
            // 
            this.btn_userAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_userAttendance.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_userAttendance.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_userAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userAttendance.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userAttendance.ForeColor = System.Drawing.Color.White;
            this.btn_userAttendance.Image = global::wholesaler_ERP.Properties.Resources.group__1_;
            this.btn_userAttendance.ImagePosition = 17;
            this.btn_userAttendance.ImageZoom = 40;
            this.btn_userAttendance.LabelPosition = 32;
            this.btn_userAttendance.LabelText = "مراقبه المستخدمين";
            this.btn_userAttendance.Location = new System.Drawing.Point(37, 4);
            this.btn_userAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btn_userAttendance.Name = "btn_userAttendance";
            this.btn_userAttendance.Size = new System.Drawing.Size(204, 123);
            this.btn_userAttendance.TabIndex = 8;
            this.btn_userAttendance.Click += new System.EventHandler(this.btn_userAttendance_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_users.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_users.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Image = global::wholesaler_ERP.Properties.Resources.add_user__1_;
            this.btn_users.ImagePosition = 17;
            this.btn_users.ImageZoom = 35;
            this.btn_users.LabelPosition = 32;
            this.btn_users.LabelText = "المستخدمين";
            this.btn_users.Location = new System.Drawing.Point(272, 4);
            this.btn_users.Margin = new System.Windows.Forms.Padding(4);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(224, 123);
            this.btn_users.TabIndex = 11;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_locker
            // 
            this.btn_locker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_locker.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_locker.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_locker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_locker.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_locker.ForeColor = System.Drawing.Color.White;
            this.btn_locker.Image = global::wholesaler_ERP.Properties.Resources.locker__1_;
            this.btn_locker.ImagePosition = 17;
            this.btn_locker.ImageZoom = 35;
            this.btn_locker.LabelPosition = 32;
            this.btn_locker.LabelText = "الخزنه";
            this.btn_locker.Location = new System.Drawing.Point(785, 4);
            this.btn_locker.Margin = new System.Windows.Forms.Padding(4);
            this.btn_locker.Name = "btn_locker";
            this.btn_locker.Size = new System.Drawing.Size(228, 123);
            this.btn_locker.TabIndex = 9;
            this.btn_locker.Click += new System.EventHandler(this.btn_locker_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_employees);
            this.panel1.Controls.Add(this.btn_reports);
            this.panel1.Controls.Add(this.btn_customers);
            this.panel1.Controls.Add(this.btn_purchases);
            this.panel1.Controls.Add(this.btn_inventory);
            this.panel1.Controls.Add(this.btn_sales);
            this.panel1.Location = new System.Drawing.Point(72, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 504);
            this.panel1.TabIndex = 13;
            // 
            // btn_employees
            // 
            this.btn_employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_employees.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_employees.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_employees.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employees.ForeColor = System.Drawing.Color.White;
            this.btn_employees.Image = global::wholesaler_ERP.Properties.Resources.skills__2_;
            this.btn_employees.ImagePosition = 19;
            this.btn_employees.ImageZoom = 40;
            this.btn_employees.LabelPosition = 40;
            this.btn_employees.LabelText = "بيانات الموظفين";
            this.btn_employees.Location = new System.Drawing.Point(798, 282);
            this.btn_employees.Margin = new System.Windows.Forms.Padding(6);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(330, 202);
            this.btn_employees.TabIndex = 7;
            this.btn_employees.Click += new System.EventHandler(this.bunifuTileButton7_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_reports.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_reports.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reports.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.Image = global::wholesaler_ERP.Properties.Resources.business_report__2_;
            this.btn_reports.ImagePosition = 19;
            this.btn_reports.ImageZoom = 35;
            this.btn_reports.LabelPosition = 40;
            this.btn_reports.LabelText = "التقارير";
            this.btn_reports.Location = new System.Drawing.Point(104, 55);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(6);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(330, 202);
            this.btn_reports.TabIndex = 1;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_customers.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_customers.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customers.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.White;
            this.btn_customers.Image = global::wholesaler_ERP.Properties.Resources.grouped_users_interface_symbol_for_group_verification;
            this.btn_customers.ImagePosition = 19;
            this.btn_customers.ImageZoom = 40;
            this.btn_customers.LabelPosition = 40;
            this.btn_customers.LabelText = "الموردين والعملاء";
            this.btn_customers.Location = new System.Drawing.Point(456, 282);
            this.btn_customers.Margin = new System.Windows.Forms.Padding(6);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(330, 202);
            this.btn_customers.TabIndex = 3;
            this.btn_customers.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // btn_purchases
            // 
            this.btn_purchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_purchases.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_purchases.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_purchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchases.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchases.ForeColor = System.Drawing.Color.White;
            this.btn_purchases.Image = global::wholesaler_ERP.Properties.Resources.shopping_bag__1_;
            this.btn_purchases.ImagePosition = 19;
            this.btn_purchases.ImageZoom = 40;
            this.btn_purchases.LabelPosition = 40;
            this.btn_purchases.LabelText = "المشتريات";
            this.btn_purchases.Location = new System.Drawing.Point(104, 282);
            this.btn_purchases.Margin = new System.Windows.Forms.Padding(6);
            this.btn_purchases.Name = "btn_purchases";
            this.btn_purchases.Size = new System.Drawing.Size(330, 202);
            this.btn_purchases.TabIndex = 5;
            this.btn_purchases.Click += new System.EventHandler(this.btn_purchases_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_inventory.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_inventory.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventory.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_inventory.Image = global::wholesaler_ERP.Properties.Resources.storage;
            this.btn_inventory.ImagePosition = 19;
            this.btn_inventory.ImageZoom = 40;
            this.btn_inventory.LabelPosition = 40;
            this.btn_inventory.LabelText = "المخزن";
            this.btn_inventory.Location = new System.Drawing.Point(456, 55);
            this.btn_inventory.Margin = new System.Windows.Forms.Padding(6);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(330, 202);
            this.btn_inventory.TabIndex = 4;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sales.color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(105)))));
            this.btn_sales.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sales.Font = new System.Drawing.Font("Neo Sans Arabic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.Image = global::wholesaler_ERP.Properties.Resources.shopping_cart__1_;
            this.btn_sales.ImagePosition = 19;
            this.btn_sales.ImageZoom = 40;
            this.btn_sales.LabelPosition = 40;
            this.btn_sales.LabelText = "المبيعات";
            this.btn_sales.Location = new System.Drawing.Point(798, 55);
            this.btn_sales.Margin = new System.Windows.Forms.Padding(6);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(330, 202);
            this.btn_sales.TabIndex = 2;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // salesusercontrol1
            // 
            this.salesusercontrol1.Location = new System.Drawing.Point(0, 0);
            this.salesusercontrol1.MaximumSize = new System.Drawing.Size(1350, 762);
            this.salesusercontrol1.Name = "salesusercontrol1";
            this.salesusercontrol1.Size = new System.Drawing.Size(1350, 762);
            this.salesusercontrol1.TabIndex = 17;
            this.salesusercontrol1.Load += new System.EventHandler(this.salesusercontrol1_Load);
            // 
            // admin_controller1
            // 
            this.admin_controller1.BackColor = System.Drawing.Color.White;
            this.admin_controller1.Location = new System.Drawing.Point(-3, -3);
            this.admin_controller1.MaximumSize = new System.Drawing.Size(1350, 762);
            this.admin_controller1.Name = "admin_controller1";
            this.admin_controller1.Size = new System.Drawing.Size(1350, 762);
            this.admin_controller1.TabIndex = 14;
            // 
            // purchases_usercontrol1
            // 
            this.purchases_usercontrol1.Location = new System.Drawing.Point(-3, -3);
            this.purchases_usercontrol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchases_usercontrol1.MaximumSize = new System.Drawing.Size(1350, 762);
            this.purchases_usercontrol1.Name = "purchases_usercontrol1";
            this.purchases_usercontrol1.Size = new System.Drawing.Size(1350, 762);
            this.purchases_usercontrol1.TabIndex = 14;
            // 
            // add_products1
            // 
            this.add_products1.BackColor = System.Drawing.Color.White;
            this.add_products1.CausesValidation = false;
            this.add_products1.Location = new System.Drawing.Point(-3, 0);
            this.add_products1.MaximumSize = new System.Drawing.Size(1350, 762);
            this.add_products1.Name = "add_products1";
            this.add_products1.Size = new System.Drawing.Size(1350, 762);
            this.add_products1.TabIndex = 15;
            this.add_products1.Load += new System.EventHandler(this.add_products1_Load);
            // 
            // reports_usercontrol1
            // 
            this.reports_usercontrol1.BackColor = System.Drawing.Color.White;
            this.reports_usercontrol1.Location = new System.Drawing.Point(0, 0);
            this.reports_usercontrol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reports_usercontrol1.MaximumSize = new System.Drawing.Size(1350, 762);
            this.reports_usercontrol1.Name = "reports_usercontrol1";
            this.reports_usercontrol1.Size = new System.Drawing.Size(1350, 762);
            this.reports_usercontrol1.TabIndex = 16;
            // 
            // inventory_usercontrol2
            // 
            this.inventory_usercontrol2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inventory_usercontrol2.BackColor = System.Drawing.Color.White;
            this.inventory_usercontrol2.Location = new System.Drawing.Point(0, 0);
            this.inventory_usercontrol2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventory_usercontrol2.MaximumSize = new System.Drawing.Size(1350, 762);
            this.inventory_usercontrol2.Name = "inventory_usercontrol2";
            this.inventory_usercontrol2.Size = new System.Drawing.Size(1350, 762);
            this.inventory_usercontrol2.TabIndex = 8;
            // 
            // system_admins1
            // 
            this.system_admins1.BackColor = System.Drawing.Color.White;
            this.system_admins1.Location = new System.Drawing.Point(0, 0);
            this.system_admins1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.system_admins1.MaximumSize = new System.Drawing.Size(1350, 762);
            this.system_admins1.Name = "system_admins1";
            this.system_admins1.Size = new System.Drawing.Size(1350, 762);
            this.system_admins1.TabIndex = 18;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 777);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القائمه الرئيسيه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel_main.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btn_userAttendance;
        private Bunifu.Framework.UI.BunifuTileButton btn_locker;
        private Bunifu.Framework.UI.BunifuTileButton btn_users;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton btn_products;
        private Bunifu.Framework.UI.BunifuTileButton btn_grpProducts;
        private Bunifu.Framework.UI.BunifuTileButton btn_employees;
        private Bunifu.Framework.UI.BunifuTileButton btn_reports;
        private Bunifu.Framework.UI.BunifuTileButton btn_customers;
        private Bunifu.Framework.UI.BunifuTileButton btn_purchases;
        private Bunifu.Framework.UI.BunifuTileButton btn_inventory;
        private Bunifu.Framework.UI.BunifuTileButton btn_sales;
        public Bunifu.Framework.UI.BunifuGradientPanel panel_main;
        private admin_controller admin_controller1;
        private add_products add_products1;
        private inventory_usercontrol inventory_usercontrol2;
        private purchases_usercontrol purchases_usercontrol1;
        private reports_usercontrol reports_usercontrol1;
        private salesusercontrol salesusercontrol1;
        private system_admins system_admins1;
        private System.Windows.Forms.Panel panel1;
    }
}