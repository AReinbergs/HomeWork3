namespace HW_WinApp
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ErrorName = new System.Windows.Forms.Label();
            this.ErrorSurname = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ErrorPassword = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.lblRandomCode = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCodeError = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(296, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(296, 71);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(241, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(296, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(241, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(296, 149);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(241, 20);
            this.txtRepeatPassword.TabIndex = 0;
            this.txtRepeatPassword.Enter += new System.EventHandler(this.txtRepeatPassword_Enter);
            this.txtRepeatPassword.Leave += new System.EventHandler(this.txtRepeatPassword_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Repeat Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "SSN";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(296, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "E-mail";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(296, 253);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(62, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Code";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 2;
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(561, 49);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(95, 13);
            this.ErrorName.TabIndex = 1;
            this.ErrorName.Text = "Please enter name";
            this.ErrorName.Visible = false;
            // 
            // ErrorSurname
            // 
            this.ErrorSurname.AutoSize = true;
            this.ErrorSurname.ForeColor = System.Drawing.Color.Red;
            this.ErrorSurname.Location = new System.Drawing.Point(561, 78);
            this.ErrorSurname.Name = "ErrorSurname";
            this.ErrorSurname.Size = new System.Drawing.Size(109, 13);
            this.ErrorSurname.TabIndex = 1;
            this.ErrorSurname.Text = "Please enter surname";
            this.ErrorSurname.Visible = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(293, 104);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(49, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Fullname";
            this.lblFullName.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(296, 201);
            this.maskedTextBox1.Mask = "000000-00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // ErrorPassword
            // 
            this.ErrorPassword.AutoSize = true;
            this.ErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.ErrorPassword.Location = new System.Drawing.Point(561, 130);
            this.ErrorPassword.Name = "ErrorPassword";
            this.ErrorPassword.Size = new System.Drawing.Size(202, 13);
            this.ErrorPassword.TabIndex = 1;
            this.ErrorPassword.Text = "Need 5 char; digit; capital; special symbol";
            this.ErrorPassword.Visible = false;
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.ForeColor = System.Drawing.Color.Red;
            this.lblRepeat.Location = new System.Drawing.Point(561, 156);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(122, 13);
            this.lblRepeat.TabIndex = 1;
            this.lblRepeat.Text = "Password doesn\'t match";
            this.lblRepeat.Visible = false;
            // 
            // lblRandomCode
            // 
            this.lblRandomCode.AutoSize = true;
            this.lblRandomCode.Location = new System.Drawing.Point(376, 260);
            this.lblRandomCode.Name = "lblRandomCode";
            this.lblRandomCode.Size = new System.Drawing.Size(32, 13);
            this.lblRandomCode.TabIndex = 5;
            this.lblRandomCode.Text = "Code";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(561, 234);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email doesn\'t match criteria";
            this.lblEmail.Visible = false;
            // 
            // lblCodeError
            // 
            this.lblCodeError.AutoSize = true;
            this.lblCodeError.ForeColor = System.Drawing.Color.Red;
            this.lblCodeError.Location = new System.Drawing.Point(561, 260);
            this.lblCodeError.Name = "lblCodeError";
            this.lblCodeError.Size = new System.Drawing.Size(101, 13);
            this.lblCodeError.TabIndex = 7;
            this.lblCodeError.Text = "Code doesn\'t match";
            this.lblCodeError.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(202, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 48);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(379, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCodeError);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRandomCode);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.ErrorPassword);
            this.Controls.Add(this.ErrorSurname);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorSurname;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ErrorPassword;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Label lblRandomCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCodeError;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}

