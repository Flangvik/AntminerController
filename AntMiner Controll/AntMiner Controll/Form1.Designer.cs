namespace AntMiner_Controll
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MinerListBox = new System.Windows.Forms.ListBox();
            this.ExecBtn = new System.Windows.Forms.Button();
            this.Pool1URLText = new System.Windows.Forms.TextBox();
            this.Pool1WorkerText = new System.Windows.Forms.TextBox();
            this.Pool1PWText = new System.Windows.Forms.TextBox();
            this.Pool2PWText = new System.Windows.Forms.TextBox();
            this.Pool2WorkerText = new System.Windows.Forms.TextBox();
            this.Pool2URLText = new System.Windows.Forms.TextBox();
            this.Pool3PWText = new System.Windows.Forms.TextBox();
            this.Pool3WorkerText = new System.Windows.Forms.TextBox();
            this.Pool3URLText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.IPText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.CredsChkBox = new System.Windows.Forms.CheckBox();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FanChkbox = new System.Windows.Forms.CheckBox();
            this.FanSpeedNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DonationsLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeedNum)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinerListBox
            // 
            this.MinerListBox.FormattingEnabled = true;
            this.MinerListBox.ItemHeight = 16;
            this.MinerListBox.Location = new System.Drawing.Point(507, 53);
            this.MinerListBox.Name = "MinerListBox";
            this.MinerListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.MinerListBox.Size = new System.Drawing.Size(327, 308);
            this.MinerListBox.TabIndex = 0;
            this.MinerListBox.SelectedIndexChanged += new System.EventHandler(this.MinerListBox_SelectedIndexChanged);
            // 
            // ExecBtn
            // 
            this.ExecBtn.Location = new System.Drawing.Point(88, 371);
            this.ExecBtn.Name = "ExecBtn";
            this.ExecBtn.Size = new System.Drawing.Size(109, 24);
            this.ExecBtn.TabIndex = 1;
            this.ExecBtn.Text = "Execute";
            this.ExecBtn.UseVisualStyleBackColor = true;
            this.ExecBtn.Click += new System.EventHandler(this.ExecBtn_Click);
            // 
            // Pool1URLText
            // 
            this.Pool1URLText.Location = new System.Drawing.Point(88, 56);
            this.Pool1URLText.Name = "Pool1URLText";
            this.Pool1URLText.Size = new System.Drawing.Size(376, 22);
            this.Pool1URLText.TabIndex = 2;
            // 
            // Pool1WorkerText
            // 
            this.Pool1WorkerText.Location = new System.Drawing.Point(88, 84);
            this.Pool1WorkerText.Name = "Pool1WorkerText";
            this.Pool1WorkerText.Size = new System.Drawing.Size(376, 22);
            this.Pool1WorkerText.TabIndex = 3;
            // 
            // Pool1PWText
            // 
            this.Pool1PWText.Location = new System.Drawing.Point(88, 112);
            this.Pool1PWText.Name = "Pool1PWText";
            this.Pool1PWText.Size = new System.Drawing.Size(376, 22);
            this.Pool1PWText.TabIndex = 4;
            // 
            // Pool2PWText
            // 
            this.Pool2PWText.Location = new System.Drawing.Point(88, 224);
            this.Pool2PWText.Name = "Pool2PWText";
            this.Pool2PWText.Size = new System.Drawing.Size(376, 22);
            this.Pool2PWText.TabIndex = 7;
            // 
            // Pool2WorkerText
            // 
            this.Pool2WorkerText.Location = new System.Drawing.Point(88, 196);
            this.Pool2WorkerText.Name = "Pool2WorkerText";
            this.Pool2WorkerText.Size = new System.Drawing.Size(376, 22);
            this.Pool2WorkerText.TabIndex = 6;
            // 
            // Pool2URLText
            // 
            this.Pool2URLText.Location = new System.Drawing.Point(88, 168);
            this.Pool2URLText.Name = "Pool2URLText";
            this.Pool2URLText.Size = new System.Drawing.Size(376, 22);
            this.Pool2URLText.TabIndex = 5;
            // 
            // Pool3PWText
            // 
            this.Pool3PWText.Location = new System.Drawing.Point(88, 339);
            this.Pool3PWText.Name = "Pool3PWText";
            this.Pool3PWText.Size = new System.Drawing.Size(376, 22);
            this.Pool3PWText.TabIndex = 10;
            // 
            // Pool3WorkerText
            // 
            this.Pool3WorkerText.Location = new System.Drawing.Point(88, 311);
            this.Pool3WorkerText.Name = "Pool3WorkerText";
            this.Pool3WorkerText.Size = new System.Drawing.Size(376, 22);
            this.Pool3WorkerText.TabIndex = 9;
            this.Pool3WorkerText.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // Pool3URLText
            // 
            this.Pool3URLText.Location = new System.Drawing.Point(88, 283);
            this.Pool3URLText.Name = "Pool3URLText";
            this.Pool3URLText.Size = new System.Drawing.Size(376, 22);
            this.Pool3URLText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Worker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pool 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Pool 2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Pool 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Worker";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "URL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Worker";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "URL";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(759, 370);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 24);
            this.AddBtn.TabIndex = 28;
            this.AddBtn.Text = "Add ";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(504, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Miner list:";
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(534, 372);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(219, 22);
            this.IPText.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(504, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "IP:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(209, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 413);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Username";
            // 
            // UsernameText
            // 
            this.UsernameText.Enabled = false;
            this.UsernameText.Location = new System.Drawing.Point(88, 410);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(115, 22);
            this.UsernameText.TabIndex = 34;
            this.UsernameText.Text = "root";
            // 
            // PasswordText
            // 
            this.PasswordText.Enabled = false;
            this.PasswordText.Location = new System.Drawing.Point(284, 410);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(115, 22);
            this.PasswordText.TabIndex = 35;
            this.PasswordText.Text = "admin";
            // 
            // CredsChkBox
            // 
            this.CredsChkBox.AutoSize = true;
            this.CredsChkBox.Checked = true;
            this.CredsChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CredsChkBox.Location = new System.Drawing.Point(416, 411);
            this.CredsChkBox.Name = "CredsChkBox";
            this.CredsChkBox.Size = new System.Drawing.Size(240, 21);
            this.CredsChkBox.TabIndex = 36;
            this.CredsChkBox.Text = "Default Antminer SSH credentials";
            this.CredsChkBox.UseVisualStyleBackColor = true;
            this.CredsChkBox.CheckedChanged += new System.EventHandler(this.CredsChkBox_CheckedChanged);
            // 
            // LogText
            // 
            this.LogText.Location = new System.Drawing.Point(12, 441);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(822, 228);
            this.LogText.TabIndex = 38;
            this.LogText.Text = "";
            this.LogText.TextChanged += new System.EventHandler(this.LogText_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FanChkbox
            // 
            this.FanChkbox.AutoSize = true;
            this.FanChkbox.Location = new System.Drawing.Point(221, 373);
            this.FanChkbox.Name = "FanChkbox";
            this.FanChkbox.Size = new System.Drawing.Size(117, 21);
            this.FanChkbox.TabIndex = 39;
            this.FanChkbox.Text = "Custom fan %";
            this.FanChkbox.UseVisualStyleBackColor = true;
            this.FanChkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FanSpeedNum
            // 
            this.FanSpeedNum.Enabled = false;
            this.FanSpeedNum.Location = new System.Drawing.Point(344, 372);
            this.FanSpeedNum.Name = "FanSpeedNum";
            this.FanSpeedNum.Size = new System.Drawing.Size(120, 22);
            this.FanSpeedNum.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 41;
            this.button1.Text = "Clear Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 27);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DonationsLabel
            // 
            this.DonationsLabel.AutoSize = true;
            this.DonationsLabel.Location = new System.Drawing.Point(11, 677);
            this.DonationsLabel.Name = "DonationsLabel";
            this.DonationsLabel.Size = new System.Drawing.Size(383, 17);
            this.DonationsLabel.TabIndex = 42;
            this.DonationsLabel.Text = "Enjoying this tool? Feel free to buy me a beer ~ Skiddietech";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 696);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(701, 17);
            this.label17.TabIndex = 43;
            this.label17.Text = "BTC: 1BeMFAiHXSZgUWeuSvzjGXFQa3sGv2rS8L ETH: 0x9fe407B0D3fBf652154f33b000B50E1437" +
    "eA681B  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 722);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DonationsLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FanSpeedNum);
            this.Controls.Add(this.FanChkbox);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CredsChkBox);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pool3PWText);
            this.Controls.Add(this.Pool3WorkerText);
            this.Controls.Add(this.Pool3URLText);
            this.Controls.Add(this.Pool2PWText);
            this.Controls.Add(this.Pool2WorkerText);
            this.Controls.Add(this.Pool2URLText);
            this.Controls.Add(this.Pool1PWText);
            this.Controls.Add(this.Pool1WorkerText);
            this.Controls.Add(this.Pool1URLText);
            this.Controls.Add(this.ExecBtn);
            this.Controls.Add(this.MinerListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Antminer Controller By SkiddieTech";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeedNum)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExecBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ListBox MinerListBox;
        public System.Windows.Forms.TextBox Pool1URLText;
        public System.Windows.Forms.TextBox Pool1WorkerText;
        public System.Windows.Forms.TextBox Pool1PWText;
        public System.Windows.Forms.TextBox Pool2PWText;
        public System.Windows.Forms.TextBox Pool2WorkerText;
        public System.Windows.Forms.TextBox Pool2URLText;
        public System.Windows.Forms.TextBox Pool3PWText;
        public System.Windows.Forms.TextBox Pool3WorkerText;
        public System.Windows.Forms.TextBox Pool3URLText;
        public System.Windows.Forms.TextBox IPText;
        public System.Windows.Forms.RichTextBox LogText;
        public System.Windows.Forms.CheckBox FanChkbox;
        public System.Windows.Forms.NumericUpDown FanSpeedNum;
        public System.Windows.Forms.TextBox UsernameText;
        public System.Windows.Forms.TextBox PasswordText;
        public System.Windows.Forms.CheckBox CredsChkBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label DonationsLabel;
        private System.Windows.Forms.Label label17;
    }
}

