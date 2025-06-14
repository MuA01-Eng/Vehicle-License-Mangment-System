namespace DVLDMySolution
{
    partial class Filter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddPepole_But = new System.Windows.Forms.Button();
            this.Search_But = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Date_ = new System.Windows.Forms.Label();
            this.Country_L = new System.Windows.Forms.Label();
            this.Phone_L = new System.Windows.Forms.Label();
            this.ADdress_L = new System.Windows.Forms.Label();
            this.Email_L = new System.Windows.Forms.Label();
            this.Gender_l = new System.Windows.Forms.Label();
            this.No_L = new System.Windows.Forms.Label();
            this.Name_L = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddPepole_But);
            this.groupBox1.Controls.Add(this.Search_But);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // AddPepole_But
            // 
            this.AddPepole_But.Image = global::DVLDMySolution.Properties.Resources.Add_New;
            this.AddPepole_But.Location = new System.Drawing.Point(427, 18);
            this.AddPepole_But.Name = "AddPepole_But";
            this.AddPepole_But.Size = new System.Drawing.Size(40, 37);
            this.AddPepole_But.TabIndex = 9;
            this.AddPepole_But.UseVisualStyleBackColor = true;
            this.AddPepole_But.Click += new System.EventHandler(this.AddPepole_But_Click);
            // 
            // Search_But
            // 
            this.Search_But.FlatAppearance.BorderSize = 0;
            this.Search_But.Image = ((System.Drawing.Image)(resources.GetObject("Search_But.Image")));
            this.Search_But.Location = new System.Drawing.Point(371, 18);
            this.Search_But.Name = "Search_But";
            this.Search_But.Size = new System.Drawing.Size(40, 37);
            this.Search_But.TabIndex = 8;
            this.Search_But.UseVisualStyleBackColor = true;
            this.Search_But.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 23);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Person ID",
            "National NO"});
            this.comboBox1.Location = new System.Drawing.Point(88, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Date_);
            this.groupBox2.Controls.Add(this.Country_L);
            this.groupBox2.Controls.Add(this.Phone_L);
            this.groupBox2.Controls.Add(this.ADdress_L);
            this.groupBox2.Controls.Add(this.Email_L);
            this.groupBox2.Controls.Add(this.Gender_l);
            this.groupBox2.Controls.Add(this.No_L);
            this.groupBox2.Controls.Add(this.Name_L);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.groupBox2.Location = new System.Drawing.Point(8, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 225);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Info";
            // 
            // Date_
            // 
            this.Date_.AutoSize = true;
            this.Date_.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Date_.Location = new System.Drawing.Point(362, 77);
            this.Date_.Name = "Date_";
            this.Date_.Size = new System.Drawing.Size(19, 13);
            this.Date_.TabIndex = 69;
            this.Date_.Text = "??";
            // 
            // Country_L
            // 
            this.Country_L.AutoSize = true;
            this.Country_L.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country_L.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Country_L.Location = new System.Drawing.Point(362, 162);
            this.Country_L.Name = "Country_L";
            this.Country_L.Size = new System.Drawing.Size(19, 13);
            this.Country_L.TabIndex = 68;
            this.Country_L.Text = "??";
            // 
            // Phone_L
            // 
            this.Phone_L.AutoSize = true;
            this.Phone_L.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_L.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Phone_L.Location = new System.Drawing.Point(362, 124);
            this.Phone_L.Name = "Phone_L";
            this.Phone_L.Size = new System.Drawing.Size(19, 13);
            this.Phone_L.TabIndex = 67;
            this.Phone_L.Text = "??";
            // 
            // ADdress_L
            // 
            this.ADdress_L.AutoSize = true;
            this.ADdress_L.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADdress_L.ForeColor = System.Drawing.Color.DarkOrchid;
            this.ADdress_L.Location = new System.Drawing.Point(113, 198);
            this.ADdress_L.Name = "ADdress_L";
            this.ADdress_L.Size = new System.Drawing.Size(19, 13);
            this.ADdress_L.TabIndex = 66;
            this.ADdress_L.Text = "??";
            // 
            // Email_L
            // 
            this.Email_L.AutoSize = true;
            this.Email_L.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_L.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Email_L.Location = new System.Drawing.Point(112, 162);
            this.Email_L.Name = "Email_L";
            this.Email_L.Size = new System.Drawing.Size(19, 13);
            this.Email_L.TabIndex = 65;
            this.Email_L.Text = "??";
            // 
            // Gender_l
            // 
            this.Gender_l.AutoSize = true;
            this.Gender_l.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_l.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Gender_l.Location = new System.Drawing.Point(112, 124);
            this.Gender_l.Name = "Gender_l";
            this.Gender_l.Size = new System.Drawing.Size(19, 13);
            this.Gender_l.TabIndex = 64;
            this.Gender_l.Text = "??";
            // 
            // No_L
            // 
            this.No_L.AutoSize = true;
            this.No_L.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_L.ForeColor = System.Drawing.Color.DarkOrchid;
            this.No_L.Location = new System.Drawing.Point(130, 77);
            this.No_L.Name = "No_L";
            this.No_L.Size = new System.Drawing.Size(19, 13);
            this.No_L.TabIndex = 63;
            this.No_L.Text = "??";
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_L.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Name_L.Location = new System.Drawing.Point(112, 43);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(19, 13);
            this.Name_L.TabIndex = 62;
            this.Name_L.Text = "??";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDMySolution.Properties.Resources.Administrator_Male;
            this.pictureBox1.Location = new System.Drawing.Point(469, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label9.Location = new System.Drawing.Point(295, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Country : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(308, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(40, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "National NO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(37, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(37, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label7.Location = new System.Drawing.Point(271, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Date Of Birth :";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(612, 367);
            this.Load += new System.EventHandler(this.Filter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddPepole_But;
        private System.Windows.Forms.Button Search_But;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Date_;
        private System.Windows.Forms.Label Country_L;
        private System.Windows.Forms.Label Phone_L;
        private System.Windows.Forms.Label ADdress_L;
        private System.Windows.Forms.Label Email_L;
        private System.Windows.Forms.Label Gender_l;
        private System.Windows.Forms.Label No_L;
        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}
