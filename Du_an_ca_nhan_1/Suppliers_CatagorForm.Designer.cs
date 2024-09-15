namespace Du_an_ca_nhan_1
{
    partial class Suppliers_CatagorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtGiaHoa = new System.Windows.Forms.TextBox();
            this.txtTenHoa = new System.Windows.Forms.TextBox();
            this.cmbLoaiHoa = new System.Windows.Forms.ComboBox();
            this.btnThemHoa = new System.Windows.Forms.Button();
            this.btnSuaHoa = new System.Windows.Forms.Button();
            this.btnXoaHoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeNhapHang = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Hoa : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(97, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Hoa : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(97, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Hoa : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(97, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng : ";
            // 
            // nbrSoLuong
            // 
            this.nbrSoLuong.Location = new System.Drawing.Point(193, 143);
            this.nbrSoLuong.Name = "nbrSoLuong";
            this.nbrSoLuong.Size = new System.Drawing.Size(120, 22);
            this.nbrSoLuong.TabIndex = 4;
            // 
            // txtGiaHoa
            // 
            this.txtGiaHoa.Location = new System.Drawing.Point(193, 104);
            this.txtGiaHoa.Name = "txtGiaHoa";
            this.txtGiaHoa.Size = new System.Drawing.Size(163, 22);
            this.txtGiaHoa.TabIndex = 5;
            // 
            // txtTenHoa
            // 
            this.txtTenHoa.Location = new System.Drawing.Point(193, 59);
            this.txtTenHoa.Name = "txtTenHoa";
            this.txtTenHoa.Size = new System.Drawing.Size(163, 22);
            this.txtTenHoa.TabIndex = 6;
            // 
            // cmbLoaiHoa
            // 
            this.cmbLoaiHoa.FormattingEnabled = true;
            this.cmbLoaiHoa.Items.AddRange(new object[] {
            "Hoa Khô ",
            "Hoa Sáp ",
            "Hoa Handmade"});
            this.cmbLoaiHoa.Location = new System.Drawing.Point(192, 16);
            this.cmbLoaiHoa.Name = "cmbLoaiHoa";
            this.cmbLoaiHoa.Size = new System.Drawing.Size(164, 24);
            this.cmbLoaiHoa.TabIndex = 7;
            // 
            // btnThemHoa
            // 
            this.btnThemHoa.Location = new System.Drawing.Point(718, 20);
            this.btnThemHoa.Name = "btnThemHoa";
            this.btnThemHoa.Size = new System.Drawing.Size(162, 39);
            this.btnThemHoa.TabIndex = 8;
            this.btnThemHoa.Text = "Thêm hoa mới ";
            this.btnThemHoa.UseVisualStyleBackColor = true;
            this.btnThemHoa.Click += new System.EventHandler(this.btnThemHoa_Click);
            // 
            // btnSuaHoa
            // 
            this.btnSuaHoa.Location = new System.Drawing.Point(718, 81);
            this.btnSuaHoa.Name = "btnSuaHoa";
            this.btnSuaHoa.Size = new System.Drawing.Size(162, 39);
            this.btnSuaHoa.TabIndex = 9;
            this.btnSuaHoa.Text = "Sửa thông tin hoa ";
            this.btnSuaHoa.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoa
            // 
            this.btnXoaHoa.Location = new System.Drawing.Point(718, 145);
            this.btnXoaHoa.Name = "btnXoaHoa";
            this.btnXoaHoa.Size = new System.Drawing.Size(162, 39);
            this.btnXoaHoa.TabIndex = 10;
            this.btnXoaHoa.Text = "Xóa hoa ";
            this.btnXoaHoa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(53, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhà cung cấp  : ";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(191, 185);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(164, 24);
            this.cmbSuppliers.TabIndex = 12;
            this.cmbSuppliers.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(4, 230);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(937, 215);
            this.data.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(374, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày nhập hàng: ";
            // 
            // dateTimeNhapHang
            // 
            this.dateTimeNhapHang.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNhapHang.CustomFormat = "yyyy/MM/dd";
            this.dateTimeNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimeNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNhapHang.Location = new System.Drawing.Point(378, 185);
            this.dateTimeNhapHang.Name = "dateTimeNhapHang";
            this.dateTimeNhapHang.Size = new System.Drawing.Size(164, 24);
            this.dateTimeNhapHang.TabIndex = 15;
            // 
            // Suppliers_CatagorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.dateTimeNhapHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoaHoa);
            this.Controls.Add(this.btnSuaHoa);
            this.Controls.Add(this.btnThemHoa);
            this.Controls.Add(this.cmbLoaiHoa);
            this.Controls.Add(this.txtTenHoa);
            this.Controls.Add(this.txtGiaHoa);
            this.Controls.Add(this.nbrSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Suppliers_CatagorForm";
            this.Text = "Nhập hoa mới ";
            this.Load += new System.EventHandler(this.Suppliers_CatagorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbrSoLuong;
        private System.Windows.Forms.TextBox txtGiaHoa;
        private System.Windows.Forms.TextBox txtTenHoa;
        private System.Windows.Forms.ComboBox cmbLoaiHoa;
        private System.Windows.Forms.Button btnThemHoa;
        private System.Windows.Forms.Button btnSuaHoa;
        private System.Windows.Forms.Button btnXoaHoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeNhapHang;
    }
}