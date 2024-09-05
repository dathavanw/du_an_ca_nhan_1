namespace Du_an_ca_nhan_1
{
    partial class ProductForm
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
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.cmbLoaiHoa = new System.Windows.Forms.ComboBox();
            this.LoaiHoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaHoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnSuaThongTinSanPham = new System.Windows.Forms.Button();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnTimKiemSanPham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProduct
            // 
            this.dataProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Location = new System.Drawing.Point(0, 228);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersWidth = 51;
            this.dataProduct.RowTemplate.Height = 24;
            this.dataProduct.Size = new System.Drawing.Size(998, 219);
            this.dataProduct.TabIndex = 0;
            // 
            // cmbLoaiHoa
            // 
            this.cmbLoaiHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiHoa.FormattingEnabled = true;
            this.cmbLoaiHoa.Items.AddRange(new object[] {
            "Hoa Khô ",
            "Hoa Sáp ",
            "Hoa Handmade"});
            this.cmbLoaiHoa.Location = new System.Drawing.Point(169, 12);
            this.cmbLoaiHoa.Name = "cmbLoaiHoa";
            this.cmbLoaiHoa.Size = new System.Drawing.Size(223, 28);
            this.cmbLoaiHoa.TabIndex = 1;
            // 
            // LoaiHoa
            // 
            this.LoaiHoa.AutoSize = true;
            this.LoaiHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LoaiHoa.Location = new System.Drawing.Point(53, 16);
            this.LoaiHoa.Name = "LoaiHoa";
            this.LoaiHoa.Size = new System.Drawing.Size(97, 20);
            this.LoaiHoa.TabIndex = 2;
            this.LoaiHoa.Text = "Loại Hoa :";
            this.LoaiHoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(58, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Hoa :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenHoa
            // 
            this.txtTenHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHoa.Location = new System.Drawing.Point(169, 58);
            this.txtTenHoa.Name = "txtTenHoa";
            this.txtTenHoa.Size = new System.Drawing.Size(223, 27);
            this.txtTenHoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá Hoa :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGiaHoa
            // 
            this.txtGiaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaHoa.Location = new System.Drawing.Point(169, 102);
            this.txtGiaHoa.Name = "txtGiaHoa";
            this.txtGiaHoa.Size = new System.Drawing.Size(223, 27);
            this.txtGiaHoa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ghi chú : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(169, 137);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(223, 75);
            this.txtGhiChu.TabIndex = 8;
            // 
            // btnSuaThongTinSanPham
            // 
            this.btnSuaThongTinSanPham.BackColor = System.Drawing.Color.Yellow;
            this.btnSuaThongTinSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaThongTinSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuaThongTinSanPham.Location = new System.Drawing.Point(488, 78);
            this.btnSuaThongTinSanPham.Name = "btnSuaThongTinSanPham";
            this.btnSuaThongTinSanPham.Size = new System.Drawing.Size(235, 44);
            this.btnSuaThongTinSanPham.TabIndex = 10;
            this.btnSuaThongTinSanPham.Text = "Sửa thông tin sản phẩm";
            this.btnSuaThongTinSanPham.UseVisualStyleBackColor = false;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.Red;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaSanPham.Location = new System.Drawing.Point(488, 137);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(235, 44);
            this.btnXoaSanPham.TabIndex = 11;
            this.btnXoaSanPham.Text = "Xóa sản phẩm ";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(488, 8);
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(235, 44);
            this.btnTimKiemSanPham.TabIndex = 12;
            this.btnTimKiemSanPham.Text = "Tìm kiếm sản phẩm ";
            this.btnTimKiemSanPham.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.btnTimKiemSanPham);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.btnSuaThongTinSanPham);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGiaHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoaiHoa);
            this.Controls.Add(this.cmbLoaiHoa);
            this.Controls.Add(this.dataProduct);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.ComboBox cmbLoaiHoa;
        private System.Windows.Forms.Label LoaiHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnSuaThongTinSanPham;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnTimKiemSanPham;
    }
}