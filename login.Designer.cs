namespace CSL0662_project
{
    partial class login
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
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn_admin = new System.Windows.Forms.RadioButton();
            this.rbtn_user = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(279, 103);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(159, 20);
            this.txtbox_username.TabIndex = 4;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(279, 158);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(159, 20);
            this.txtbox_password.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(279, 247);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login ";
            // 
            // rbtn_admin
            // 
            this.rbtn_admin.AutoSize = true;
            this.rbtn_admin.Location = new System.Drawing.Point(185, 208);
            this.rbtn_admin.Name = "rbtn_admin";
            this.rbtn_admin.Size = new System.Drawing.Size(97, 17);
            this.rbtn_admin.TabIndex = 8;
            this.rbtn_admin.TabStop = true;
            this.rbtn_admin.Text = "Login as Admin";
            this.rbtn_admin.UseVisualStyleBackColor = true;
            // 
            // rbtn_user
            // 
            this.rbtn_user.AutoSize = true;
            this.rbtn_user.Location = new System.Drawing.Point(358, 208);
            this.rbtn_user.Name = "rbtn_user";
            this.rbtn_user.Size = new System.Drawing.Size(90, 17);
            this.rbtn_user.TabIndex = 9;
            this.rbtn_user.TabStop = true;
            this.rbtn_user.Text = "Login as User";
            this.rbtn_user.UseVisualStyleBackColor = true;
            this.rbtn_user.CheckedChanged += new System.EventHandler(this.rbtn_user_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 317);
            this.Controls.Add(this.rbtn_user);
            this.Controls.Add(this.rbtn_admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtn_admin;
        private System.Windows.Forms.RadioButton rbtn_user;
    }
}