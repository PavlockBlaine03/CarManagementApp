namespace CarPaymentApp
{
    partial class SignUpForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.btnLoginPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(342, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Sign Up";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(206, 263);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(392, 53);
            this.btnCreateAccount.TabIndex = 12;
            this.btnCreateAccount.Text = "Sign Up";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(202, 177);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(156, 24);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Enter Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(202, 88);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(161, 24);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Enter Username";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(206, 213);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(392, 20);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(206, 125);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(392, 20);
            this.txtNewUsername.TabIndex = 8;
            // 
            // btnLoginPage
            // 
            this.btnLoginPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPage.Location = new System.Drawing.Point(206, 368);
            this.btnLoginPage.Name = "btnLoginPage";
            this.btnLoginPage.Size = new System.Drawing.Size(392, 53);
            this.btnLoginPage.TabIndex = 7;
            this.btnLoginPage.Text = "Log in";
            this.btnLoginPage.UseVisualStyleBackColor = false;
            this.btnLoginPage.Click += new System.EventHandler(this.btnLoginPage_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.btnLoginPage);
            this.Name = "SignUpForm";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Button btnLoginPage;
    }
}