﻿namespace kthp
{
    partial class reportHoaDon
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
            this.crw_HoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crHoaDon1 = new kthp.crHoaDon();
            this.SuspendLayout();
            // 
            // crw_HoaDon
            // 
            this.crw_HoaDon.ActiveViewIndex = 0;
            this.crw_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crw_HoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crw_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crw_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.crw_HoaDon.Name = "crw_HoaDon";
            this.crw_HoaDon.ReportSource = this.crHoaDon1;
            this.crw_HoaDon.Size = new System.Drawing.Size(1079, 890);
            this.crw_HoaDon.TabIndex = 0;
            // 
            // reportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 890);
            this.Controls.Add(this.crw_HoaDon);
            this.Name = "reportHoaDon";
            this.Text = "reportHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crw_HoaDon;
        private crHoaDon crHoaDon1;
    }
}