namespace Crystal_Report
{
    partial class fmPrint
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptOrders1 = new Crystal_Report.rptOrders();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // fmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "fmPrint";
            this.Text = "fmPrint";
            this.Load += new System.EventHandler(this.fmPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptOrders rptOrders1;
    }
}