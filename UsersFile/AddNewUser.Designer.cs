namespace DVLDMySolution
{
    partial class AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filter1 = new DVLDMySolution.Filter();
            this.Next_but = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ISA_Check = new System.Windows.Forms.CheckBox();
            this.UserID_la = new System.Windows.Forms.Label();
            this.Con_Text = new System.Windows.Forms.TextBox();
            this.PAss_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_text = new System.Windows.Forms.TextBox();
            this.Close_But = new System.Windows.Forms.Button();
            this.Save_But = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.filter1);
            this.tabPage1.Controls.Add(this.Next_but);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            // 
            // filter1
            // 
            this.filter1.Location = new System.Drawing.Point(3, 7);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(612, 319);
            this.filter1.TabIndex = 4;
            // 
            // Next_but
            // 
            this.Next_but.BackColor = System.Drawing.Color.DarkOrchid;
            this.Next_but.FlatAppearance.BorderSize = 0;
            this.Next_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_but.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Next_but.Location = new System.Drawing.Point(535, 332);
            this.Next_but.Name = "Next_but";
            this.Next_but.Size = new System.Drawing.Size(77, 39);
            this.Next_but.TabIndex = 3;
            this.Next_but.Text = "Next";
            this.Next_but.UseVisualStyleBackColor = false;
            this.Next_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.ISA_Check);
            this.tabPage2.Controls.Add(this.UserID_la);
            this.tabPage2.Controls.Add(this.Con_Text);
            this.tabPage2.Controls.Add(this.PAss_text);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.User_text);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login Info";
            // 
            // ISA_Check
            // 
            this.ISA_Check.AutoSize = true;
            this.ISA_Check.Checked = true;
            this.ISA_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ISA_Check.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISA_Check.ForeColor = System.Drawing.Color.DarkOrchid;
            this.ISA_Check.Location = new System.Drawing.Point(146, 199);
            this.ISA_Check.Name = "ISA_Check";
            this.ISA_Check.Size = new System.Drawing.Size(85, 17);
            this.ISA_Check.TabIndex = 64;
            this.ISA_Check.Text = "Is Active ?";
            this.ISA_Check.UseVisualStyleBackColor = true;
            this.ISA_Check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UserID_la
            // 
            this.UserID_la.AutoSize = true;
            this.UserID_la.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID_la.ForeColor = System.Drawing.Color.DarkOrchid;
            this.UserID_la.Location = new System.Drawing.Point(143, 70);
            this.UserID_la.Name = "UserID_la";
            this.UserID_la.Size = new System.Drawing.Size(19, 13);
            this.UserID_la.TabIndex = 63;
            this.UserID_la.Text = "??";
            // 
            // Con_Text
            // 
            this.Con_Text.Location = new System.Drawing.Point(146, 163);
            this.Con_Text.Name = "Con_Text";
            this.Con_Text.Size = new System.Drawing.Size(100, 20);
            this.Con_Text.TabIndex = 62;
            this.Con_Text.Validating += new System.ComponentModel.CancelEventHandler(this.Con_Text_Validating);
            // 
            // PAss_text
            // 
            this.PAss_text.Location = new System.Drawing.Point(146, 134);
            this.PAss_text.Name = "PAss_text";
            this.PAss_text.Size = new System.Drawing.Size(100, 20);
            this.PAss_text.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(17, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Confirm Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(64, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(57, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(76, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "User ID :";
            // 
            // User_text
            // 
            this.User_text.Location = new System.Drawing.Point(146, 101);
            this.User_text.Name = "User_text";
            this.User_text.Size = new System.Drawing.Size(100, 20);
            this.User_text.TabIndex = 0;
            // 
            // Close_But
            // 
            this.Close_But.BackColor = System.Drawing.Color.DarkOrchid;
            this.Close_But.FlatAppearance.BorderSize = 0;
            this.Close_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_But.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_But.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close_But.Location = new System.Drawing.Point(466, 489);
            this.Close_But.Name = "Close_But";
            this.Close_But.Size = new System.Drawing.Size(77, 39);
            this.Close_But.TabIndex = 4;
            this.Close_But.Text = "Close";
            this.Close_But.UseVisualStyleBackColor = false;
            this.Close_But.Click += new System.EventHandler(this.Close_But_Click);
            // 
            // Save_But
            // 
            this.Save_But.BackColor = System.Drawing.Color.DarkOrchid;
            this.Save_But.FlatAppearance.BorderSize = 0;
            this.Save_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_But.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_But.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save_But.Location = new System.Drawing.Point(555, 489);
            this.Save_But.Name = "Save_But";
            this.Save_But.Size = new System.Drawing.Size(77, 39);
            this.Save_But.TabIndex = 5;
            this.Save_But.Text = "Save";
            this.Save_But.UseVisualStyleBackColor = false;
            this.Save_But.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add New USer";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_But);
            this.Controls.Add(this.Close_But);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Next_but;
        private System.Windows.Forms.Button Close_But;
        private System.Windows.Forms.Button Save_But;
        private System.Windows.Forms.Label label1;
        private Filter filter1;
        private System.Windows.Forms.TextBox User_text;
        private System.Windows.Forms.Label UserID_la;
        private System.Windows.Forms.TextBox Con_Text;
        private System.Windows.Forms.TextBox PAss_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ISA_Check;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}