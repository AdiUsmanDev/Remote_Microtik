namespace Remote_Microtik
{
    partial class Statistic
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1,
            this.logoutToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.home);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem1});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // logToolStripMenuItem1
            // 
            this.logToolStripMenuItem1.Name = "logToolStripMenuItem1";
            this.logToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.logToolStripMenuItem1.Text = "Log";
            this.logToolStripMenuItem1.Click += new System.EventHandler(this.log);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logoutToolStripMenuItem.Text = "Statistic";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahRuleToolStripMenuItem});
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.logoutToolStripMenuItem1.Text = "Setting Security";
            // 
            // tambahRuleToolStripMenuItem
            // 
            this.tambahRuleToolStripMenuItem.Name = "tambahRuleToolStripMenuItem";
            this.tambahRuleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tambahRuleToolStripMenuItem.Text = "Tambah Rule";
            this.tambahRuleToolStripMenuItem.Click += new System.EventHandler(this.keamanan);
            // 
            // logoutToolStripMenuItem2
            // 
            this.logoutToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem3});
            this.logoutToolStripMenuItem2.Name = "logoutToolStripMenuItem2";
            this.logoutToolStripMenuItem2.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem2.Text = "Logout";
            // 
            // logoutToolStripMenuItem3
            // 
            this.logoutToolStripMenuItem3.Name = "logoutToolStripMenuItem3";
            this.logoutToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem3.Text = "Logout";
            this.logoutToolStripMenuItem3.Click += new System.EventHandler(this.logt);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 80);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(738, 339);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistic";
            this.Text = "Satistic Microtik - Smart Microtik";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tambahRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem3;
        private System.Windows.Forms.Timer timer1;
    }
}