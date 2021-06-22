namespace wholesaler_ERP
{
    partial class Excel_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excel_info));
            this.browseExelBtn = new System.Windows.Forms.Button();
            this.ExelPathTXT = new System.Windows.Forms.TextBox();
            this.dgv_excel = new System.Windows.Forms.DataGridView();
            this.btn_load = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_add_to_db = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excel)).BeginInit();
            this.SuspendLayout();
            // 
            // browseExelBtn
            // 
            this.browseExelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.browseExelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseExelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseExelBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.browseExelBtn.Location = new System.Drawing.Point(673, 15);
            this.browseExelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseExelBtn.Name = "browseExelBtn";
            this.browseExelBtn.Size = new System.Drawing.Size(100, 39);
            this.browseExelBtn.TabIndex = 11;
            this.browseExelBtn.Text = "Browse";
            this.browseExelBtn.UseVisualStyleBackColor = false;
            this.browseExelBtn.Click += new System.EventHandler(this.browseExelBtn_Click);
            // 
            // ExelPathTXT
            // 
            this.ExelPathTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExelPathTXT.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ExelPathTXT.Location = new System.Drawing.Point(253, 15);
            this.ExelPathTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExelPathTXT.Multiline = true;
            this.ExelPathTXT.Name = "ExelPathTXT";
            this.ExelPathTXT.Size = new System.Drawing.Size(420, 38);
            this.ExelPathTXT.TabIndex = 10;
            this.ExelPathTXT.Text = "Exel path";
            this.ExelPathTXT.MouseHover += new System.EventHandler(this.ExelPathTXT_MouseHover);
            // 
            // dgv_excel
            // 
            this.dgv_excel.AllowUserToAddRows = false;
            this.dgv_excel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_excel.Location = new System.Drawing.Point(53, 143);
            this.dgv_excel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_excel.Name = "dgv_excel";
            this.dgv_excel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_excel.RowHeadersWidth = 56;
            this.dgv_excel.Size = new System.Drawing.Size(944, 308);
            this.dgv_excel.TabIndex = 12;
            this.dgv_excel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_load
            // 
            this.btn_load.ActiveBorderThickness = 1;
            this.btn_load.ActiveCornerRadius = 20;
            this.btn_load.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(174)))));
            this.btn_load.ActiveForecolor = System.Drawing.Color.White;
            this.btn_load.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_load.BackColor = System.Drawing.Color.White;
            this.btn_load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_load.BackgroundImage")));
            this.btn_load.ButtonText = "تحميل";
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.Black;
            this.btn_load.IdleBorderThickness = 1;
            this.btn_load.IdleCornerRadius = 20;
            this.btn_load.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btn_load.IdleForecolor = System.Drawing.Color.White;
            this.btn_load.IdleLineColor = System.Drawing.Color.Black;
            this.btn_load.Location = new System.Drawing.Point(469, 91);
            this.btn_load.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(140, 43);
            this.btn_load.TabIndex = 45;
            this.btn_load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_load.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_add_to_db
            // 
            this.btn_add_to_db.ActiveBorderThickness = 1;
            this.btn_add_to_db.ActiveCornerRadius = 20;
            this.btn_add_to_db.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(174)))));
            this.btn_add_to_db.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add_to_db.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_add_to_db.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add_to_db.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add_to_db.BackgroundImage")));
            this.btn_add_to_db.ButtonText = "اضافة";
            this.btn_add_to_db.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_to_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_to_db.ForeColor = System.Drawing.Color.Black;
            this.btn_add_to_db.IdleBorderThickness = 1;
            this.btn_add_to_db.IdleCornerRadius = 20;
            this.btn_add_to_db.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btn_add_to_db.IdleForecolor = System.Drawing.Color.White;
            this.btn_add_to_db.IdleLineColor = System.Drawing.Color.Black;
            this.btn_add_to_db.Location = new System.Drawing.Point(469, 484);
            this.btn_add_to_db.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_add_to_db.Name = "btn_add_to_db";
            this.btn_add_to_db.Size = new System.Drawing.Size(140, 43);
            this.btn_add_to_db.TabIndex = 46;
            this.btn_add_to_db.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_to_db.Click += new System.EventHandler(this.btn_add_to_db_Click);
            // 
            // Excel_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_add_to_db);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dgv_excel);
            this.Controls.Add(this.browseExelBtn);
            this.Controls.Add(this.ExelPathTXT);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Excel_info";
            this.Text = "Excel_info";
            this.Load += new System.EventHandler(this.Excel_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseExelBtn;
        private System.Windows.Forms.TextBox ExelPathTXT;
        private System.Windows.Forms.DataGridView dgv_excel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add_to_db;
    }
}