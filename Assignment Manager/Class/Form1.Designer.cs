namespace Class
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
            this.lblfName = new System.Windows.Forms.Label();
            this.lblmName = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.dtpbday = new System.Windows.Forms.DateTimePicker();
            this.lblbday = new System.Windows.Forms.Label();
            this.lblPerson_ID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblfName.Location = new System.Drawing.Point(9, 69);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(57, 13);
            this.lblfName.TabIndex = 0;
            this.lblfName.Text = "First Name";
            // 
            // lblmName
            // 
            this.lblmName.AutoSize = true;
            this.lblmName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblmName.Location = new System.Drawing.Point(9, 123);
            this.lblmName.Name = "lblmName";
            this.lblmName.Size = new System.Drawing.Size(69, 13);
            this.lblmName.TabIndex = 1;
            this.lblmName.Text = "Middle Name";
            // 
            // lbllName
            // 
            this.lbllName.AutoSize = true;
            this.lbllName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbllName.Location = new System.Drawing.Point(9, 183);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(58, 13);
            this.lbllName.TabIndex = 2;
            this.lbllName.Text = "Last Name";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStreet1.Location = new System.Drawing.Point(12, 242);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(44, 13);
            this.lblStreet1.TabIndex = 3;
            this.lblStreet1.Text = "Street 1";
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStreet2.Location = new System.Drawing.Point(9, 297);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(44, 13);
            this.lblStreet2.TabIndex = 4;
            this.lblStreet2.Text = "Street 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCity.Location = new System.Drawing.Point(12, 363);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblState.Location = new System.Drawing.Point(163, 90);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblZip.Location = new System.Drawing.Point(163, 156);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 7;
            this.lblZip.Text = "Zip";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhone.Location = new System.Drawing.Point(163, 215);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmail.Location = new System.Drawing.Point(163, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email Address";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSubmit.Location = new System.Drawing.Point(433, 317);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(172, 59);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Enter New Patient";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(12, 90);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 11;
            // 
            // txtMiddle
            // 
            this.txtMiddle.Location = new System.Drawing.Point(12, 149);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(100, 20);
            this.txtMiddle.TabIndex = 12;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(12, 208);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 13;
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(12, 264);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(100, 20);
            this.txtStreet1.TabIndex = 14;
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(12, 326);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(100, 20);
            this.txtStreet2.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(15, 393);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 16;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(166, 180);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(166, 242);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 317);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFeedback.Location = new System.Drawing.Point(322, 80);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Padding = new System.Windows.Forms.Padding(5);
            this.lblFeedback.Size = new System.Drawing.Size(108, 23);
            this.lblFeedback.TabIndex = 25;
            this.lblFeedback.Text = "Patient Information:";
            // 
            // dtpbday
            // 
            this.dtpbday.Location = new System.Drawing.Point(166, 393);
            this.dtpbday.Name = "dtpbday";
            this.dtpbday.Size = new System.Drawing.Size(200, 20);
            this.dtpbday.TabIndex = 22;
            // 
            // lblbday
            // 
            this.lblbday.AutoSize = true;
            this.lblbday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblbday.Location = new System.Drawing.Point(163, 363);
            this.lblbday.Name = "lblbday";
            this.lblbday.Size = new System.Drawing.Size(45, 13);
            this.lblbday.TabIndex = 23;
            this.lblbday.Text = "Birthday";
            // 
            // lblPerson_ID
            // 
            this.lblPerson_ID.AutoSize = true;
            this.lblPerson_ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPerson_ID.Location = new System.Drawing.Point(558, 19);
            this.lblPerson_ID.Name = "lblPerson_ID";
            this.lblPerson_ID.Size = new System.Drawing.Size(54, 13);
            this.lblPerson_ID.TabIndex = 28;
            this.lblPerson_ID.Text = "Patient ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdate.Location = new System.Drawing.Point(530, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 45);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update Patient";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDelete.Location = new System.Drawing.Point(433, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 45);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete Patient";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(166, 120);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 32;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(95, 419);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 33;
            this.txtState.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Patient Information Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPerson_ID);
            this.Controls.Add(this.lblbday);
            this.Controls.Add(this.dtpbday);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet2);
            this.Controls.Add(this.txtStreet1);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet2);
            this.Controls.Add(this.lblStreet1);
            this.Controls.Add(this.lbllName);
            this.Controls.Add(this.lblmName);
            this.Controls.Add(this.lblfName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.Label lblmName;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.DateTimePicker dtpbday;
        private System.Windows.Forms.Label lblbday;
        private System.Windows.Forms.Label lblPerson_ID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label1;
    }
}

