namespace Remote_Microtik
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bacaLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 0;
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
            this.bacaLogToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // bacaLogToolStripMenuItem
            // 
            this.bacaLogToolStripMenuItem.Name = "bacaLogToolStripMenuItem";
            this.bacaLogToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.bacaLogToolStripMenuItem.Text = "baca log";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStatisticToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logoutToolStripMenuItem.Text = "Statistic";
            // 
            // viewStatisticToolStripMenuItem
            // 
            this.viewStatisticToolStripMenuItem.Name = "viewStatisticToolStripMenuItem";
            this.viewStatisticToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.viewStatisticToolStripMenuItem.Text = "view statistic";
            this.viewStatisticToolStripMenuItem.Click += new System.EventHandler(this.statistik);
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Log Microtik - Smart Microtik";
            this.Load += new System.EventHandler(this.aa);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bacaLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tambahRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem3;
    }
}