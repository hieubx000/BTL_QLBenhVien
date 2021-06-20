namespace QLBenhVien_UD
{
    partial class F_CN_DV
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
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.tb_tenDV = new System.Windows.Forms.TextBox();
            this.tb_MaDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Xóa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.dgv_DichVu_show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu_show)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(91, 103);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(145, 20);
            this.tb_Gia.TabIndex = 23;
            // 
            // tb_tenDV
            // 
            this.tb_tenDV.Location = new System.Drawing.Point(90, 72);
            this.tb_tenDV.Name = "tb_tenDV";
            this.tb_tenDV.Size = new System.Drawing.Size(146, 20);
            this.tb_tenDV.TabIndex = 22;
            // 
            // tb_MaDV
            // 
            this.tb_MaDV.Location = new System.Drawing.Point(90, 37);
            this.tb_MaDV.Name = "tb_MaDV";
            this.tb_MaDV.Size = new System.Drawing.Size(146, 20);
            this.tb_MaDV.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Giá DV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Dịch Vụ";
            // 
            // bt_Xóa
            // 
            this.bt_Xóa.Location = new System.Drawing.Point(291, 107);
            this.bt_Xóa.Name = "bt_Xóa";
            this.bt_Xóa.Size = new System.Drawing.Size(70, 30);
            this.bt_Xóa.TabIndex = 17;
            this.bt_Xóa.Text = "Xóa";
            this.bt_Xóa.UseVisualStyleBackColor = true;
            this.bt_Xóa.Click += new System.EventHandler(this.bt_Xóa_Click);
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
            // dgv_DichVu_show
            // 
            this.dgv_DichVu_show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DichVu_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DichVu_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DichVu_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DichVu_show.Location = new System.Drawing.Point(0, 157);
            this.dgv_DichVu_show.Name = "dgv_DichVu_show";
            this.dgv_DichVu_show.ReadOnly = true;
            this.dgv_DichVu_show.Size = new System.Drawing.Size(404, 241);
            this.dgv_DichVu_show.TabIndex = 14;
            this.dgv_DichVu_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DichVu_show_CellClick);
            // 
            // F_CN_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 398);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.tb_tenDV);
            this.Controls.Add(this.tb_MaDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Xóa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.dgv_DichVu_show);
            this.Name = "F_CN_DV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Dịch Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.TextBox tb_tenDV;
        private System.Windows.Forms.TextBox tb_MaDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Xóa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.DataGridView dgv_DichVu_show;
    }
}