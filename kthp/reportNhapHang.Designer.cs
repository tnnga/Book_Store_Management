﻿namespace kthp
{
    partial class reportNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportNhapHang));
            this.crwNhapHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crwNhapHang
            // 
            this.crwNhapHang.ActiveViewIndex = -1;
            this.crwNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crwNhapHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crwNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crwNhapHang.Location = new System.Drawing.Point(0, 0);
            this.crwNhapHang.Name = "crwNhapHang";
            this.crwNhapHang.Size = new System.Drawing.Size(1605, 840);
            this.crwNhapHang.TabIndex = 0;
            this.crwNhapHang.Load += new System.EventHandler(this.crwNhapHang_Load);
            // 
            // reportNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 840);
            this.Controls.Add(this.crwNhapHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý nhà sách";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crwNhapHang;
    }
}