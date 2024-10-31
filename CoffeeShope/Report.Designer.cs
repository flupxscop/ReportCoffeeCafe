namespace CoffeeShope
{
    partial class Report
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
            this.MenuButton = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TotalSalesButton = new System.Windows.Forms.Button();
            this.crystalReport12 = new CoffeeShope.CrystalReport1();
            this.crystalReport31 = new CoffeeShope.CrystalReport3();
            this.SalesButton = new System.Windows.Forms.Button();
            this.crystalReport41 = new CoffeeShope.CrystalReport4();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(2, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 32);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1009, 778);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // TotalSalesButton
            // 
            this.TotalSalesButton.Location = new System.Drawing.Point(83, 3);
            this.TotalSalesButton.Name = "TotalSalesButton";
            this.TotalSalesButton.Size = new System.Drawing.Size(75, 23);
            this.TotalSalesButton.TabIndex = 2;
            this.TotalSalesButton.Text = "Total sales";
            this.TotalSalesButton.UseVisualStyleBackColor = true;
            this.TotalSalesButton.Click += new System.EventHandler(this.TotalSalesButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(164, 3);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(75, 23);
            this.SalesButton.TabIndex = 3;
            this.SalesButton.Text = "Sales type";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 808);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.TotalSalesButton);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.MenuButton);
            this.Name = "Report";
            this.Text = "ReportCafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport1 crystalReport12;
        private System.Windows.Forms.Button TotalSalesButton;
        private CrystalReport3 crystalReport31;
        private System.Windows.Forms.Button SalesButton;
        private CrystalReport4 crystalReport41;
    }
}

