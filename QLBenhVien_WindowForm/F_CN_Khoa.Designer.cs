namespace QLBenhVien_UD
{
    partial class F_CN_Khoa
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
            this.dgv_Khoa_show = new System.Windows.Forms.DataGridView();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xóa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MaKhoa = new System.Windows.Forms.TextBox();
            this.tb_tenKhoa = new System.Windows.Forms.TextBox();
            this.tb_SL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Khoa_show
            // 
            this.dgv_Khoa_show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Khoa_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Khoa_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khoa_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Khoa_show.Location = new System.Drawing.Point(0, 178);
            this.dgv_Khoa_show.Name = "dgv_Khoa_show";
            this.dgv_Khoa_show.ReadOnly = true;
            this.dgv_Khoa_show.Size = new System.Drawing.Size(404, 220);
            this.dgv_Khoa_show.TabIndex = 3;
            this.dgv_Khoa_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Khoa_show_CellClick);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(291, 70);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(70, 30);
            this.bt_Them.TabIndex = 4;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(291, 106);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(70, 30);
            this.bt_Sua.TabIndex = 5;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Xóa
            // 
            this.bt_Xóa.Location = new System.Drawing.Point(291, 142);
            this.bt_Xóa.Name = "bt_Xóa";
            this.bt_Xóa.Size = new System.Drawing.Size(70, 30);
            this.bt_Xóa.TabIndex = 6;
            this.bt_Xóa.Text = "Xóa";
            this.bt_Xóa.UseVisualStyleBackColor = true;
            this.bt_Xóa.Click += new System.EventHandler(this.bt_Xóa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số Nhân Viên";
            // 
            // tb_MaKhoa
            // 
            this.tb_MaKhoa.Location = new System.Drawing.Point(90, 72);
            this.tb_MaKhoa.Name = "tb_MaKhoa";
            this.tb_MaKhoa.Size = new System.Drawing.Size(146, 20);
            this.tb_MaKhoa.TabIndex = 11;
            // 
            // tb_tenKhoa
            // 
            this.tb_tenKhoa.Location = new System.Drawing.Point(90, 107);
            this.tb_tenKhoa.Name = "tb_tenKhoa";
            this.tb_tenKhoa.Size = new System.Drawing.Size(146, 20);
            this.tb_tenKhoa.TabIndex = 12;
            // 
            // tb_SL
            // 
            this.tb_SL.Location = new System.Drawing.Point(91, 138);
            this.tb_SL.Name = "tb_SL";
            this.tb_SL.Size = new System.Drawing.Size(145, 20);
            this.tb_SL.TabIndex = 13;
            // 
            // F_CN_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 398);
            this.Controls.Add(this.tb_SL);
            this.Controls.Add(this.tb_tenKhoa);
            this.Controls.Add(this.tb_MaKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Xóa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.dgv_Khoa_show);
            this.Name = "F_CN_Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Khoa_show;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xóa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MaKhoa;
        private System.Windows.Forms.TextBox tb_tenKhoa;
        private System.Windows.Forms.TextBox tb_SL;
    }
}