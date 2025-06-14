namespace DVLDMySolution
{
    partial class AddFinalLicense
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
            this.drivingInfo1 = new DVLDMySolution.DrivingInfo();
            this.User_ID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Save_Butt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drivingInfo1
            // 
            this.drivingInfo1.Location = new System.Drawing.Point(3, 1);
            this.drivingInfo1.Name = "drivingInfo1";
            this.drivingInfo1.Size = new System.Drawing.Size(634, 258);
            this.drivingInfo1.TabIndex = 0;
            // 
            // User_ID
            // 
            this.User_ID.AutoSize = true;
            this.User_ID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_ID.Location = new System.Drawing.Point(3, 260);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(66, 19);
            this.User_ID.TabIndex = 22;
            this.User_ID.Text = "Notes : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(63, 263);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 64);
            this.textBox1.TabIndex = 23;
            // 
            // Save_Butt
            // 
            this.Save_Butt.BackColor = System.Drawing.Color.DarkOrchid;
            this.Save_Butt.FlatAppearance.BorderSize = 0;
            this.Save_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Butt.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold);
            this.Save_Butt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save_Butt.Location = new System.Drawing.Point(548, 333);
            this.Save_Butt.Name = "Save_Butt";
            this.Save_Butt.Size = new System.Drawing.Size(73, 31);
            this.Save_Butt.TabIndex = 24;
            this.Save_Butt.Text = "Save";
            this.Save_Butt.UseVisualStyleBackColor = false;
            this.Save_Butt.Click += new System.EventHandler(this.Save_Butt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(457, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddFinalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_Butt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.drivingInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFinalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Final License";
            this.Load += new System.EventHandler(this.AddFinalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrivingInfo drivingInfo1;
        private System.Windows.Forms.Label User_ID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Save_Butt;
        private System.Windows.Forms.Button button1;
    }
}