namespace Class
{
    partial class ControlPanel
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
            this.addPerson = new System.Windows.Forms.Button();
            this.searchPerson = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlLogin.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPerson
            // 
            this.addPerson.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addPerson.Location = new System.Drawing.Point(46, 53);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(118, 52);
            this.addPerson.TabIndex = 0;
            this.addPerson.Text = "Add Patient";
            this.addPerson.UseVisualStyleBackColor = false;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // searchPerson
            // 
            this.searchPerson.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchPerson.Location = new System.Drawing.Point(230, 53);
            this.searchPerson.Name = "searchPerson";
            this.searchPerson.Size = new System.Drawing.Size(131, 52);
            this.searchPerson.TabIndex = 1;
            this.searchPerson.Text = "Search Patiants";
            this.searchPerson.UseVisualStyleBackColor = false;
            this.searchPerson.Click += new System.EventHandler(this.searchPerson_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlLogin.Controls.Add(this.txtPW);
            this.pnlLogin.Controls.Add(this.txtUName);
            this.pnlLogin.Controls.Add(this.lblfeedback);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(26, 24);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(475, 178);
            this.pnlLogin.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(167, 92);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(100, 20);
            this.txtPW.TabIndex = 7;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(167, 46);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(100, 20);
            this.txtUName.TabIndex = 6;
            // 
            // lblfeedback
            // 
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.Location = new System.Drawing.Point(343, 14);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(0, 13);
            this.lblfeedback.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLogin.Location = new System.Drawing.Point(192, 138);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(68, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlControls.Controls.Add(this.addPerson);
            this.pnlControls.Controls.Add(this.searchPerson);
            this.pnlControls.Location = new System.Drawing.Point(51, 236);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(408, 147);
            this.pnlControls.TabIndex = 3;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(523, 423);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlLogin);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.Button searchPerson;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblfeedback;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUName;
    }
}