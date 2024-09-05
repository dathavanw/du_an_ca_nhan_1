namespace Du_an_ca_nhan_1
{
    partial class SuppliersForm
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
            this.txtDiaChiNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThemNhaCungCap = new System.Windows.Forms.Button();
            this.btnSuaNhaCungCap = new System.Windows.Forms.Button();
            this.btnXoaNhaCungCap = new System.Windows.Forms.Button();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.dataSuppliers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = " Tên nhà cung cấp :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(183, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(115, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDiaChiNhaCungCap
            // 
            this.txtDiaChiNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiNhaCungCap.Location = new System.Drawing.Point(293, 70);
            this.txtDiaChiNhaCungCap.Name = "txtDiaChiNhaCungCap";
            this.txtDiaChiNhaCungCap.Size = new System.Drawing.Size(250, 27);
            this.txtDiaChiNhaCungCap.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(293, 109);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 27);
            this.txtSDT.TabIndex = 4;
            // 
            // btnThemNhaCungCap
            // 
            this.btnThemNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhaCungCap.Location = new System.Drawing.Point(676, 28);
            this.btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            this.btnThemNhaCungCap.Size = new System.Drawing.Size(194, 40);
            this.btnThemNhaCungCap.TabIndex = 5;
            this.btnThemNhaCungCap.Text = "Thêm nhà cung cấp ";
            this.btnThemNhaCungCap.UseVisualStyleBackColor = true;
            this.btnThemNhaCungCap.Click += new System.EventHandler(this.btnThemNhaCungCap_Click);
            // 
            // btnSuaNhaCungCap
            // 
            this.btnSuaNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhaCungCap.Location = new System.Drawing.Point(676, 77);
            this.btnSuaNhaCungCap.Name = "btnSuaNhaCungCap";
            this.btnSuaNhaCungCap.Size = new System.Drawing.Size(194, 40);
            this.btnSuaNhaCungCap.TabIndex = 6;
            this.btnSuaNhaCungCap.Text = "Sửa nhà cung cấp";
            this.btnSuaNhaCungCap.UseVisualStyleBackColor = true;
            this.btnSuaNhaCungCap.Click += new System.EventHandler(this.btnSuaNhaCungCap_Click);
            // 
            // btnXoaNhaCungCap
            // 
            this.btnXoaNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhaCungCap.Location = new System.Drawing.Point(676, 123);
            this.btnXoaNhaCungCap.Name = "btnXoaNhaCungCap";
            this.btnXoaNhaCungCap.Size = new System.Drawing.Size(194, 40);
            this.btnXoaNhaCungCap.TabIndex = 7;
            this.btnXoaNhaCungCap.Text = "Xóa nhà cung cấp";
            this.btnXoaNhaCungCap.UseVisualStyleBackColor = true;
            this.btnXoaNhaCungCap.Click += new System.EventHandler(this.btnXoaNhaCungCap_Click);
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhaCungCap.Location = new System.Drawing.Point(293, 28);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(250, 27);
            this.txtNhaCungCap.TabIndex = 8;
            // 
            // dataSuppliers
            // 
            this.dataSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSuppliers.Location = new System.Drawing.Point(3, 181);
            this.dataSuppliers.Name = "dataSuppliers";
            this.dataSuppliers.RowHeadersWidth = 51;
            this.dataSuppliers.RowTemplate.Height = 24;
            this.dataSuppliers.Size = new System.Drawing.Size(1029, 264);
            this.dataSuppliers.TabIndex = 9;
            this.dataSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSuppliers_CellClick);
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.dataSuppliers);
            this.Controls.Add(this.txtNhaCungCap);
            this.Controls.Add(this.btnXoaNhaCungCap);
            this.Controls.Add(this.btnSuaNhaCungCap);
            this.Controls.Add(this.btnThemNhaCungCap);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChiNhaCungCap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuppliersForm";
            this.Text = "SuppliersForm";
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChiNhaCungCap;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThemNhaCungCap;
        private System.Windows.Forms.Button btnSuaNhaCungCap;
        private System.Windows.Forms.Button btnXoaNhaCungCap;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.DataGridView dataSuppliers;
    }
}