namespace CSL0662_project
{
    partial class ADD_TEACHER
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
            this.txtbox_teachername = new System.Windows.Forms.TextBox();
            this.txtbox_subject = new System.Windows.Forms.TextBox();
            this.txtbox_qualification = new System.Windows.Forms.TextBox();
            this.lbl_teachername = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_qualification = new System.Windows.Forms.Label();
            this.lbl_addteacher = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_teachername
            // 
            this.txtbox_teachername.Location = new System.Drawing.Point(242, 111);
            this.txtbox_teachername.Name = "txtbox_teachername";
            this.txtbox_teachername.Size = new System.Drawing.Size(158, 20);
            this.txtbox_teachername.TabIndex = 0;
            // 
            // txtbox_subject
            // 
            this.txtbox_subject.Location = new System.Drawing.Point(242, 175);
            this.txtbox_subject.Name = "txtbox_subject";
            this.txtbox_subject.Size = new System.Drawing.Size(158, 20);
            this.txtbox_subject.TabIndex = 1;
            // 
            // txtbox_qualification
            // 
            this.txtbox_qualification.Location = new System.Drawing.Point(242, 244);
            this.txtbox_qualification.Name = "txtbox_qualification";
            this.txtbox_qualification.Size = new System.Drawing.Size(158, 20);
            this.txtbox_qualification.TabIndex = 2;
            // 
            // lbl_teachername
            // 
            this.lbl_teachername.AutoSize = true;
            this.lbl_teachername.Location = new System.Drawing.Point(130, 111);
            this.lbl_teachername.Name = "lbl_teachername";
            this.lbl_teachername.Size = new System.Drawing.Size(81, 13);
            this.lbl_teachername.TabIndex = 3;
            this.lbl_teachername.Text = "Teacher Name:";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(133, 175);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 13);
            this.lbl_subject.TabIndex = 4;
            this.lbl_subject.Text = "Subject:";
            // 
            // lbl_qualification
            // 
            this.lbl_qualification.AutoSize = true;
            this.lbl_qualification.Location = new System.Drawing.Point(133, 251);
            this.lbl_qualification.Name = "lbl_qualification";
            this.lbl_qualification.Size = new System.Drawing.Size(68, 13);
            this.lbl_qualification.TabIndex = 5;
            this.lbl_qualification.Text = "Qualification:";
            // 
            // lbl_addteacher
            // 
            this.lbl_addteacher.AutoSize = true;
            this.lbl_addteacher.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addteacher.Location = new System.Drawing.Point(182, 38);
            this.lbl_addteacher.Name = "lbl_addteacher";
            this.lbl_addteacher.Size = new System.Drawing.Size(137, 28);
            this.lbl_addteacher.TabIndex = 6;
            this.lbl_addteacher.Text = "Add Teacher";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(242, 328);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ADD_TEACHER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 417);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_addteacher);
            this.Controls.Add(this.lbl_qualification);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_teachername);
            this.Controls.Add(this.txtbox_qualification);
            this.Controls.Add(this.txtbox_subject);
            this.Controls.Add(this.txtbox_teachername);
            this.Name = "ADD_TEACHER";
            this.Text = "Add Teacher";
            this.Load += new System.EventHandler(this.ADD_TEACHER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_teachername;
        private System.Windows.Forms.TextBox txtbox_subject;
        private System.Windows.Forms.TextBox txtbox_qualification;
        private System.Windows.Forms.Label lbl_teachername;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_qualification;
        private System.Windows.Forms.Label lbl_addteacher;
        private System.Windows.Forms.Button btn_save;
    }
}