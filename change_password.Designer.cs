namespace CSL0662_project
{
    partial class change_password
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
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_oldpassword = new System.Windows.Forms.TextBox();
            this.txtbox_newpassword = new System.Windows.Forms.TextBox();
            this.txtbox_conpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(161, 79);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(139, 20);
            this.txtbox_username.TabIndex = 0;
            // 
            // txtbox_oldpassword
            // 
            this.txtbox_oldpassword.Location = new System.Drawing.Point(161, 131);
            this.txtbox_oldpassword.Name = "txtbox_oldpassword";
            this.txtbox_oldpassword.PasswordChar = '*';
            this.txtbox_oldpassword.Size = new System.Drawing.Size(139, 20);
            this.txtbox_oldpassword.TabIndex = 1;
            // 
            // txtbox_newpassword
            // 
            this.txtbox_newpassword.Location = new System.Drawing.Point(161, 177);
            this.txtbox_newpassword.Name = "txtbox_newpassword";
            this.txtbox_newpassword.PasswordChar = '*';
            this.txtbox_newpassword.Size = new System.Drawing.Size(139, 20);
            this.txtbox_newpassword.TabIndex = 2;
            // 
            // txtbox_conpassword
            // 
            this.txtbox_conpassword.Location = new System.Drawing.Point(161, 227);
            this.txtbox_conpassword.Name = "txtbox_conpassword";
            this.txtbox_conpassword.PasswordChar = '*';
            this.txtbox_conpassword.Size = new System.Drawing.Size(139, 20);
            this.txtbox_conpassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Old Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_conpassword);
            this.Controls.Add(this.txtbox_newpassword);
            this.Controls.Add(this.txtbox_oldpassword);
            this.Controls.Add(this.txtbox_username);
            this.Name = "change_password";
            this.Text = "change_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_oldpassword;
        private System.Windows.Forms.TextBox txtbox_newpassword;
        private System.Windows.Forms.TextBox txtbox_conpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}