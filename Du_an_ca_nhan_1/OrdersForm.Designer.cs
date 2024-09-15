namespace Du_an_ca_nhan_1
{
    partial class OrdersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeOrders = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.btnChiTietNhapHang = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNhapHoaMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày tháng : ";
            // 
            // dateTimeOrders
            // 
            this.dateTimeOrders.CustomFormat = "dd/MM/yyyy";
            this.dateTimeOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeOrders.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeOrders.Location = new System.Drawing.Point(192, 16);
            this.dateTimeOrders.Name = "dateTimeOrders";
            this.dateTimeOrders.Size = new System.Drawing.Size(231, 38);
            this.dateTimeOrders.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(50, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhà cung cấp : ";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(192, 64);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(231, 39);
            this.cmbSuppliers.TabIndex = 14;
            this.cmbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cmbSuppliers_SelectedIndexChanged);
            // 
            // dataOrders
            // 
            this.dataOrders.AllowUserToAddRows = false;
            this.dataOrders.AllowUserToDeleteRows = false;
            this.dataOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Location = new System.Drawing.Point(4, 201);
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.RowHeadersWidth = 51;
            this.dataOrders.RowTemplate.Height = 24;
            this.dataOrders.Size = new System.Drawing.Size(1065, 246);
            this.dataOrders.TabIndex = 15;
            this.dataOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrders_CellClick);
            // 
            // btnChiTietNhapHang
            // 
            this.btnChiTietNhapHang.BackColor = System.Drawing.Color.Cyan;
            this.btnChiTietNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChiTietNhapHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChiTietNhapHang.Location = new System.Drawing.Point(296, 119);
            this.btnChiTietNhapHang.Name = "btnChiTietNhapHang";
            this.btnChiTietNhapHang.Size = new System.Drawing.Size(231, 55);
            this.btnChiTietNhapHang.TabIndex = 16;
            this.btnChiTietNhapHang.Text = "Chi tiết nhập hàng";
            this.btnChiTietNhapHang.UseVisualStyleBackColor = false;
            this.btnChiTietNhapHang.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 55);
            this.button2.TabIndex = 17;
            this.button2.Text = "TÌM KIẾM DANH SÁCH";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNhapHoaMoi
            // 
            this.btnNhapHoaMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapHoaMoi.Location = new System.Drawing.Point(662, 119);
            this.btnNhapHoaMoi.Name = "btnNhapHoaMoi";
            this.btnNhapHoaMoi.Size = new System.Drawing.Size(231, 55);
            this.btnNhapHoaMoi.TabIndex = 18;
            this.btnNhapHoaMoi.Text = "NHẬP HOA MỚI ";
            this.btnNhapHoaMoi.UseVisualStyleBackColor = true;
            this.btnNhapHoaMoi.Click += new System.EventHandler(this.btnNhapHoaMoi_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.btnNhapHoaMoi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChiTietNhapHang);
            this.Controls.Add(this.dataOrders);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeOrders);
            this.Controls.Add(this.label1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.Button btnChiTietNhapHang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNhapHoaMoi;
    }
}