namespace QLBenhVien_UD
{
    partial class F_CN_NCC
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
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_tenNCC = new System.Windows.Forms.TextBox();
            this.tb_MaNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.dgv_NCC_show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC_show)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(113, 103);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(145, 20);
            this.tb_DiaChi.TabIndex = 23;
            // 
            // tb_tenNCC
            // 
            this.tb_tenNCC.Location = new System.Drawing.Point(113, 72);
            this.tb_tenNCC.Name = "tb_tenNCC";
            this.tb_tenNCC.Size = new System.Drawing.Size(146, 20);
            this.tb_tenNCC.TabIndex = 22;
            // 
            // tb_MaNCC
            // 
            this.tb_MaNCC.Location = new System.Drawing.Point(113, 32);
            this.tb_MaNCC.Name = "tb_MaNCC";
            this.tb_MaNCC.Size = new System.Drawing.Size(146, 20);
            this.tb_MaNCC.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(291, 107);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(70, 30);
            this.bt_Xoa.TabIndex = 17;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(291, 71);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(70, 30);
            this.bt_Sua.TabIndex = 16;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(291, 35);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(70, 30);
            this.bt_Them.TabIndex = 15;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // dgv_NCC_show
            // 
            this.dgv_NCC_show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_NCC_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_NCC_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NCC_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_NCC_show.Location = new System.Drawing.Point(0, 178);
            this.dgv_NCC_show.Name = "dgv_NCC_show";
            this.dgv_NCC_show.ReadOnly = true;
            this.dgv_NCC_show.Size = new System.Drawing.Size(404, 220);
            this.dgv_NCC_show.TabIndex = 14;
            this.dgv_NCC_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NCC_show_CellClick);
            // 
            // F_CN_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 398);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_tenNCC);
            this.Controls.Add(this.tb_MaNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.dgv_NCC_show);
            this.Name = "F_CN_NCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_tenNCC;
        private System.Windows.Forms.TextBox tb_MaNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.DataGridView dgv_NCC_show;
    }
}