namespace DVLDMySolution
{
    partial class AddOrderOfLicense
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Crea_Lap = new System.Windows.Forms.Label();
            this.Fees_lap = new System.Windows.Forms.Label();
            this.DAte_LA = new System.Windows.Forms.Label();
            this.IDAPP_LA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save_But = new System.Windows.Forms.Button();
            this.Close_But = new System.Windows.Forms.Button();
            this.filter1 = new DVLDMySolution.Filter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Local Driving Liecnse Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 345);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.filter1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.Crea_Lap);
            this.tabPage2.Controls.Add(this.Fees_lap);
            this.tabPage2.Controls.Add(this.DAte_LA);
            this.tabPage2.Controls.Add(this.IDAPP_LA);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Class 1 - Small Motorcycle",
            "Class 2 - Heavy Motorcycle License",
            "Class 3 - Ordinary driving license",
            "Class 4 - Commercial",
            "Class 5 - Agricultural",
            "Class 6 - Small and medium bus",
            "Class 7 - Truck and heavy vehicle"});
            this.comboBox1.Location = new System.Drawing.Point(205, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Crea_Lap
            // 
            this.Crea_Lap.AutoSize = true;
            this.Crea_Lap.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crea_Lap.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Crea_Lap.Location = new System.Drawing.Point(202, 224);
            this.Crea_Lap.Name = "Crea_Lap";
            this.Crea_Lap.Size = new System.Drawing.Size(128, 19);
            this.Crea_Lap.TabIndex = 8;
            this.Crea_Lap.Text = "Created  BY      :";
            // 
            // Fees_lap
            // 
            this.Fees_lap.AutoSize = true;
            this.Fees_lap.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees_lap.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Fees_lap.Location = new System.Drawing.Point(202, 188);
            this.Fees_lap.Name = "Fees_lap";
            this.Fees_lap.Size = new System.Drawing.Size(128, 19);
            this.Fees_lap.TabIndex = 7;
            this.Fees_lap.Text = "Created  BY      :";
            // 
            // DAte_LA
            // 
            this.DAte_LA.AutoSize = true;
            this.DAte_LA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.DAte_LA.ForeColor = System.Drawing.Color.DarkOrchid;
            this.DAte_LA.Location = new System.Drawing.Point(202, 98);
            this.DAte_LA.Name = "DAte_LA";
            this.DAte_LA.Size = new System.Drawing.Size(109, 20);
            this.DAte_LA.TabIndex = 6;
            this.DAte_LA.Text = "Created  BY      :";
            // 
            // IDAPP_LA
            // 
            this.IDAPP_LA.AutoSize = true;
            this.IDAPP_LA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDAPP_LA.ForeColor = System.Drawing.Color.DarkOrchid;
            this.IDAPP_LA.Location = new System.Drawing.Point(202, 56);
            this.IDAPP_LA.Name = "IDAPP_LA";
            this.IDAPP_LA.Size = new System.Drawing.Size(33, 20);
            this.IDAPP_LA.TabIndex = 5;
            this.IDAPP_LA.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(47, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created  BY      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(47, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fees     :   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(47, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class           : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(47, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L Application ID :";
            // 
            // Save_But
            // 
            this.Save_But.BackColor = System.Drawing.Color.DarkOrchid;
            this.Save_But.FlatAppearance.BorderSize = 0;
            this.Save_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_But.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_But.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save_But.Location = new System.Drawing.Point(515, 429);
            this.Save_But.Name = "Save_But";
            this.Save_But.Size = new System.Drawing.Size(77, 39);
            this.Save_But.TabIndex = 7;
            this.Save_But.Text = "Save";
            this.Save_But.UseVisualStyleBackColor = false;
            this.Save_But.Click += new System.EventHandler(this.Save_But_Click);
            // 
            // Close_But
            // 
            this.Close_But.BackColor = System.Drawing.Color.DarkOrchid;
            this.Close_But.FlatAppearance.BorderSize = 0;
            this.Close_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_But.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_But.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close_But.Location = new System.Drawing.Point(426, 429);
            this.Close_But.Name = "Close_But";
            this.Close_But.Size = new System.Drawing.Size(77, 39);
            this.Close_But.TabIndex = 6;
            this.Close_But.Text = "Close";
            this.Close_But.UseVisualStyleBackColor = false;
            this.Close_But.Click += new System.EventHandler(this.Close_But_Click);
            // 
            // filter1
            // 
            this.filter1.Location = new System.Drawing.Point(-3, 0);
            this.filter1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(610, 367);
            this.filter1.TabIndex = 0;
            // 
            // AddLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(621, 487);
            this.Controls.Add(this.Save_But);
            this.Controls.Add(this.Close_But);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add License Secren ";
            this.Load += new System.EventHandler(this.AddLicense_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Filter filter1;
        private System.Windows.Forms.Button Save_But;
        private System.Windows.Forms.Button Close_But;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Crea_Lap;
        private System.Windows.Forms.Label Fees_lap;
        private System.Windows.Forms.Label DAte_LA;
        private System.Windows.Forms.Label IDAPP_LA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}