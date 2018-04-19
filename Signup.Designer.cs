namespace CSL0662_project
{
    partial class Signup
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_Username = new System.Windows.Forms.TextBox();
            this.txtbox_pass = new System.Windows.Forms.TextBox();
            this.txtbox_confpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.combobox_usertype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password:";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(162, 76);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(179, 20);
            this.txtbox_name.TabIndex = 6;
            // 
            // txtbox_Username
            // 
            this.txtbox_Username.Location = new System.Drawing.Point(162, 117);
            this.txtbox_Username.Name = "txtbox_Username";
            this.txtbox_Username.Size = new System.Drawing.Size(179, 20);
            this.txtbox_Username.TabIndex = 7;
            // 
            // txtbox_pass
            // 
            this.txtbox_pass.Location = new System.Drawing.Point(162, 155);
            this.txtbox_pass.Name = "txtbox_pass";
            this.txtbox_pass.PasswordChar = '*';
            this.txtbox_pass.Size = new System.Drawing.Size(179, 20);
            this.txtbox_pass.TabIndex = 8;
            // 
            // txtbox_confpass
            // 
            this.txtbox_confpass.Location = new System.Drawing.Point(162, 192);
            this.txtbox_confpass.Name = "txtbox_confpass";
            this.txtbox_confpass.PasswordChar = '*';
            this.txtbox_confpass.Size = new System.Drawing.Size(179, 20);
            this.txtbox_confpass.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combobox_usertype
            // 
            this.combobox_usertype.FormattingEnabled = true;
            this.combobox_usertype.Items.AddRange(new object[] {
            "Teacher",
            "Admin"});
            this.combobox_usertype.Location = new System.Drawing.Point(162, 229);
            this.combobox_usertype.Name = "combobox_usertype";
            this.combobox_usertype.Size = new System.Drawing.Size(179, 21);
            this.combobox_usertype.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usertype:";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 360);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combobox_usertype);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_confpass);
            this.Controls.Add(this.txtbox_pass);
            this.Controls.Add(this.txtbox_Username);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_Username;
        private System.Windows.Forms.TextBox txtbox_pass;
        private System.Windows.Forms.TextBox txtbox_confpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combobox_usertype;
        private System.Windows.Forms.Label label6;
    }
}