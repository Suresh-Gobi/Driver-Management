namespace Ayubo_Drive
{
    partial class Vehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DrateTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WrateTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MrateTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VbrandCmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ACchk = new System.Windows.Forms.CheckBox();
            this.NonACchk = new System.Windows.Forms.CheckBox();
            this.VtypeTbx = new System.Windows.Forms.TextBox();
            this.FtypeCmb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.DDrateTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RegTbx = new System.Windows.Forms.TextBox();
            this.searchBtn1 = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vechile Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vechile Brand";
            // 
            // DrateTbx
            // 
            this.DrateTbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DrateTbx.Location = new System.Drawing.Point(401, 38);
            this.DrateTbx.Name = "DrateTbx";
            this.DrateTbx.Size = new System.Drawing.Size(100, 20);
            this.DrateTbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Daily Rate";
            // 
            // WrateTbx
            // 
            this.WrateTbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WrateTbx.Location = new System.Drawing.Point(401, 85);
            this.WrateTbx.Name = "WrateTbx";
            this.WrateTbx.Size = new System.Drawing.Size(100, 20);
            this.WrateTbx.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Weekly Rate";
            // 
            // MrateTbx
            // 
            this.MrateTbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MrateTbx.Location = new System.Drawing.Point(400, 137);
            this.MrateTbx.Name = "MrateTbx";
            this.MrateTbx.Size = new System.Drawing.Size(100, 20);
            this.MrateTbx.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monthly Rate";
            // 
            // VbrandCmb
            // 
            this.VbrandCmb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.VbrandCmb.FormattingEnabled = true;
            this.VbrandCmb.Location = new System.Drawing.Point(138, 132);
            this.VbrandCmb.Name = "VbrandCmb";
            this.VbrandCmb.Size = new System.Drawing.Size(121, 21);
            this.VbrandCmb.TabIndex = 14;
            this.VbrandCmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fuel Type";
            // 
            // ACchk
            // 
            this.ACchk.AutoSize = true;
            this.ACchk.Location = new System.Drawing.Point(324, 194);
            this.ACchk.Name = "ACchk";
            this.ACchk.Size = new System.Drawing.Size(40, 17);
            this.ACchk.TabIndex = 18;
            this.ACchk.Text = "AC";
            this.ACchk.UseVisualStyleBackColor = true;
            // 
            // NonACchk
            // 
            this.NonACchk.AutoSize = true;
            this.NonACchk.Location = new System.Drawing.Point(437, 192);
            this.NonACchk.Name = "NonACchk";
            this.NonACchk.Size = new System.Drawing.Size(63, 17);
            this.NonACchk.TabIndex = 19;
            this.NonACchk.Text = "Non-AC";
            this.NonACchk.UseVisualStyleBackColor = true;
            // 
            // VtypeTbx
            // 
            this.VtypeTbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.VtypeTbx.Location = new System.Drawing.Point(138, 86);
            this.VtypeTbx.Name = "VtypeTbx";
            this.VtypeTbx.Size = new System.Drawing.Size(121, 20);
            this.VtypeTbx.TabIndex = 21;
            // 
            // FtypeCmb
            // 
            this.FtypeCmb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FtypeCmb.FormattingEnabled = true;
            this.FtypeCmb.Location = new System.Drawing.Point(138, 188);
            this.FtypeCmb.Name = "FtypeCmb";
            this.FtypeCmb.Size = new System.Drawing.Size(121, 21);
            this.FtypeCmb.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(494, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 49);
            this.button3.TabIndex = 24;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DDrateTbx
            // 
            this.DDrateTbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DDrateTbx.Location = new System.Drawing.Point(138, 244);
            this.DDrateTbx.Name = "DDrateTbx";
            this.DDrateTbx.Size = new System.Drawing.Size(121, 20);
            this.DDrateTbx.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Daily Driver Rate";
            // 
            // RegTbx
            // 
            this.RegTbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RegTbx.Location = new System.Drawing.Point(138, 38);
            this.RegTbx.Name = "RegTbx";
            this.RegTbx.Size = new System.Drawing.Size(121, 20);
            this.RegTbx.TabIndex = 29;
            this.RegTbx.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // searchBtn1
            // 
            this.searchBtn1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.searchBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn1.Location = new System.Drawing.Point(34, 316);
            this.searchBtn1.Name = "searchBtn1";
            this.searchBtn1.Size = new System.Drawing.Size(93, 49);
            this.searchBtn1.TabIndex = 30;
            this.searchBtn1.Text = "Search";
            this.searchBtn1.UseVisualStyleBackColor = false;
            this.searchBtn1.Click += new System.EventHandler(this.searchBtn1_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.insertBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Location = new System.Drawing.Point(149, 316);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(93, 49);
            this.insertBtn.TabIndex = 31;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(265, 316);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(91, 49);
            this.updateBtn.TabIndex = 32;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(377, 316);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(93, 49);
            this.deleteBtn.TabIndex = 33;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(607, 399);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.searchBtn1);
            this.Controls.Add(this.RegTbx);
            this.Controls.Add(this.DDrateTbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FtypeCmb);
            this.Controls.Add(this.VtypeTbx);
            this.Controls.Add(this.NonACchk);
            this.Controls.Add(this.ACchk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VbrandCmb);
            this.Controls.Add(this.MrateTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WrateTbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DrateTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DrateTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WrateTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MrateTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox VbrandCmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ACchk;
        private System.Windows.Forms.CheckBox NonACchk;
        private System.Windows.Forms.TextBox VtypeTbx;
        private System.Windows.Forms.ComboBox FtypeCmb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox DDrateTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RegTbx;
        private System.Windows.Forms.Button searchBtn1;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

