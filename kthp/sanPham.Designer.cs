﻿namespace kthp
{
    partial class sanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLoaiSach = new System.Windows.Forms.ComboBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLocLoaiSach = new System.Windows.Forms.Label();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwSanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLoaiSach);
            this.panel1.Controls.Add(this.cbTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.lblLocLoaiSach);
            this.panel1.Controls.Add(this.lblTimKiemTheo);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnThemSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 114);
            this.panel1.TabIndex = 17;
            // 
            // cbLoaiSach
            // 
            this.cbLoaiSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSach.FormattingEnabled = true;
            this.cbLoaiSach.Location = new System.Drawing.Point(16, 61);
            this.cbLoaiSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiSach.Name = "cbLoaiSach";
            this.cbLoaiSach.Size = new System.Drawing.Size(146, 32);
            this.cbLoaiSach.TabIndex = 23;
            this.cbLoaiSach.Text = "(Lựa chọn)";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(182, 61);
            this.cbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(146, 32);
            this.cbTimKiem.TabIndex = 24;
            this.cbTimKiem.Text = "(Lựa chọn)";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(345, 61);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(419, 32);
            this.txtTimKiem.TabIndex = 22;
            // 
            // lblLocLoaiSach
            // 
            this.lblLocLoaiSach.AutoSize = true;
            this.lblLocLoaiSach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocLoaiSach.ForeColor = System.Drawing.Color.White;
            this.lblLocLoaiSach.Location = new System.Drawing.Point(12, 15);
            this.lblLocLoaiSach.Name = "lblLocLoaiSach";
            this.lblLocLoaiSach.Size = new System.Drawing.Size(155, 24);
            this.lblLocLoaiSach.TabIndex = 21;
            this.lblLocLoaiSach.Text = "Chọn loại sách";
            // 
            // lblTimKiemTheo
            // 
            this.lblTimKiemTheo.AutoSize = true;
            this.lblTimKiemTheo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemTheo.ForeColor = System.Drawing.Color.White;
            this.lblTimKiemTheo.Location = new System.Drawing.Point(178, 15);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(160, 24);
            this.lblTimKiemTheo.TabIndex = 20;
            this.lblTimKiemTheo.Text = "Tìm kiếm theo:";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(780, 54);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(115, 45);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnThemSanPham.Location = new System.Drawing.Point(901, 54);
            this.btnThemSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(115, 45);
            this.btnThemSanPham.TabIndex = 19;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 430);
            this.panel2.TabIndex = 18;
            // 
            // dgwSanPham
            // 
            this.dgwSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSanPham.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgwSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgwSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwSanPham.Name = "dgwSanPham";
            this.dgwSanPham.RowHeadersWidth = 62;
            this.dgwSanPham.RowTemplate.Height = 28;
            this.dgwSanPham.Size = new System.Drawing.Size(1018, 430);
            this.dgwSanPham.TabIndex = 17;
            // 
            // sanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1038, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sanPham";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sanPham";
            this.Load += new System.EventHandler(this.sanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLoaiSach;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLocLoaiSach;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwSanPham;
    }
}