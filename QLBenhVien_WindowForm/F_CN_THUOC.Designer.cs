namespace QLBenhVien_UD
{
    partial class F_CN_THUOC
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
            this.tb_MaNCC = new System.Windows.Forms.TextBox();
            this.tb_tenThuoc = new System.Windows.Forms.TextBox();
            this.tb_MaThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.dgv_THUOC_show = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_THUOC_show)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MaNCC
            // 
            this.tb_MaNCC.Location = new System.Drawing.Point(113, 87);
            this.tb_MaNCC.Name = "tb_MaNCC";
            this.tb_MaNCC.Size = new System.Drawing.Size(145, 20);
            this.tb_MaNCC.TabIndex = 33;
            // 
            // tb_tenThuoc
            // 
            this.tb_tenThuoc.Location = new System.Drawing.Point(113, 56);
            this.tb_tenThuoc.Name = "tb_tenThuoc";
            this.tb_tenThuoc.Size = new System.Drawing.Size(146, 20);
            this.tb_tenThuoc.TabIndex = 32;
            // 
            // tb_MaThuoc
            // 
            this.tb_MaThuoc.Location = new System.Drawing.Point(113, 16);
            this.tb_MaThuoc.Name = "tb_MaThuoc";
            this.tb_MaThuoc.Size = new System.Drawing.Size(146, 20);
            this.tb_MaThuoc.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên Thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Thuốc";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(555, 92);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(70, 30);
            this.bt_Xoa.TabIndex = 27;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(555, 56);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(70, 30);
            this.bt_Sua.TabIndex = 26;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(555, 19);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(70, 30);
            this.bt_Them.TabIndex = 25;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // dgv_THUOC_show
            // 
            this.dgv_THUOC_show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_THUOC_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_THUOC_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_THUOC_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_THUOC_show.Location = new System.Drawing.Point(0, 145);
            this.dgv_THUOC_show.Name = "dgv_THUOC_show";
            this.dgv_THUOC_show.ReadOnly = true;
            this.dgv_THUOC_show.Size = new System.Drawing.Size(637, 253);
            this.dgv_THUOC_show.TabIndex = 24;
            this.dgv_THUOC_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_THUOC_show_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Số Lượng";
            // 
            // tb_SL
            // 
            this.tb_SL.Location = new System.Drawing.Point(395, 29);
            this.tb_SL.Name = "tb_SL";
            this.tb_SL.Size = new System.Drawing.Size(145, 20);
            this.tb_SL.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Giá Thuốc";
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(395, 73);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(145, 20);
            this.tb_Gia.TabIndex = 37;
            // 
            // F_CN_THUOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 398);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_SL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_MaNCC);
            this.Controls.Add(this.tb_tenThuoc);
            this.Controls.Add(this.tb_MaThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.dgv_THUOC_show);
            this.Name = "F_CN_THUOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_THUOC_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MaNCC;
        private System.Windows.Forms.TextBox tb_tenThuoc;
        private System.Windows.Forms.TextBox tb_MaThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.DataGridView dgv_THUOC_show;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Gia;
    }
}