namespace Remote_Microtik
{
    partial class New_security
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_security));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(62, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(291, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(349, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simpan Rule";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.main);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address List name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.logToolStripMenuItem.Click += new System.EventHandler(this.log);
            // 
            // logToolStripMenuItem1
            // 
            this.logToolStripMenuItem1.Name = "logToolStripMenuItem1";
            this.logToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.logToolStripMenuItem1.Text = "Log";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logoutToolStripMenuItem.Text = "Statistic";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statistik);
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
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(62, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pesan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 328);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Rule";
            // 
            // New_security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_security";
            this.Text = "New_security - Smart  Microtik";
            this.Load += new System.EventHandler(this.New_security_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}