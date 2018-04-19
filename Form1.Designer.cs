namespace CSL0662_project
{
    partial class AddCourse
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
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_fees = new System.Windows.Forms.TextBox();
            this.combobox_duration = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_fees = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_addcourse = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(218, 119);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(151, 20);
            this.txtbox_name.TabIndex = 0;
            // 
            // txtbox_fees
            // 
            this.txtbox_fees.Location = new System.Drawing.Point(218, 178);
            this.txtbox_fees.Name = "txtbox_fees";
            this.txtbox_fees.Size = new System.Drawing.Size(151, 20);
            this.txtbox_fees.TabIndex = 1;
            // 
            // combobox_duration
            // 
            this.combobox_duration.FormattingEnabled = true;
            this.combobox_duration.Items.AddRange(new object[] {
            "C Programming",
            "C++ Programming",
            "Java Programming",
            "C# programming",
            "HTML",
            "CSS",
            ""});
            this.combobox_duration.Location = new System.Drawing.Point(218, 229);
            this.combobox_duration.Name = "combobox_duration";
            this.combobox_duration.Size = new System.Drawing.Size(151, 21);
            this.combobox_duration.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(131, 122);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_fees
            // 
            this.lbl_fees.AutoSize = true;
            this.lbl_fees.Location = new System.Drawing.Point(131, 178);
            this.lbl_fees.Name = "lbl_fees";
            this.lbl_fees.Size = new System.Drawing.Size(33, 13);
            this.lbl_fees.TabIndex = 4;
            this.lbl_fees.Text = "Fees:";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(131, 232);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(48, 13);
            this.lbl_duration.TabIndex = 5;
            this.lbl_duration.Text = "Courses:";
            // 
            // lbl_addcourse
            // 
            this.lbl_addcourse.AutoSize = true;
            this.lbl_addcourse.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addcourse.Location = new System.Drawing.Point(180, 35);
            this.lbl_addcourse.Name = "lbl_addcourse";
            this.lbl_addcourse.Size = new System.Drawing.Size(128, 28);
            this.lbl_addcourse.TabIndex = 6;
            this.lbl_addcourse.Text = "Add Course";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(218, 296);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 392);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_addcourse);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_fees);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.combobox_duration);
            this.Controls.Add(this.txtbox_fees);
            this.Controls.Add(this.txtbox_name);
            this.Name = "AddCourse";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_fees;
        private System.Windows.Forms.ComboBox combobox_duration;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_fees;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_addcourse;
        private System.Windows.Forms.Button btn_save;
    }
}

