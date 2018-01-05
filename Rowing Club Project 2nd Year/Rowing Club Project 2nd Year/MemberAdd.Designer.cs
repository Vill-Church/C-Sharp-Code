namespace Rowing_Club_Project_2nd_Year
{
    partial class MemberAdd
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
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.JoinDate = new System.Windows.Forms.DateTimePicker();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumberTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(170, 109);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(352, 38);
            this.FirstNameTB.TabIndex = 0;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(170, 193);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(352, 38);
            this.LastNameTB.TabIndex = 0;
            // 
            // JoinDate
            // 
            this.JoinDate.Location = new System.Drawing.Point(170, 283);
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.Size = new System.Drawing.Size(352, 38);
            this.JoinDate.TabIndex = 1;
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(170, 373);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(352, 38);
            this.DOB.TabIndex = 1;
            // 
            // PhoneNumberTB
            // 
            this.PhoneNumberTB.Location = new System.Drawing.Point(170, 463);
            this.PhoneNumberTB.Name = "PhoneNumberTB";
            this.PhoneNumberTB.Size = new System.Drawing.Size(352, 38);
            this.PhoneNumberTB.TabIndex = 0;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(170, 559);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(352, 38);
            this.EmailTB.TabIndex = 0;
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Items.AddRange(new object[] {
            "Normal",
            "Premium",
            "Staff"});
            this.TypeCB.Location = new System.Drawing.Point(170, 649);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(352, 39);
            this.TypeCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Join Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Type";
            // 
            // AddMember
            // 
            this.AddMember.Location = new System.Drawing.Point(170, 694);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(352, 47);
            this.AddMember.TabIndex = 4;
            this.AddMember.Text = "Add";
            this.AddMember.UseVisualStyleBackColor = true;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // MemberAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 804);
            this.Controls.Add(this.AddMember);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.JoinDate);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PhoneNumberTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Name = "MemberAdd";
            this.Text = "MemberAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.DateTimePicker JoinDate;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.TextBox PhoneNumberTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddMember;
    }
}