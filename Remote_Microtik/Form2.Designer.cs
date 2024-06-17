namespace Remote_Microtik
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1_nama
            // 
            this.textBox1_nama.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1_nama.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1_nama.Location = new System.Drawing.Point(146, 17);
            this.textBox1_nama.Name = "textBox1_nama";
            this.textBox1_nama.Size = new System.Drawing.Size(68, 20);
            this.textBox1_nama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama microtik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(301, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cpu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(470, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UpTime";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(655, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Free Memory";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
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
            this.bacaLogToolStripMenuItem.Click += new System.EventHandler(this.log);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 218);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(601, 289);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 113);
            this.dataGridView1.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(616, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Aktifkan Keamanan";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1_nama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 53);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Microtik";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Monitoring Microtik - Smart Microtik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bacaLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahRuleToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}